using log4net;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SU.Classes
{

    /// <summary>
    /// Класс с мини вспомогательными штучками
    /// </summary>
    internal class Utils
    {
        private static ILog logger = LogManager.GetLogger(typeof(Utils));
        public static readonly RegistryView RegView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

        #region Константы
        public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        public const UInt32 SWP_NOSIZE = 0x0001;
        public const UInt32 SWP_NOMOVE = 0x0002;
        public const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        public const int EM_SETCUEBANNER = 0x1501;
        private const uint DefaultMbrSize = 512 * 2048;
        public const int SW_SHOW = 5;
        public const uint SEE_MASK_INVOKEIDLIST = 12;
        public const int TOKEN_DUPLICATE = 0x0002;
        public const uint MAXIMUM_ALLOWED = 0x2000000;
        public const int CREATE_NEW_CONSOLE = 0x00000010;

        public const int IDLE_PRIORITY_CLASS = 0x40;
        public const int NORMAL_PRIORITY_CLASS = 0x20;
        public const int HIGH_PRIORITY_CLASS = 0x80;
        public const int REALTIME_PRIORITY_CLASS = 0x100;

        public const uint SC_MANAGER_ALL_ACCESS = 0xF003F;
        public const uint SERVICE_STOP = 0x0020;
        public const uint SERVICE_QUERY_STATUS = 0x0004;
        public const uint DELETE = 0x10000;
        #endregion

        #region Структуры
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHELLEXECUTEINFO
        {
            public int cbSize;
            public uint fMask;
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpVerb;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpFile;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpParameters;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpDirectory;
            public int nShow;
            public IntPtr hInstApp;
            public IntPtr lpIDList;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpClass;
            public IntPtr hkeyClass;
            public uint dwHotKey;
            public IntPtr hIcon;
            public IntPtr hProcess;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SECURITY_ATTRIBUTES
        {
            public int Length;
            public IntPtr lpSecurityDescriptor;
            public bool bInheritHandle;
            internal int nLength;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STARTUPINFO
        {
            public int cb;
            public String lpReserved;
            public String lpDesktop;
            public String lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct STARTUPINFOEX
        {
            public STARTUPINFO StartupInfo;
            public IntPtr lpAttributeList;
        }
        #endregion

        #region Enum
        enum TOKEN_TYPE : int
        {
            TokenPrimary = 1,
            TokenImpersonation = 2
        }

        enum SECURITY_IMPERSONATION_LEVEL : int
        {
            SecurityAnonymous = 0,
            SecurityIdentification = 1,
            SecurityImpersonation = 2,
            SecurityDelegation = 3,
        }

        [Flags]
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VirtualMemoryOperation = 0x00000008,
            VirtualMemoryRead = 0x00000010,
            VirtualMemoryWrite = 0x00000020,
            DuplicateHandle = 0x00000040,
            CreateProcess = 0x000000080,
            SetQuota = 0x00000100,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            QueryLimitedInformation = 0x00001000,
            Synchronize = 0x00100000
        }

        [Flags]
        enum HANDLE_FLAGS : uint
        {
            None = 0,
            INHERIT = 1,
            PROTECT_FROM_CLOSE = 2
        }

        [Flags]
        public enum PROCESS_CREATION_FLAGS : uint
        {
            DEBUG_PROCESS = 0x00000001,
            DEBUG_ONLY_THIS_PROCESS = 0x00000002,
            CREATE_SUSPENDED = 0x00000004,
            DETACHED_PROCESS = 0x00000008,
            CREATE_NEW_CONSOLE = 0x00000010,
            NORMAL_PRIORITY_CLASS = 0x00000020,
            IDLE_PRIORITY_CLASS = 0x00000040,
            HIGH_PRIORITY_CLASS = 0x00000080,
            REALTIME_PRIORITY_CLASS = 0x00000100,
            CREATE_NEW_PROCESS_GROUP = 0x00000200,
            CREATE_UNICODE_ENVIRONMENT = 0x00000400,
            CREATE_SEPARATE_WOW_VDM = 0x00000800,
            CREATE_SHARED_WOW_VDM = 0x00001000,
            CREATE_FORCEDOS = 0x00002000,
            BELOW_NORMAL_PRIORITY_CLASS = 0x00004000,
            ABOVE_NORMAL_PRIORITY_CLASS = 0x00008000,
            INHERIT_PARENT_AFFINITY = 0x00010000,
            INHERIT_CALLER_PRIORITY = 0x00020000,
            CREATE_PROTECTED_PROCESS = 0x00040000,
            EXTENDED_STARTUPINFO_PRESENT = 0x00080000,
            PROCESS_MODE_BACKGROUND_BEGIN = 0x00100000,
            PROCESS_MODE_BACKGROUND_END = 0x00200000,
            CREATE_SECURE_PROCESS = 0x00400000,
            CREATE_BREAKAWAY_FROM_JOB = 0x01000000,
            CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x02000000,
            CREATE_DEFAULT_ERROR_MODE = 0x04000000,
            CREATE_NO_WINDOW = 0x08000000,
            PROFILE_USER = 0x10000000,
            PROFILE_KERNEL = 0x20000000,
            PROFILE_SERVER = 0x40000000,
            CREATE_IGNORE_SYSTEM_DEFAULT = 0x80000000,
        }
        #endregion

        #region Импорты
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

        [DllImport("ntdll.dll", PreserveSig = false)]
        public static extern void NtSuspendProcess(IntPtr processHandle);

        [DllImport("ntdll.dll", PreserveSig = false, SetLastError = true)]
        public static extern void NtResumeProcess(IntPtr processHandle);

        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern int NtQueryInformationProcess(IntPtr hProcess, uint pic, ref uint pi, int cb, out int pSize);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

        [DllImport("kernel32")]
        public static extern IntPtr CreateFile(
          string lpFileName,
          uint dwDesiredAccess,
          uint dwShareMode,
          IntPtr lpSecurityAttributes,
          uint dwCreationDisposition,
          uint dwFlagsAndAttributes,
          IntPtr hTemplateFile);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadFile(IntPtr hFile, [Out] byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped);

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(uint Index);

        [DllImport("kernel32")]
        public static extern bool WriteFile(
          IntPtr hfile,
          byte[] lpBuffer,
          uint nNumberOfBytesToWrite,
          out uint lpNumberBytesWritten,
          IntPtr lpOverlapped);

        [DllImport("kernel32.dll", SetLastError = true)]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern IntPtr OpenSCManager(string machineName, string databaseName, uint dwAccess);

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern IntPtr OpenService(IntPtr hSCManager, string lpServiceName, uint dwDesiredAccess);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteService(IntPtr hService);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseServiceHandle(IntPtr hSCObject);

        [DllImport("kernel32.dll")]
        static extern uint WTSGetActiveConsoleSessionId();

        [DllImport("advapi32.dll", EntryPoint = "CreateProcessAsUser", SetLastError = true, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public extern static bool CreateProcessAsUser(IntPtr hToken, String lpApplicationName, String lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes,
            ref SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandle, int dwCreationFlags, IntPtr lpEnvironment,
            String lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

        [DllImport("kernel32.dll")]
        static extern bool ProcessIdToSessionId(uint dwProcessId, ref uint pSessionId);

        [DllImport("advapi32.dll", EntryPoint = "DuplicateTokenEx")]
        public extern static bool DuplicateTokenEx(IntPtr ExistingTokenHandle, uint dwDesiredAccess,
            ref SECURITY_ATTRIBUTES lpThreadAttributes, int TokenType,
            int ImpersonationLevel, ref IntPtr DuplicateTokenHandle);

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

        [DllImport("advapi32", SetLastError = true), SuppressUnmanagedCodeSecurityAttribute]
        static extern bool OpenProcessToken(IntPtr ProcessHandle, int DesiredAccess, ref IntPtr TokenHandle);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFOEX lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern UInt32 WaitForSingleObject(IntPtr handle, UInt32 milliseconds);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UpdateProcThreadAttribute(IntPtr lpAttributeList, uint dwFlags, IntPtr Attribute, IntPtr lpValue, IntPtr cbSize, IntPtr lpPreviousValue, IntPtr lpReturnSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool InitializeProcThreadAttributeList(IntPtr lpAttributeList, int dwAttributeCount, int dwFlags, ref IntPtr lpSize);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool SetHandleInformation(IntPtr hObject, HANDLE_FLAGS dwMask, HANDLE_FLAGS dwFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DuplicateHandle(IntPtr hSourceProcessHandle, IntPtr hSourceHandle, IntPtr hTargetProcessHandle, ref IntPtr lpTargetHandle, uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, uint dwOptions);
        #endregion

        /// <summary>
        /// Рандомно сгенерированная строка
        /// </summary>
        /// <param name="size">Размер строки</param>
        /// <param name="lowerCase">Будет ли полученная строка только в нижнем регистре</param>
        /// <returns>Сгенерированную строчку</returns>
        public static string RandomString(int size, bool lowerCase = false)
        {
            Random _random = new Random();

            var builder = new StringBuilder(size);

            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26;

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        /// <summary>
        /// Запуск файла
        /// </summary>
        ///<param name="FilePath">Путь до файла</param>
        ///<param name="Arguments">Аргументы запуска</param>
        ///<param name="UAC">Будет ли файл запущен от имени администратора</param>
        ///<param name="Hidden">Будет ли файл запущен скрытно</param>
        ///<param name="WaitForExit">Будет ли программа ожидать закрытие файла</param>
        public static void RunFile(string FilePath, string Arguments, bool UAC, bool Hidden, bool WaitForExit)
        {
            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                WindowStyle = !Hidden ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden,
                FileName = FilePath,
                Arguments = Arguments
            };

            if (UAC) processStartInfo.Verb = "runas";

            logger.Debug($"Запуск файла: \"{FilePath}\" с аргументами \"{Arguments} | Run as Admin: {UAC}, Hidden: {Hidden}, Wait for Exit: {WaitForExit}.");
            process.StartInfo = processStartInfo;
            process.Start();

            if (WaitForExit) process.WaitForExit();
        }

        /// <summary>
        /// Чтение MBR на физическом диске
        /// </summary>
        /// <param name="PhysicalDrive">Физический диск с которого будет прочитан MBR</param>
        /// <returns>MBR в виде массива байтов</returns>
        public static byte[] ReadMBR(string PhysicalDrive)
        {
            byte[] MBRData = new byte[DefaultMbrSize];
            IntPtr Handle = CreateFile(PhysicalDrive, 268435456U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);

            if (!ReadFile(Handle, MBRData, DefaultMbrSize, out _, IntPtr.Zero))
            {
                CloseHandle(Handle);
                throw (new Exception($"Не удалось прочитать MBR [{PhysicalDrive}]"));
            }
            else
            {
                CloseHandle(Handle);
                logger.Debug($"Чтение MBR на {PhysicalDrive} (Length: {MBRData.Length})");
                return MBRData;
            }
        }

        /// <summary>
        /// Запись MBR на физическом диске
        /// </summary>
        /// <param name="MBRHex">Главная загруочная запись в HEX</param>
        /// <param name="PhysicalDrive">Физический диск куда будет записан MBR</param>
        /// <returns>Булевое значение которое означает было ли MBR записанно или нет</returns>
        public static bool WriteMBR(byte[] MBRHex, string PhysicalDrive)
        {
            IntPtr Handle = CreateFile(PhysicalDrive, 268435456U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
            if (!WriteFile(Handle, MBRHex, DefaultMbrSize, out uint _, IntPtr.Zero))
            {
                CloseHandle(Handle);
                return false;
            }
            CloseHandle(Handle);
            logger.Debug($"Запись MBR на {PhysicalDrive} (Length: {MBRHex.Length})");
            return true;
        }

        /// <summary>
        /// Получение пути из команды
        /// </summary>
        /// <param name="command">Команда</param>
        /// <returns>Путь</returns>
        public static string GetExecutablePathFromCommand(string command)
        {
            string pattern = @"""?([A-Za-z]:+(\\[\w\s.()]+)+\.\w+)""?";

            Match match = Regex.Match(command, pattern);

            if (match.Success) return match.Groups[1].Value;

            return null;
        }

        /// <summary>
        /// Показать свойства файла
        /// </summary>
        /// <param name="FilePath">Путь до файла</param>
        /// <returns></returns>
        public static bool ShowFileProperties(string FilePath)
        {
            SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
            info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
            info.lpVerb = "properties";
            info.lpFile = FilePath;
            info.nShow = SW_SHOW;
            info.fMask = SEE_MASK_INVOKEIDLIST;
            return ShellExecuteEx(ref info);
        }

        /// <summary>
        /// Обработчик закрытия формы
        /// </summary>
        /// <param name="e">Ивент</param>
        public static void CloseForm(FormClosingEventArgs e)
        {
            switch (e.CloseReason.ToString())
            {
                case "UserClosing":
                    if (Properties.Settings.Default.CloseAppOnClick)
                    {
                        Environment.Exit(1);
                    }
                    else
                    {
                        if (Properties.Settings.Default.CloseMainMenuOnAction) Application.OpenForms["MainMenu"].Show();
                    }
                    break;

                case "None":
                    if (Properties.Settings.Default.CloseMainMenuOnAction) Application.OpenForms["MainMenu"].Show();
                    break;
            }
        }

        /// <summary>
        /// Рандомное число
        /// </summary>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <returns>Число</returns>
        public static int GetRandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        /// <summary>
        /// Проверка обновления SU
        /// </summary>
        /// <param name="form">Форма откуда было вызвана данная функция</param>
        /// <param name="dFC">Ивент</param>
        /// <param name="InformateUser">Информировать ли пользователя</param>
        public static void CheckUpdate(Form form, AsyncCompletedEventHandler dFC, bool InformateUser)
        {
            logger.Info("Запуск проверки обновлений.");
            string VersionLink = "http://simpleunlocker.ds1nc.ru/release/version.xml";
            try
            {
                XmlDocument UnlockerVersion = new XmlDocument();
                UnlockerVersion.Load(VersionLink);

                Version SUVersion = new Version(Application.ProductVersion);
                Version Remote_SUVersion = new Version(UnlockerVersion.GetElementsByTagName("simpleunlocker")[0].InnerText);

                if (SUVersion < Remote_SUVersion)
                {
                    logger.Info($"Была найдена новая версия SimpleUnlocker [{Remote_SUVersion}], показываю MessageBox пользователю.");
                    var result = MessageBox.Show(form, $"Доступна новая версия SimpleUnlocker [{Remote_SUVersion}]\nВы хотите обновить SimpleUnlocker сейчас?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Version UpdaterVerison = new Version(UnlockerVersion.GetElementsByTagName("simpleunlocker_updater")[0].InnerText);
                        Version suupdaterVersion = new Version(FileVersionInfo.GetVersionInfo(@"bin\su_updater.exe").FileVersion);

                        if (suupdaterVersion < UpdaterVerison)
                        {
                            string UpdateLink = "https://ds1nc.ru/updates/simpleunlocker/updater/su_updater.zip";

                            logger.Info("Запуск скачивание нового апдейтера.");

                            ServicePointManager.Expect100Continue = true;
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                            var client = new WebClient();
                            client.DownloadFileCompleted += dFC;
                            client.DownloadFileAsync(new Uri(UpdateLink), @"temp\updater.temp");
                        }
                        else
                        {
                            RunFile(@"bin\su_updater.exe", $"{SUVersion} {Path.GetFileName(Application.ExecutablePath)}", true, false, false);
                            Environment.Exit(1);
                        }
                    }
                    else
                    {
                        Program.AutoUpdateClickNo = true;
                    }
                }
                else
                {
                    logger.Info($"Провека была успешно завершена! У пользователя последняя версия SimpleUnlocker.");
                    if (InformateUser) MessageBox.Show(form, "Вы используете последнюю версию SimpleUnlocker", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }

        public static void RegistryUnlock(string path, RegistryHive[] hives, bool fullLock)
        {
            string[] usids = { "S-1-1-0", "S-1-5-32-545", "S-1-5-32-544", "S-1-5-11" };
            RegistryKey key = null;
            try
            {
                foreach (RegistryHive hive in hives)
                {
                    using (RegistryKey bKey = RegistryKey.OpenBaseKey(hive, RegistryView.Default))
                    {
                        key = bKey.OpenSubKey(path, RegistryKeyPermissionCheck.ReadWriteSubTree, System.Security.AccessControl.RegistryRights.ChangePermissions);

                        if (key == null)
                        {
                            throw new Exception("Не удалось открыть указанный раздел реестра.");
                        }
                        RegistrySecurity regSecurity = key.GetAccessControl();

                        foreach (string sid in usids)
                        {
                            SecurityIdentifier securityIdentifier = new SecurityIdentifier(sid);
                            if (fullLock)
                            {
                                RegistryAccessRule fullRule = new RegistryAccessRule(securityIdentifier, RegistryRights.FullControl, AccessControlType.Deny);
                                regSecurity.RemoveAccessRule(fullRule);
                            }
                            else
                            {
                                RegistryAccessRule[] rules = {
                                    new RegistryAccessRule(securityIdentifier, RegistryRights.Delete, AccessControlType.Deny),
                                    new RegistryAccessRule(securityIdentifier, RegistryRights.SetValue, AccessControlType.Deny),
                                    new RegistryAccessRule(securityIdentifier, RegistryRights.CreateSubKey, AccessControlType.Deny),
                                    new RegistryAccessRule(securityIdentifier, RegistryRights.TakeOwnership, AccessControlType.Deny),
                                    new RegistryAccessRule(securityIdentifier, RegistryRights.WriteKey, AccessControlType.Deny),
                                    new RegistryAccessRule(securityIdentifier, RegistryRights.ChangePermissions, AccessControlType.Deny)
                                };

                                foreach (var rule in rules)
                                {
                                    regSecurity.RemoveAccessRule(rule);
                                }
                            }
                        }
                        key.SetAccessControl(regSecurity);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при разблокировке реестра: " + ex.Message);
            }
            finally
            {
                key?.Close();
            }
        }
    }
}
