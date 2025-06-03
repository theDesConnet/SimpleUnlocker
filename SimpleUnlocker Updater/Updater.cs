using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using Ionic.Zip;

namespace SimpleUnlocker_Updater
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();
        }

        public static void RunFile(string FilePath, string Arguments, bool UAC, bool Hidden, bool WaitForExit)
        {
            Process process = new Process();
            ProcessStartInfo processStartInfo = new ProcessStartInfo();

            processStartInfo.WindowStyle = !Hidden ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden;
            processStartInfo.FileName = FilePath;
            processStartInfo.Arguments = Arguments;

            if (UAC) processStartInfo.Verb = "runas";

            process.StartInfo = processStartInfo;
            process.Start();

            if (WaitForExit) process.WaitForExit();
        }

        private void backgroundUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            string VersionLink = "http://simpleunlocker.ds1nc.ru/release/version.xml";
            string UpdateLink = "https://ds1nc.ru/updates/simpleunlocker/client/su_client.zip";
            try
            {
                XmlDocument UnlockerVersion = new XmlDocument();
                UnlockerVersion.Load(VersionLink);
                Version SUVersion = new Version(Program.VersionSU);
                Version Remote_SUVersion = new Version(UnlockerVersion.GetElementsByTagName("simpleunlocker")[0].InnerText);

                if (SUVersion < Remote_SUVersion)
                {
                    label1.Text = "Скачивание обновления...";

                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                    var client = new WebClient();
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(download_ProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(download_Completed);
                    
                    client.DownloadFileAsync(new Uri(UpdateLink), @"temp\update.temp");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void download_Completed(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = "Распаковка обновления...";

            File.Move(@"temp\update.temp", @"temp\update.zip");
            backgroundUnpacker.RunWorkerAsync();
        }

        private void download_ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            backgroundUpdate.RunWorkerAsync();
        }

        private void backgroundUnpacker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(@"temp\update.zip"))
                {
                    zip.ExtractProgress += ExtarctProgress;
                    zip.ExtractAll($@"{Environment.CurrentDirectory}", ExtractExistingFileAction.OverwriteSilently);
                }
            } catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void ExtarctProgress(object sender, ExtractProgressEventArgs e)
        {
            if (e.TotalBytesToTransfer > 0)
            {
                progressBar1.Value = Convert.ToInt32(100 * e.BytesTransferred / e.TotalBytesToTransfer);
            }
        }

        private void backgroundUnpacker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "Осталось совсем немного...";
            File.Delete(@"temp\update.zip");

            if (Program.MainFileName.ToLower() != "su.exe")
            {
                File.Move(Program.MainFileName, "SU.bak");
                File.Move("SU.exe", Program.MainFileName);
                File.Delete("SU.bak");

                RunFile(Program.MainFileName, "", true, false, false);
            } else RunFile("SU.exe", "", true, false, false);

            Environment.Exit(1);
        }
    }
}
