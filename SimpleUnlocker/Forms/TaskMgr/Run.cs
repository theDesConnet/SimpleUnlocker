using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU.Classes;

namespace SU.Forms.TaskMgr
{
    public partial class Run : Form
    {
        public Run()
        {
            InitializeComponent();
        }
        private void StartFile()
        {
            Hide();
            try
            {
                Process.Start(ExecBox.Text);
            }
            catch
            {
                MessageBox.Show($"Не удалось найти \"{ExecBox.Text}\". Проверьте правильность введенного имени и попробуйте еще раз.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Show();
                return;
            }
            Close();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (ofdRun.ShowDialog() == DialogResult.OK)
            {
                ExecBox.Text = ofdRun.FileName;
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            StartFile();
        }

        private void ExecBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return)) StartFile();
        }

        private void ExecBox_TextChanged(object sender, EventArgs e)
        {
            doneBtn.Enabled = !String.IsNullOrWhiteSpace(ExecBox.Text);
        }
    }
}

