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
using SU.Classes.Autorun;
using SU.Classes;
using SU.Forms.Startup;
using System.Diagnostics;

namespace SU.Forms
{
    public partial class AutorunView : Form
    {
        TaskCharp task;
        public AutorunView()
        {
            InitializeComponent();
            if (!Program.isSaveMode)
            {
                task = new TaskCharp();

                TaskShedView.Items.Clear();
                TaskShedViewImg.Images.Clear();

                task.ActOnStart += () =>
                {
                    TaskShedView.Items.Clear();
                    TaskShedViewImg.Images.Clear();

                };
                task.ActOnFolder += (e) =>
                {
                    ListViewItem lvi = new ListViewItem($" {e.Name}", TaskShedView.Items.Count);
                    TaskShedViewImg.Images.Add(Properties.Resources.folder);
                    lvi.SubItems.Add(e.Path);
                    lvi.SubItems.Add("Папка");
                    TaskShedView.Items.Add(lvi);
                };
                task.ActOnTask += (t) =>
                {
                    ListViewItem lvi = new ListViewItem($"{t.Name}", TaskShedView.Items.Count);
                    TaskShedViewImg.Images.Add(Properties.Resources.task);
                    lvi.SubItems.Add(t.Path);
                    lvi.SubItems.Add("Задача");
                    TaskShedView.Items.Add(lvi);
                    AutoSizeColumnList(TaskShedView);
                };
                task.ActOnProgress += () => {
                    toolStripTextBox1.Text = task.current.Path;
                };
                task.EnumAllTasks();
            } 
            else
            {
                ARTab.TabPages[2].Dispose();
            }
        }

        private void AutoSizeColumnList(System.Windows.Forms.ListView listView)
        {
            listView.BeginUpdate();
            Dictionary<int, int> columnSize = new Dictionary<int, int>();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (ColumnHeader colHeader in listView.Columns)
                columnSize.Add(colHeader.Index, colHeader.Width);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            foreach (ColumnHeader colHeader in listView.Columns)
            {
                int nColWidth;
                if (columnSize.TryGetValue(colHeader.Index, out nColWidth))
                    colHeader.Width = Math.Max(nColWidth, colHeader.Width);
                else
                    colHeader.Width = Math.Max(50, colHeader.Width);
            }
            listView.EndUpdate();
        }

        private ListView GetCurrentListView()
        {
            switch (ARTab.SelectedIndex)
            {
                case 0:
                    switch (RegTab.SelectedIndex)
                    {
                        case 0:
                            return RunRegView;

                        case 1:
                            return RunOnceRegView;

                        case 2:
                            return WinlogonRegView;
                    }
                    break;

                case 1:
                    return ShellFolderView;       
            }

            return null;
        }

        private void GetAutorunList(AutorunType type)
        {
            switch (type)
            {
                case AutorunType.Registry:
                    RunRegView.Items.Clear();
                    RunOnceRegView.Items.Clear();
                    WinlogonRegView.Items.Clear();

                    foreach (AutorunElem run in Autorun.GetRegistryAutoRun(RegistryPaths.Run, Classes.Utils.RegView))
                    {
                        ListViewItem i = new ListViewItem(new string[]
                        {
                            run.Name,
                            run.Path
                        });
                        i.Tag = run;

                        RunRegView.Items.Add(i);
                    }

                    foreach (AutorunElem run in Autorun.GetRegistryAutoRun(RegistryPaths.RunOnce, Classes.Utils.RegView))
                    {
                        ListViewItem i = new ListViewItem(new string[]
                        {
                            run.Name,
                            run.Path
                        });
                        i.Tag = run;

                        RunOnceRegView.Items.Add(i);
                    }

                    foreach (AutorunElem run in Autorun.GetRegistryAutoRun(RegistryPaths.Winlogon, Classes.Utils.RegView))
                    {
                        ListViewItem i = new ListViewItem(new string[]
                        {
                            run.Name,
                            run.Path
                        });
                        i.Tag = run;

                        WinlogonRegView.Items.Add(i);
                    }
                    break;

                case AutorunType.ShellFolder:
                    ShellFolderView.Items.Clear();

                    foreach (AutorunElem run in Autorun.GetShellAutorun())
                    {
                        ListViewItem i = new ListViewItem(new string[]
{
                            run.Name,
                            run.Path
});
                        i.Tag = run;
                        if (run.Path == "explorer.exe" && run.Name == "Shell" || run.Path.ToLower() == @"c:\windows\system32\userinit.exe" && run.Name == "Userinit") i.BackColor = Color.LightGreen;

                        ShellFolderView.Items.Add(i);
                    }
                    break;

                case AutorunType.TaskScheduler:
                    break;
            }
        }

        private void Autorun_Load(object sender, EventArgs e)
        {
            GetAutorunList(AutorunType.Registry);
            GetAutorunList(AutorunType.ShellFolder);
        }

        private void ShowContext(ListView list, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right
                && list.FocusedItem != null
                && list.FocusedItem.Bounds.Contains(e.Location))
            {
                AutorunMenuStrip.Show(Cursor.Position);
            }
        }

        private void delToolStripContext_Click(object sender, EventArgs e)
        {
            ListView lv = GetCurrentListView();
            foreach (ListViewItem i in lv.SelectedItems)
            {
                ((AutorunElem)i.Tag).Remove();
            }
            GetAutorunList(AutorunType.Registry);
            GetAutorunList(AutorunType.ShellFolder);
        }

        private void RunRegView_MouseClick(object sender, MouseEventArgs e)
        {
            ShowContext(RunRegView, e);
        }

        private void RunOnceRegView_MouseClick(object sender, MouseEventArgs e)
        {
            ShowContext(RunOnceRegView, e);
        }

        private void WinlogonRegView_MouseClick(object sender, MouseEventArgs e)
        {
            ShowContext(WinlogonRegView, e);
        }

        private void ShellFolderView_MouseClick(object sender, MouseEventArgs e)
        {
            ShowContext(ShellFolderView, e);
        }

        private void locateToolStripContext_Click(object sender, EventArgs e)
        {
            ListView lv = GetCurrentListView();
            Utils.RunFile("explorer.exe", $"/n,/select, \"{Utils.GetExecutablePathFromCommand(lv != ShellFolderView ? ((AutorunElem)lv.FocusedItem.Tag).Path : $@"{((AutorunElem)lv.FocusedItem.Tag).Path}\{((AutorunElem)lv.FocusedItem.Tag).Name}")}\"", false, false, false);        
        }

        private void refreshToolStripContext_Click(object sender, EventArgs e)
        {
            GetAutorunList(AutorunType.Registry);
            GetAutorunList(AutorunType.ShellFolder);
        }

        private void AutorunView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.CloseForm(e);
        }

        private void BackToMainMenuStrip_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void ExitStrip_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TaskShedView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (TaskShedView.SelectedIndices.Count > 0 && e.Button == MouseButtons.Left)
            {
                switch (TaskShedView.FocusedItem.SubItems[2].Text)
                {
                    case "Папка": task.EnumAllTasks(TaskShedView.FocusedItem.SubItems[1].Text); break;
                    case "Задача":
                        TaskInfo tI = task.GetTask(TaskShedView.FocusedItem.SubItems[0].Text, TaskShedView.FocusedItem.SubItems[1].Text);
                        using (TaskAbout tA = new TaskAbout(tI))
                        {
                            tA.ShowDialog();
                        }
                        break;
                }
            }
        }

        private void aboutTaskStripBtn_Click(object sender, EventArgs e)
        {
            if (TaskShedView.SelectedIndices.Count > 0 && TaskShedView.FocusedItem.SubItems[2].Text == "Задача")
            {
                TaskInfo tI = task.GetTask(TaskShedView.FocusedItem.SubItems[0].Text, TaskShedView.FocusedItem.SubItems[1].Text);
                using (TaskAbout tA = new TaskAbout(tI))
                {
                    tA.ShowDialog();
                }
            }
        }

        private void deleteTaskContextBtn_Click(object sender, EventArgs e)
        {
            if (TaskShedView.SelectedIndices.Count > 0 && TaskShedView.FocusedItem.SubItems[2].Text == "Задача")
            {
                task.current.DeleteTask(TaskShedView.FocusedItem.Text, 0);
                task.EnumAllTasks(task.current.Path);
            }
        }

        private void backTaskStripBtn_Click(object sender, EventArgs e)
        {
            task.EnumAllTasks(task.parent.Path);
        }

        private void deleteTaskStripBtn_Click(object sender, EventArgs e)
        {
            if (TaskShedView.SelectedIndices.Count > 0 && TaskShedView.FocusedItem.SubItems[2].Text == "Задача")
            {
                task.current.DeleteTask(TaskShedView.FocusedItem.Text, 0);
                task.EnumAllTasks(task.current.Path);
            }
        }

        private void TaskShedView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = TaskShedView.FocusedItem;

                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    TaskShedContextMenu.Show(Cursor.Position);
                }
            }
        }
    }
}
