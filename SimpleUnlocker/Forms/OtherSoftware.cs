using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU.Classes;

namespace SU.Forms
{
    public partial class OtherSoftware : Form
    {
        private class Software
        {
            public Software()
            {

            }

            public string Name { get; set; }
            public string Description { get; set; }
            public string Path { get; set; }
        }
        private List<Software> GetListSoftwares()
        {
            var list = new List<Software>();

            if (!Directory.Exists("othersoftware")) return list;

            string[] softwarePaths = Directory.GetDirectories("othersoftware");
            foreach (string path in softwarePaths)
            {
                IniFile soft = new IniFile($@"{path}\software.ini");

                string name = soft.ReadINI("Software", "Name");
                string description = soft.ReadINI("Software", "Description");
                string runFile = soft.ReadINI("Software", "RunFile");

                list.Add(new Software() { Name = name, Description = description, Path = $@"{path}\{runFile}" });
            }
            return list;
        }

        private void GetSoftwares()
        {
            List<Software> softwares = GetListSoftwares();
            osView.Items.Clear();

            foreach (var software in softwares)
            {
                var row = new string[] { software.Name, software.Description };
                var listview = new ListViewItem(row);

                listview.Tag = software;
                osView.Items.Add(listview);
            }
        }

        public OtherSoftware()
        {
            InitializeComponent();
            GetSoftwares();
        }

        private void osView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && osView.SelectedItems.Count > 0)
            {
                Software item = (Software)osView.FocusedItem.Tag;
                Utils.RunFile(item.Path, "", true, false, false);
                WindowState = FormWindowState.Minimized;
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

        private void OtherSoftware_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.CloseForm(e);
        }
    }
}
