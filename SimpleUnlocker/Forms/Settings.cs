using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            RandomWindowName.Checked = Properties.Settings.Default.RandomWindowName;
            AlwaysOnTop.Checked = Properties.Settings.Default.AlwaysOnTop;
            AutoUpdate.Checked = Properties.Settings.Default.AutoCheckUpdate;
            MainMenuClose.Checked = Properties.Settings.Default.CloseMainMenuOnAction;
            CloseApp.Checked = Properties.Settings.Default.CloseAppOnClick;
            if (MainMenuClose.Checked == false)
            {
                CloseApp.Checked = false;
                CloseApp.Enabled = false;
            }
        }

        private void RandomWindowName_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.RandomWindowName = RandomWindowName.Checked;
        }

        private void AlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AlwaysOnTop = AlwaysOnTop.Checked;
        }

        private void AutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoCheckUpdate = AutoUpdate.Checked;
        }

        private void MainMenuClose_CheckedChanged(object sender, EventArgs e)
        {
            if (MainMenuClose.Checked == false)
            {
                CloseApp.Checked = false;
                CloseApp.Enabled = false;
            }
            else CloseApp.Enabled = true;
            Properties.Settings.Default.CloseMainMenuOnAction = MainMenuClose.Checked;
        }

        private void CloseApp_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CloseAppOnClick = CloseApp.Checked;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            if (MessageBox.Show("Требуется перезапуск программы. Вы хотите перезапустить программу сейчас", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) Application.Restart();
            else Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
