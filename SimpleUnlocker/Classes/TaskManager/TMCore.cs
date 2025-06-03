using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SU.Classes;
using System.Windows.Forms;
using System.Security.Principal;
using System.ServiceProcess;
using System.Management;
using log4net;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SU.Classes.TaskManager
{
    /// <summary>
    /// Класс процесса
    /// </summary>
    internal class Prc
    {
        public string ProcessName { get; set; }
        public int ProcessID { get; set; }
        public string ProcessState { get; set; }
        public string ProcessOwner { get; set; }
        public string ProcessDescription { get; set; }
        public Nullable<bool> ProcessCritical { get; set; }
    }

    /// <summary>
    /// Класс службы
    /// </summary>
    internal class Srv
    {
        public string serviceName { get; set; }
        public string serviceDisplayName { get; set; }
        public string serviceStatus { get; set; }
        public string serviceStartType { get; set; }
        public void Delete()
        {
            IntPtr scmHandle = Utils.OpenSCManager(null, null, Utils.SC_MANAGER_ALL_ACCESS);

            if (scmHandle == IntPtr.Zero)
            {
                throw new InvalidOperationException("Не удалось открыть менеджер служб.");
            }

            try
            {
                IntPtr serviceHandle = Utils.OpenService(scmHandle, serviceName, Utils.SERVICE_STOP | Utils.SERVICE_QUERY_STATUS | Utils.DELETE);

                if (serviceHandle == IntPtr.Zero)
                {
                    throw new InvalidOperationException("Не удалось открыть службу.");
                }

                try
                {
                    if (!Utils.DeleteService(serviceHandle))
                    {
                        int error = Marshal.GetLastWin32Error();
                        throw new InvalidOperationException($"Не удалось удалить службу. Код ошибки: {error}");
                    }
                }
                finally
                {
                    Utils.CloseServiceHandle(serviceHandle);
                }
            }
            finally
            {
                Utils.CloseServiceHandle(scmHandle);
            }
        }
    }

    internal class ProcessComparer : IEqualityComparer<Process>
    {

        public bool Equals(Process x, Process y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Process obj)
        {
            return (obj.Id.ToString() + obj.ProcessName).GetHashCode();
        }
    }

    internal class ProcessComparerMemoryUsage : IEqualityComparer<Process>
    {

        public bool Equals(Process x, Process y)
        {
            return (x.Id == y.Id && x.WorkingSet64 != y.WorkingSet64);
        }

        public int GetHashCode(Process obj)
        {
            return (obj.Id.ToString() + obj.ProcessName).GetHashCode();
        }
    }

    /// <summary>
    /// Ядро диспетчера задач
    /// </summary>
    internal class TMCore
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public IEnumerable<Process> CurrentRunProcess
        {
            get
            {
                return Process.GetProcesses().Intersect(oldProcesses, new ProcessComparerMemoryUsage()).ToList();
            }
        }

        public List<Prc> Processes
        {
            get
            {
                processes = Task.Run(() => GetListProcesses()).Result;
                return processes;
            }
            private set
            {
                processes = value;
            }
        }

        private List<Prc> processes = new List<Prc>();
        List<Process> oldProcesses = new List<Process>();

        ManagementEventWatcher startWatch;
        ManagementEventWatcher stopWatch;

        public delegate void ProcessHandler(UInt32 processId);

        public event ProcessHandler NotifyStartNewProcess;
        public event ProcessHandler NotifyStopProcess;

        public event Action NotifyToUpdate;

        private void KillTask(Prc item, bool Uncritical = false)
        {
            try
            {
                if (Uncritical) CriticalProcess(Process.GetProcessById(item.ProcessID), 0);
                Process.GetProcessById(item.ProcessID).Kill();
                logger.Info($"Был завершен процесс {item.ProcessID}");
            }
            catch
            {
                MessageBox.Show("Произошла ошибка при попытке убить процесс.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Коныертация процесса в класс Prc
        /// </summary>
        /// <param name="prc">Процесс</param>
        /// <returns>Готовый класс Prc</returns>
        public async Task<Prc> ToPrcClass(Process prc)
        {
            Prc convertPrc = new Prc()
            {
                ProcessName = prc.ProcessName,
                ProcessID = prc.Id,
                ProcessOwner = await GetProcessUser(prc),
                ProcessState = await GetProcessState(prc),
                ProcessCritical = IsProcessCritical(prc),
            };

            try
            {
                convertPrc.ProcessDescription = await GetProcessDescription(prc);
            }
            catch
            {
                convertPrc.ProcessDescription = "";
            }

            return convertPrc;
        }

        /// <summary>
        /// Заморозка процесса
        /// </summary>
        /// <param name="ProcessID">ID Процесса</param>
        public void SuspendProcess(int ProcessID)
        {
            using (Process p = Process.GetProcessById(ProcessID))
            {
                try
                {
                    Utils.NtSuspendProcess(p.Handle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Разморозка процесса
        /// </summary>
        /// <param name="ProcessID">ID Процесса</param>
        public void ResumeProcess(int ProcessID)
        {
            using (Process p = Process.GetProcessById(ProcessID))
            {
                try
                {
                    Utils.NtResumeProcess(p.Handle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Получение имени пользователя от которого был запущен процесс
        /// </summary>
        /// <param name="process">Класс процесса</param>
        /// <returns>Имя пользователя</returns>
        public async Task<string> GetProcessUser(Process process)
        {
            return await Task.Run(() => 
            {
                IntPtr processHandle = IntPtr.Zero;
                try
                {
                    Utils.OpenProcessToken(process.Handle, 8, out processHandle);
                    return new WindowsIdentity(processHandle).Name?.Split('\\').Last();
                }
                catch
                {
                    return null;
                }
                finally
                {
                    Utils.CloseHandle(processHandle);
                }
            });
        }

        public async Task<string> GetProcessState(Process process)
        {
            return await Task.Run(() =>
            {
                return (process.Threads.Count > 0 && process.Threads[0].ThreadState == System.Diagnostics.ThreadState.Wait && process.Threads[0].WaitReason == ThreadWaitReason.Suspended) ? "Suspended" : "Working";
            });
        }

        public async Task<string> GetProcessDescription(Process prc)
        {
            try
            {
                return await Task.Run(() => prc.MainModule.FileVersionInfo.FileDescription);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Сделать процесс критическим или нет
        /// </summary>
        /// <param name="process">Класс процесса</param>
        /// <param name="isCritical">Делать ли его критическим</param>
        public void CriticalProcess(Process process, int isCritical)
        {
            int BreakOnTermination = 0x1D;

            try
            {
                Utils.NtSetInformationProcess(process.Handle, BreakOnTermination, ref isCritical, sizeof(int));
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Завершение процесса
        /// </summary>
        /// <param name="prcList">Лист где находятся процессы</param>
        /// <param name="UncriticalProcess">Делать ли процесс не критическим</param>
        public void TerminateProcesses(ListView prcList, bool UncriticalProcess)
        {
            foreach (int index in prcList.SelectedIndices)
            {
                var item = (Prc)prcList.Items[index].Tag;
                if (item.ProcessCritical == true)
                {
                    if (UncriticalProcess)
                    {
                        KillTask(item, true);
                    }
                    else
                    {
                        if (MessageBox.Show($"Процесс '{item.ProcessName}' является критическим. Вы действительно хотите завершить его?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            KillTask(item);
                        }
                    }
                }
                else
                {
                    KillTask(item);
                }
            }
        }

        /// <summary>
        /// Является ли этот процесс критическим
        /// </summary>
        /// <param name="pr">Класс процесса</param>
        /// <returns>Логическое значение или Null</returns>
        public bool? IsProcessCritical(Process pr)
        {
            try
            {
                uint Value = 0;
                int size;
                int Result = Utils.NtQueryInformationProcess(pr.Handle, (uint)29, ref Value, sizeof(uint), out size);
                if (Result != 0 || size != sizeof(uint)) return null;

                return (Value != 0);
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<Prc>> GetListProcesses()
        {
            logger.Debug("Получение списка процессов");
            processes = new List<Prc>();
            Process[] p = Process.GetProcesses();
            oldProcesses = p.ToList();

            foreach (Process prc in p)
            {
                processes.Add(await ToPrcClass(prc));
            }

            logger.Debug($"Успешно! Было получено {processes.Count} процессов");
            return processes;
        }

        public List<Srv> GetListServices()
        {
            logger.Debug("Получение списка служб");
            ServiceController[] services = ServiceController.GetServices();

            List<Srv> servicesList = services
                .Where(service => !string.IsNullOrWhiteSpace(service.ServiceName))
                .Select(service => new Srv
                {
                    serviceName = service.ServiceName,
                    serviceDisplayName = service.DisplayName,
                    serviceStatus = GetServiceStatus(service)
                })
                .ToList();

            logger.Debug($"Успешно! Было получено {servicesList.Count} служб");
            return servicesList;
        }

        public async Task<List<Srv>> GetListServicesAsync()
        {
            logger.Debug("Получение списка служб");

            ServiceController[] services = await Task.Run(() => ServiceController.GetServices());

            List<Srv> servicesList = await Task.Run(() =>
                services
                    .Where(service => !string.IsNullOrWhiteSpace(service.ServiceName))
                    .Select(service => new Srv
                    {
                        serviceName = service.ServiceName,
                        serviceDisplayName = service.DisplayName,
                        serviceStatus = GetServiceStatus(service),
                        serviceStartType = service.StartType.ToString()
                    })
                    .ToList());

            logger.Debug($"Успешно! Было получено {servicesList.Count} служб");
            return servicesList;
        }

        public string GetServiceStatus(ServiceController service)
        {
            try
            {
                return service.Status.ToString();
            }
            catch (Exception)
            {
                return "Unknown";
            }
        }

        public List<Process> UpdateProcessList()
        {
            logger.Debug("Обновление списка процессов");

            List<Process> processNew = Process.GetProcesses().ToList();
            List<Process> newProcesses = processNew.Except(oldProcesses, new ProcessComparer()).ToList();
            oldProcesses.AddRange(newProcesses);

            logger.Debug("Обновление информации о процессах");

            if (newProcesses.Count == 0)
                return null;

            Prc[] Tasks = Task.WhenAll(newProcesses.Select(ToPrcClass)).Result;
            this.processes.AddRange(Tasks);
            logger.Debug($"Успешно обновлено {newProcesses.Count} процессов!");
            return newProcesses;
        }

        public async Task<List<Process>> UpdateProcessListAsync()
        {
            logger.Debug("Обновление списка процессов");

            List<Process> processNew = (await Task.Run(() => Process.GetProcesses().ToList())).ToList();
            List<Process> newProcesses = processNew.Except(oldProcesses, new ProcessComparer()).ToList();
            oldProcesses.AddRange(newProcesses);

            logger.Debug("Обновление информации о процессах");

            if (newProcesses.Count == 0)
                return null;

            Prc[] Tasks = await Task.WhenAll(newProcesses.Select(ToPrcClass));
            this.processes.AddRange(Tasks);
            logger.Debug($"Успешно обновлено {newProcesses.Count} процессов!");
            return newProcesses;
        }

        public async Task<Prc> UpdateProcessInfo(int prcID)
        {
            using (Process p = Process.GetProcessById(prcID))
            {
                return await ToPrcClass(p);
            }
        }

        public void DeleteProcess(int pid)
        {
            if (processes.Any(x => x.ProcessID == pid))
                processes.Remove(processes.Find(x => x.ProcessID == pid));

            if (oldProcesses.Any(x => x.Id == pid))
                oldProcesses.Remove(oldProcesses.Find(x => x.Id == pid));
        }

        public void StartProcessEvent(object sender, EventArrivedEventArgs e)
        {
            NotifyStartNewProcess?.Invoke(Convert.ToUInt32(e.NewEvent.Properties["ProcessId"].Value));
        }

        public void StopProcessEvent(object sender, EventArrivedEventArgs e)
        {
            NotifyStopProcess?.Invoke(Convert.ToUInt32(e.NewEvent.Properties["ProcessId"].Value));
            this.DeleteProcess(Convert.ToInt32(e.NewEvent.Properties["ProcessId"].Value));
        }

        public void InitEventsProcess()
        {
            logger.Info("Инициализация ивентов на запуск и остановку процесса");
            startWatch = new ManagementEventWatcher(
                new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace WITHIN 1"));
            startWatch.EventArrived += StartProcessEvent;
            startWatch.Start();
            stopWatch = new ManagementEventWatcher(
               new WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace"));
            stopWatch.EventArrived += StopProcessEvent;
            stopWatch.Start();
        }

        public void EndEventsProcess()
        {
            logger.Info("Остановка ивентов на запуск и остановку процесса");
            startWatch.Stop();
            stopWatch.Stop();
        }
    }
}
