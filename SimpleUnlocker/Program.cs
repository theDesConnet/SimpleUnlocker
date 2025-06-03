using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using SU.Classes;
using log4net;
using System.IO;

namespace SU
{
    static class Program
    {
        public static bool AutoUpdateClickNo = false;
        public static bool isSaveMode = false;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));
            Logger.Init();
            AppDomain.CurrentDomain.UnhandledException += (a, b) =>
            {
                LogManager.GetLogger("Unhandled Exception").Fatal(((Exception)b.ExceptionObject).Message);
            };

            isSaveMode = (Utils.GetSystemMetrics(67U) != 0);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainMenu());
        }
    }
}
