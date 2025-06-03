using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU.Classes.TaskManager;
using SU.Classes;
using System.Diagnostics;
using System.ServiceProcess;
using log4net;
using System.Threading;
using Microsoft.Win32;
using SU.Forms.TaskMgr;

namespace SU.Forms
{
    public partial class TaskManager : Form
    {
        private static ILog logger = LogManager.GetLogger(typeof(TaskManager));
        readonly PerformanceCounter CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        readonly PerformanceCounter RAM = new PerformanceCounter("Memory", "Available MBytes");

        private TMCore taskMgrCore;
        List<Prc> runningProcess = new List<Prc>();

        ServiceController sc = new ServiceController();

        private ListViewItem ToListViewItem(Prc prc)
        {
            string[] row = new string[] { prc.ProcessName, prc.ProcessID.ToString(), prc.ProcessState, prc.ProcessOwner, prc.ProcessCritical.ToString(), prc.ProcessDescription };
            ListViewItem listview = new ListViewItem(row);

            string lowerCaseOwner = prc.ProcessOwner?.ToLower();
            string lowerCaseState = prc.ProcessState.ToLower();

            if (lowerCaseOwner != null)
            {
                if (lowerCaseOwner.Contains("service"))
                    listview.BackColor = Color.SkyBlue;
                if (lowerCaseOwner.Contains("система"))
                    listview.BackColor = Color.Aqua;
            }

            if (prc.ProcessCritical == true)
                listview.BackColor = Color.Orange;

            if (lowerCaseState == "suspended")
                listview.BackColor = Color.Gray;

            listview.Tag = prc;

            return listview;
        }
        private async Task GetProcesses()
        {
            logger.Info("Получение процессов");
            TMView.BeginUpdate();
            TMView.Items.Clear();

            runningProcess = await taskMgrCore.GetListProcesses();

            foreach (Prc p in runningProcess)
            {
                TMView.Items.Add(ToListViewItem(p));
            }
            TMView.EndUpdate();
            logger.Info($"Процессов в TMView: {TMView.Items.Count}");
        }
        private async Task GetServices()
        {
            logger.Info("Получение служб");
            ServiceView.BeginUpdate();
            ServiceView.Items.Clear();

            foreach (Srv s in await taskMgrCore.GetListServicesAsync())
            {
                ServiceView.Items.Add(new ListViewItem(new string[] { s.serviceName, s.serviceDisplayName, s.serviceStatus, s.serviceStartType }) { Tag = s });
            }

            ServiceView.EndUpdate();
        }
        private void DeleteProcess(uint processId)
        {
            foreach (ListViewItem item in TMView.Items)
            {
                Prc prc = (Prc)item.Tag;
                var _ = Convert.ToUInt32(prc.ProcessID);
                if (_ == processId)
                {
                    logger.Info($"Процесс: {prc.ProcessName} был завершён");
                    TMView.Items.Remove(item);
                    TMView.Update();
                    return;
                }
            }
        }

        private void StartNewProcess(uint processId)
        {
            List<Process> processes = taskMgrCore.UpdateProcessList();
            if (processes == null || processes.Count == 0)
            {
                return;
            }

            foreach (Process prc in processes)
            {
                Prc pInfo = Task.Run(async () => await taskMgrCore.ToPrcClass(prc)).Result;
                logger.Info($"Процесс: {pInfo.ProcessName} был запущен");
                TMView.Items.Add(ToListViewItem(pInfo));
            }
        }

        public TaskManager()
        {
            InitializeComponent();
            ThreadPool.SetMinThreads(1000, 1000);
        }

        private void TaskManager_Shown(object sender, EventArgs e)
        {
            taskMgrCore = new TMCore();
            GetProcesses();
            GetServices();

            taskMgrCore.InitEventsProcess();
            taskMgrCore.NotifyStopProcess += DeleteProcess;
            taskMgrCore.NotifyStartNewProcess += StartNewProcess;

            CPUTimer.Enabled = true;
            RAMTimer.Enabled = true;
            PrcTimer.Enabled = true;
        }

        private async void RefreshMenuBtn_Click(object sender, EventArgs e)
        {
            RefreshMenuBtn.Enabled = false;
            await GetProcesses();
            RefreshMenuBtn.Enabled = true;
        }

        private void PrcTimer_Tick(object sender, EventArgs e)
        {
            ProcessesSSLabel.Text = $"Процессов: {Process.GetProcesses().Length}";
        }

        private void CPUTimer_Tick(object sender, EventArgs e)
        {
            CPUSSLabel.Text = $"CPU Usage: {Math.Round(CPU.NextValue())} %";
        }

        private void RAMTimer_Tick(object sender, EventArgs e)
        {
            RAMSSLabel.Text = $"RAM Free: {RAM.NextValue()} MB";
        }

        private void deletePrcMItem_Click(object sender, EventArgs e)
        {
            taskMgrCore.TerminateProcesses(TMView, uncriticalPrcStripItem.Checked);
        }

        private void TMView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right &&
                TMView.FocusedItem != null &&
                TMView.FocusedItem.Bounds.Contains(e.Location))
            {
                Prc i = (Prc)TMView.FocusedItem.Tag;
                suspendPrcMItem.Text = i.ProcessState == "Suspended" ? "Разморозить" : "Заморозить";
                criticalPrcMItem.Text = i.ProcessCritical == true ? "Сделать не критическим" : "Сделать критическим";
                ProcessContextMenu.Show(Cursor.Position);
            }
        }

        private async void suspendPrcMItem_Click(object sender, EventArgs e)
        {
            Prc i = (Prc)TMView.FocusedItem.Tag;
            if (i.ProcessState == "Suspended") taskMgrCore.ResumeProcess(i.ProcessID);
            else taskMgrCore.SuspendProcess(i.ProcessID);
            TMView.Items[TMView.FocusedItem.Index] = ToListViewItem(await taskMgrCore.UpdateProcessInfo(i.ProcessID));
        }

        private async void criticalPrcMItem_Click(object sender, EventArgs e)
        {
            Prc i = (Prc)TMView.FocusedItem.Tag;
            using (Process p = Process.GetProcessById(i.ProcessID))
            {
                taskMgrCore.CriticalProcess(p, i.ProcessCritical == true ? 0 : 1);
            }
            
            TMView.Items[TMView.FocusedItem.Index] = ToListViewItem(await taskMgrCore.UpdateProcessInfo(i.ProcessID));
        }

        private void prcPathMItem_Click(object sender, EventArgs e)
        {
            Prc prcInfo = (Prc)TMView.FocusedItem.Tag;

            using (Process prc = Process.GetProcessById(prcInfo.ProcessID))
            {
                Utils.RunFile("explorer.exe", $"/n,/select, \"{prc.MainModule.FileName}\"", false, false, false);
            }
        }

        private void infoPrcMItem_Click(object sender, EventArgs e)
        {
            Prc prcInfo = (Prc)TMView.FocusedItem.Tag;

            using (Process prc = Process.GetProcessById(prcInfo.ProcessID))
            {
                Utils.ShowFileProperties(prc.MainModule.FileName);
            }
        }

        private void TerminateMenuBtn_Click(object sender, EventArgs e)
        {
            if (TMView.SelectedIndices.Count > 0)
            {
                taskMgrCore.TerminateProcesses(TMView, uncriticalPrcStripItem.Checked);
            }
        }

        private void TaskManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            taskMgrCore.EndEventsProcess();
            Utils.CloseForm(e);
        }

        private async void autoCheckPrcStripItem_Click(object sender, EventArgs e)
        {
            if (autoCheckPrcStripItem.Checked) taskMgrCore.InitEventsProcess();
            else taskMgrCore.EndEventsProcess();
            await GetProcesses();
        }

        private void topMostStripItem_Click(object sender, EventArgs e)
        {
            TopMostTimer.Enabled = topMostStripItem.Checked;

            if (!topMostStripItem.Checked && !Properties.Settings.Default.AlwaysOnTop)
            {
                Utils.SetWindowPos(Handle, Utils.HWND_NOTOPMOST, 0, 0, 0, 0, Utils.TOPMOST_FLAGS);
            }
        }

        private void TopMostTimer_Tick(object sender, EventArgs e)
        {
            Utils.SetWindowPos(Handle, Utils.HWND_TOPMOST, 0, 0, 0, 0, Utils.TOPMOST_FLAGS);
        }

        private void noHiddenFormStripItem_Click(object sender, EventArgs e)
        {
            CheckMinimaze.Enabled = noHiddenFormStripItem.Checked;
        }

        private void CheckMinimaze_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) WindowState = FormWindowState.Normal;
        }

        private async void SuspendMenuBtn_Click(object sender, EventArgs e)
        {
            if (TMView.SelectedIndices.Count > 0)
            {
                foreach (int index in TMView.SelectedIndices)
                {
                    Prc item = (Prc)TMView.Items[index].Tag;
                    if (!item.ProcessState.ToLower().Contains("suspended"))
                    {
                        taskMgrCore.SuspendProcess(item.ProcessID);
                        TMView.Items[TMView.FocusedItem.Index] = ToListViewItem(await taskMgrCore.UpdateProcessInfo(item.ProcessID));
                    }
                }
            }
        }

        private async void ResumeMenuBtn_Click(object sender, EventArgs e)
        {
            if (TMView.SelectedIndices.Count > 0)
            {
                foreach (int index in TMView.SelectedIndices)
                {
                    Prc item = (Prc)TMView.Items[index].Tag;
                    if (item.ProcessState.ToLower().Contains("suspended"))
                    {
                        taskMgrCore.ResumeProcess(item.ProcessID);
                        TMView.Items[TMView.FocusedItem.Index] = ToListViewItem(await taskMgrCore.UpdateProcessInfo(item.ProcessID));
                    }
                }
            }
        }

        private async void CriticalMenuBtn_Click(object sender, EventArgs e)
        {
            if (TMView.SelectedIndices.Count > 0)
            {
                foreach (int index in TMView.SelectedIndices)
                {
                    Prc item = (Prc)TMView.Items[index].Tag;
                    try
                    {
                        using (Process p = Process.GetProcessById(item.ProcessID))
                        {
                            taskMgrCore.CriticalProcess(p, 1);
                            TMView.Items[TMView.FocusedItem.Index] = ToListViewItem(await taskMgrCore.UpdateProcessInfo(item.ProcessID));
                        }
                    } 
                    catch (Exception ex)
                    {
                        logger.Error(ex);
                    }
                }
            }
        }

        private async void UncriticalMenuBtn_Click(object sender, EventArgs e)
        {
            if (TMView.SelectedIndices.Count > 0)
            {
                foreach (int index in TMView.SelectedIndices)
                {
                    Prc item = (Prc)TMView.Items[index].Tag;
                    try
                    {
                        using (Process p = Process.GetProcessById(item.ProcessID))
                        {
                            taskMgrCore.CriticalProcess(p, 0);
                            TMView.Items[TMView.FocusedItem.Index] = ToListViewItem(await taskMgrCore.UpdateProcessInfo(item.ProcessID));
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex);
                    }
                }
            }
        }

        private void ServiceView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right &&
                ServiceView.FocusedItem != null &&
                ServiceView.FocusedItem.Bounds.Contains(e.Location))
            {
                ServiceContextMenu.Show(Cursor.Position);
            }
        }

        private void runSrvMItem_Click(object sender, EventArgs e)
        {
            Srv service = (Srv)ServiceView.FocusedItem.Tag;
            sc.ServiceName = service.serviceName;
            addonStripLabel.Text = $"Запускаю службу \"{service.serviceName}\"...";

            try
            {
                sc.Start();
                Task.Run(() =>
                {
                    try
                    {
                        sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                    }
                }).ContinueWith(funcEnd =>
                {
                    GetServices();
                    addonStripLabel.Text = "";
                }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (InvalidOperationException ex)
            {
                addonStripLabel.Text = "";
                logger.Error(ex.Message);
                MessageBox.Show($"Не удалось запустить службу \"{service.serviceName}\" по следующей причине: \"{ex.Message}\"", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopSrvMItem_Click(object sender, EventArgs e)
        {
            Srv service = (Srv)ServiceView.FocusedItem.Tag;
            sc.ServiceName = service.serviceName;
            addonStripLabel.Text = $"Останавливаю службу \"{service.serviceName}\"...";

            try
            {
                sc.Stop();
                Task.Run(() =>
                {
                    try
                    {
                        sc.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(30));
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                    }
                }).ContinueWith(funcEnd =>
                {
                    GetServices();
                    addonStripLabel.Text = "";
                }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (InvalidOperationException ex)
            {
                addonStripLabel.Text = "";
                logger.Error(ex.Message);
                MessageBox.Show($"Не удалось остановить службу \"{service.serviceName}\" по следующей причине: \"{ex.Message}\"", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSrvMItem_Click(object sender, EventArgs e)
        {
            Srv service = (Srv)ServiceView.FocusedItem.Tag;
            sc.ServiceName = service.serviceName;
            addonStripLabel.Text = $"Останавливаю службу \"{service.serviceName}\"...";

            try
            {
                sc.Stop();
                Task.Run(() =>
                {
                    try
                    {
                        sc.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(30));
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex.Message);
                    }
                }).ContinueWith(funcEnd =>
                {
                    GetServices();
                    addonStripLabel.Text = "";
                }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (InvalidOperationException ex)
            {
                addonStripLabel.Text = "";
                logger.Error(ex.Message);
                MessageBox.Show($"Не удалось остановить службу \"{service.serviceName}\" по следующей причине: \"{ex.Message}\"", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            addonStripLabel.Text = $"Удаление службы \"{service.serviceName}\"...";
            try
            {
                service.Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось удалить службу \"{service.serviceName}\". Причина: \"{ex.Message}\"", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GetServices();
                addonStripLabel.Text = "";
            }
        }

        private void runStripItem_Click(object sender, EventArgs e)
        {
            using (Run run = new Run())
            {
                run.StartPosition = FormStartPosition.Manual;
                run.Location = Location;
                run.ShowDialog();
            }
        }

        private void BackToMainMenuStrip_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void ExitStrip_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void TMView_KeyDown(object sender, KeyEventArgs e)
        {
            if (TMView.SelectedItems.Count > 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        taskMgrCore.TerminateProcesses(TMView, uncriticalPrcStripItem.Checked);
                        break;

                    case Keys.Pause:
                        foreach (ListViewItem lvI in TMView.SelectedItems)
                        {
                            var prcInfo = (Prc)lvI.Tag;

                            if (prcInfo.ProcessState.ToLower() == "suspended") taskMgrCore.ResumeProcess(prcInfo.ProcessID);
                            else taskMgrCore.SuspendProcess(prcInfo.ProcessID);

                            TMView.Items[lvI.Index] = ToListViewItem(await taskMgrCore.UpdateProcessInfo(prcInfo.ProcessID));
                        }
                        break;
                }

                if (e.Modifiers == Keys.Control)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.C:
                            foreach (ListViewItem lvI in TMView.SelectedItems)
                            {
                                var prcInfo = (Prc)lvI.Tag;

                                using (Process p = Process.GetProcessById(prcInfo.ProcessID))
                                {
                                    taskMgrCore.CriticalProcess(p, prcInfo.ProcessCritical == true ? 0 : 1);

                                    TMView.Items[lvI.Index] = ToListViewItem(await taskMgrCore.ToPrcClass(p));
                                }
                            }
                            break;

                        case Keys.A:
                            foreach (ListViewItem lvI in TMView.SelectedItems)
                            {
                                var prcInfo = (Prc)lvI.Tag;
                                Utils.RunFile(@"bin\AntiGDI_Injector.exe", $"{prcInfo.ProcessID}", true, false, false);
                            }
                            break;
                    }
                }
            }
        }

        private void antiGDIStripItem_Click(object sender, EventArgs e)
        {
            new AntiGDI().ShowDialog();
        }

        private void antiGDIMItem_Click(object sender, EventArgs e)
        {
            Prc prcInfo = (Prc)TMView.FocusedItem.Tag;
            Utils.RunFile(@"bin\AntiGDI_Injector.exe", $"{prcInfo.ProcessID}", true, false, false);
        }
    }
}
