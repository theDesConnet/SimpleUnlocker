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
    public partial class AntiGDI : Form
    {
        List<int> ProcessID = new List<int>();

        private void GetProcesses()
        {
            ProcessID = new List<int>();
            prcBox.Items.Clear();
            Process[] p = Process.GetProcesses();
            foreach (Process prc in p)
            {
                if (prc.Threads[0].ThreadState == ThreadState.Wait && prc.Threads[0].WaitReason == ThreadWaitReason.Suspended) prcBox.Items.Add($"Process: {prc.ProcessName}.exe | ID: {prc.Id} | Suspended");
                else prcBox.Items.Add($"Process: {prc.ProcessName}.exe | ID: {prc.Id}");
                ProcessID.Add(prc.Id);
                prc.Dispose();
            }
        }
        public AntiGDI()
        {
            InitializeComponent();
        }

        private void prcBox_DropDown(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            Utils.RunFile(@"bin\AntiGDI_Injector.exe", $"{ProcessID[prcBox.SelectedIndex]}", true, false, false);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AntiGDI_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RandomWindowName)
            {
                string RandomName = Utils.RandomString(10, true);
                this.Text = RandomName;
            }
            else this.Text = "SimpleUnlocker [AntiGDI]";
            this.TopMost = Properties.Settings.Default.AlwaysOnTop;
        }
    }
}
