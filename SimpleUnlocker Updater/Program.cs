using System;
using System.IO;
using System.Windows.Forms;

namespace SimpleUnlocker_Updater
{
    internal static class Program
    {
        public static string NameFileUpdate;
        public static string VersionSU;
        public static string MainFileName;

        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0 || args.Length < 2) Environment.Exit(1);

            if (args.Length > 2)
            {
                NameFileUpdate = args[0];
                VersionSU = args[1];
                MainFileName = args[2];
            } 
            else
            {
                VersionSU = args[0];
                MainFileName = args[1];
            }

            if (File.Exists(@"temp\update.zip")) File.Delete(@"temp\update.zip");
            if (File.Exists(@"temp\update.temp")) File.Delete(@"temp\update.temp");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Updater());
        }
    }
}
