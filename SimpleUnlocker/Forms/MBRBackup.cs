using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU.Classes;

namespace SU.Forms
{
    public partial class MBRBackup : Form
    {
        public MBRBackup()
        {
            InitializeComponent();
        }

        private void DiskBox_DropDown(object sender, EventArgs e)
        {
            DiskBox.Items.Clear();
            string Q = "SELECT DeviceID FROM Win32_DiskDrive";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(Q))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    DiskBox.Items.Add((string)obj["DeviceID"]);
                }
            }
        }

        private void restoreMBRBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SimpleUnlocker MBR Backup|*.suMBR";

                if (DiskBox.SelectedItem != null && ofd.ShowDialog() == DialogResult.OK && MessageBox.Show($"Вы действительно хотите восстановить MBR [{DiskBox.SelectedItem}] из файла? Если был выбран неверный файл восстановления то MBR будет поврежден. Вы делате это на свой страх и риск.", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (BinaryReader MBRBackup = new BinaryReader(File.OpenRead(ofd.FileName)))
                    {
                        if (Utils.WriteMBR(MBRBackup.ReadBytes((int)MBRBackup.BaseStream.Length), DiskBox.SelectedItem.ToString())) MessageBox.Show($"MBR [{DiskBox.SelectedItem}] был успешно восстановлен из файла!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else MessageBox.Show($"MBR [{DiskBox.SelectedItem}] не был восстановлен из файла!", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
        }

        private void backupMBRBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "SimpleUnlocker MBR Backup|*.suMBR";
                sfd.DefaultExt = "suMBR";

                if (DiskBox.SelectedItem != null && sfd.ShowDialog() == DialogResult.OK)
                {
                    using (BinaryWriter MBRBackup = new BinaryWriter(File.OpenWrite(sfd.FileName)))
                    {
                        MBRBackup.Write(Utils.ReadMBR(DiskBox.SelectedItem.ToString()));
                        MBRBackup.Flush();
                        MessageBox.Show($"Резеврная копия MBR [{DiskBox.SelectedItem}] была успешно создана!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void backMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void exitProgramItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MBRBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.CloseForm(e);
        }
    }
}
