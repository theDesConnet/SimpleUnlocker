using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU.Classes.Autorun;

namespace SU.Forms.Startup
{
    public partial class TaskAbout : Form
    {
        public TaskAbout(TaskInfo Task)
        {
            InitializeComponent();
            Text = $"Свойства: {Task.Name}";
            taskNameBox.Text = Task.Name;
            taskPathBox.Text = Task.Path;
            taskStatusBox.Text = Task.State;
            taskLastRunBox.Text = Task.LastRunTime.ToString();
            taskActivityBox.Text = Task.Enabled ? "Включена" : "Выключена";
            taskDescriptionBox.Text = Task.Description;

            foreach (Trigger t in Task.Trigger)
            {
                TriggerView.Items.Add(new ListViewItem(new string[] { t.Name, t.Enabled ? "Да" : "Нет" }));
            }

            foreach (TaskAction act in Task.TaskAction)
            {
                if (act.CommandAccessible) ActionView.Items.Add(new ListViewItem(new string[] { act.Command, act.HasArguments ? String.Join(" ", act.Arguments) : "" }));
            }
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
