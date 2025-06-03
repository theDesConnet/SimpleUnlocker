using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU.Classes;

namespace SU.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            verLabel.Text = $"Версия: {Application.ProductVersion}";
            TopMost = Properties.Settings.Default.AlwaysOnTop;
        }

        private void authorBtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://ds1nc.ru");
        }

        private void DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (!Directory.Exists("temp")) Directory.CreateDirectory("temp");
            File.Move(@"temp\updater.temp", @"temp\updater.zip");
            Console.WriteLine($"[INFO] Распаковка апдейтера");
            try
            {
                using (ZipFile zip = ZipFile.Read(@"temp\updater.zip"))
                {
                    zip.ExtractAll($@"{Environment.CurrentDirectory}\bin", ExtractExistingFileAction.OverwriteSilently);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            Console.WriteLine($"[INFO] Запуск процесса обновления");
            Version SUVersion = new Version(Application.ProductVersion);

            File.Delete(@"temp\updater.zip");

            Utils.RunFile(@"bin\su_updater.exe", $"{SUVersion} {Path.GetFileName(Application.ExecutablePath)}", true, false, false);
            Environment.Exit(1);
        }

        private void chkUpdateBtn_Click(object sender, EventArgs e)
        {
            Utils.CheckUpdate(this, DownloadFileCompleted, true);
        }
    }
}
