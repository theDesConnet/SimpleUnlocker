using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SU.Classes.Autorun
{
    /// <summary>
    /// Перечисление типов автозапуска
    /// </summary>
    internal enum AutorunType
    {
        Registry,
        Winlogon,
        ShellFolder,
        TaskScheduler
    }
    /// <summary>
    /// Перечисление путей автозапуска в реестре
    /// </summary>
    internal enum RegistryPaths
    {
        Run,
        RunOnce,
        Winlogon
    }
    /// <summary>
    /// Класс элемента автозагрузки
    /// </summary>
    internal class AutorunElem
    {
        /// <summary>
        /// Имя автозагрузки
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Тип автозагрузки
        /// </summary>
        public AutorunType Type { get; set; } 
        /// <summary>
        /// Ветка реестра где находится автозагрузка (Только для тип автозагрузки через реестр)
        /// </summary>
        public RegistryHive Hive { get; set; }
        /// <summary>
        /// Путь автозапуска (только для реестра)
        /// </summary>
        public string RegPath { get; set; }
        /// <summary>
        /// Путь автозагрузки
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Удаление элемента из автозагрузки
        /// </summary>
        public void Remove()
        {
            switch (Type)
            {
                case AutorunType.Registry:
                    using (RegistryKey path = RegistryKey.OpenBaseKey(Hive, Utils.RegView).OpenSubKey(RegPath, true))
                    {
                        path.DeleteValue(Name);
                    }
                    break;

                case AutorunType.Winlogon:
                    using (RegistryKey LocalMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                    {
                        using (RegistryKey Winlogon = LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true))
                        {
                            string GetValue = Winlogon.GetValue(Name).ToString();
                            string[] values = GetValue.Trim(' ').Split(',');
                            string doneValue = "";

                            foreach (string Value in values)
                            {
                                if (Path.ToLower().Contains(Value.ToLower()) == false)
                                {
                                    if (doneValue == "")
                                    {
                                        doneValue += Value;
                                    }
                                    else
                                    {
                                        doneValue += $", {Value}";
                                    }
                                }
                            }
                            Winlogon.SetValue(Name, doneValue);
                            Winlogon.Close();
                        }
                        LocalMachine.Close();
                    }
                    break;

                case AutorunType.ShellFolder:
                    try
                    {
                        File.Delete($@"{Path}\{Name}");
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case AutorunType.TaskScheduler:
                    break;
            }
        }
    }

    /// <summary>
    /// Класс для взаимодействия с автозапуском
    /// </summary>
    internal class Autorun
    {
        /// <summary>
        /// Получение элементов автозагрузки из реестра
        /// </summary>
        /// <param name="path">Путь реестра</param>
        /// <returns>Массив <see cref="AutorunElem"/></returns>
        public static AutorunElem[] GetRegistryAutoRun(RegistryPaths path, RegistryView view = RegistryView.Default)
        {
            List<AutorunElem> Elements = new List<AutorunElem>();
            RegistryHive[] Hives = new RegistryHive[] { RegistryHive.CurrentUser, RegistryHive.LocalMachine };
            string[] ValueNames;

            foreach (RegistryHive hive in Hives)
            {
                using (RegistryKey h = RegistryKey.OpenBaseKey(hive, view))
                {
                    switch (path)
                    {
                        case RegistryPaths.Run:
                        case RegistryPaths.RunOnce:
                            string pathStr = path == RegistryPaths.Run ? @"Software\Microsoft\Windows\CurrentVersion\Run" : @"Software\Microsoft\Windows\CurrentVersion\RunOnce";
                            try
                            {
                                using (RegistryKey runKey = h.OpenSubKey(pathStr, true))
                                {
                                    ValueNames = runKey.GetValueNames();

                                    foreach (string value in ValueNames)
                                    {
                                        Elements.Add(new AutorunElem()
                                        {
                                            Name = value,
                                            Type = AutorunType.Registry,
                                            Hive = hive,
                                            Path = runKey.GetValue(value).ToString(),
                                            RegPath = pathStr
                                        });
                                    }
                                }
                            } catch { }
                            break;

                        case RegistryPaths.Winlogon:
                            using (RegistryKey runKey = h.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", true))
                            {
                                string[] Values = { "Shell", "Userinit" };
                                foreach (string value in Values)
                                {
                                    if (runKey.GetValue(value) != null)
                                    {
                                        string KeyValue = runKey.GetValue(value).ToString();
                                        string[] Paths = KeyValue.Trim(' ').Split(',');

                                        foreach (string winPath in Paths)
                                        {
                                            if (winPath != "") Elements.Add(new AutorunElem() { Name = value, Path = winPath, Hive = hive, RegPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon", Type = AutorunType.Winlogon });
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
            }

            return Elements.ToArray();
        }

        /// <summary>
        /// Получение элементов автозагрузки из папки Startup
        /// </summary>
        /// <returns>Массив <see cref="AutorunElem"/></returns>
        public static AutorunElem[] GetShellAutorun()
        {
            List<AutorunElem> ShellRuns = new List<AutorunElem>();

            string[] Paths = new string[]
            {
                Environment.GetFolderPath(Environment.SpecialFolder.Startup),
                Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup)
            };

            foreach (string path in Paths)
            {
                foreach (string p in Directory.GetFiles(path).Where(k => !k.EndsWith(".ini")).ToArray())
                {
                    ShellRuns.Add(new AutorunElem() { Name = Path.GetFileName(p), Path = path, Type = AutorunType.ShellFolder });
                }
            }

            return ShellRuns.ToArray();
        }
    }
}
