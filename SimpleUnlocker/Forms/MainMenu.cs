using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using log4net;
using SU.Classes;

namespace SU.Forms
{
    public partial class MainMenu : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public MainMenu()
        {
            InitializeComponent();
        }
        private void BtnState(bool enabled)
        {
            foreach (Button button in this.MenuPanel.Controls.OfType<Button>())
            {
                button.Enabled = enabled;
            }
        }
        private void RunForm(Form form, string formName, string fullName, bool hideMainForm = true)
        {
            if (Properties.Settings.Default.RandomWindowName)
            {
                string RandomName = Utils.RandomString(10, true);
                form.Text = RandomName;
            }
            else form.Text = fullName;
            form.TopMost = Properties.Settings.Default.AlwaysOnTop;
            if (Properties.Settings.Default.CloseMainMenuOnAction)
            {
                if (hideMainForm) Hide();
                form.ShowDialog();
            }
            else if (Application.OpenForms[formName] == null) form.Show();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            logger.Debug("Инициализация главной формы.");
            Process.EnterDebugMode();
            if (Properties.Settings.Default.RandomWindowName)
            {
                string RandomName = Utils.RandomString(Utils.GetRandomNumber(8, 18), true);
                this.Text = RandomName;
            }
            else this.Text = "SimpleUnlocker [Main]";
            this.TopMost = Properties.Settings.Default.AlwaysOnTop;
            StatusVersionLabel.Text = $"Версия: {Application.ProductVersion}";
            checkUpdateWorker.WorkerReportsProgress = true;

            if (Properties.Settings.Default.AutoCheckUpdate && Program.AutoUpdateClickNo == false) checkUpdateWorker.RunWorkerAsync();
        }

        private void URButton_Click(object sender, EventArgs e)
        {
            RunForm(new UnblockRestriction(), "UnblockRestriction", "SimpleUnlocker [Разблокировка ограничений]");
        }

        private void ARButton_Click(object sender, EventArgs e)
        {
            RunForm(new AutorunView(), "AutorunView", "SimpleUnlocker [Автозапуск приложений]");
        }

        private void TMButton_Click(object sender, EventArgs e)
        {
            BtnState(false);
            RunForm(new TaskManager(), "TaskManager", "SimpleUnlocker [Диспетчер задач]");
            BtnState(true);
        }

        private void SButton_Click(object sender, EventArgs e)
        {
            RunForm(new Settings(), "Settings", "Настройки" , false);
        }

        private void MBButton_Click(object sender, EventArgs e)
        {
            RunForm(new MBRBackup(), "MBRBackup", "SimpleUnlocker [Восстановление MBR]");
        }

        private void RUButton_Click(object sender, EventArgs e)
        {
            RunForm(new OtherSoftware(), "OtherSoftware", "SimpleUnlocker [Сторонние утилиты]");
        }

        private void checkUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Utils.CheckUpdate(this, Client_DownloadFileCompleted, false);
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (!Directory.Exists("temp")) Directory.CreateDirectory("temp");
            File.Move(@"temp\updater.temp", @"temp\updater.zip");
            updaterUnpacker.RunWorkerAsync();
        }

        private void unpackerWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            logger.Info($"Распаковка апдейтера");
            try
            {
                using (ZipFile zip = ZipFile.Read(@"temp\updater.zip"))
                {
                    zip.ExtractAll($@"{Environment.CurrentDirectory}\bin", ExtractExistingFileAction.OverwriteSilently);
                }
            }
            catch (Exception ex) 
            {
                logger.Error(ex.Message);
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void updaterUnpacker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            logger.Info($"Запуск процесса обновления");
            Version SUVersion = new Version(Application.ProductVersion);

            File.Delete(@"temp\updater.zip");

            Utils.RunFile(@"bin\su_updater.exe", $"{SUVersion} {Path.GetFileName(Application.ExecutablePath)}", true, false, false);
            Environment.Exit(0);
        }

        private void APButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            if (Application.OpenForms["About"] == null) about.Show();
        }
    }
}
