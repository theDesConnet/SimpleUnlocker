using SU.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU.Classes.UR;
using Microsoft.Win32;
using System.IO;

namespace SU.Forms.UR
{
    public partial class AddCustomRestriction : Form
    {
        private ComboboxItem[] hives = { new ComboboxItem("LocalMachine", RegistryHive.LocalMachine), new ComboboxItem("CurrentUser", RegistryHive.CurrentUser) };
        public AddCustomRestriction()
        {
            InitializeComponent();
            hiveCombobox.Items.AddRange(hives);
            hiveCombobox.SelectedIndex = 0;

            Utils.SendMessage(pathTextbox.Handle, Utils.EM_SETCUEBANNER, 1, @"Пример: Software\Microsoft\Windows\CurrentVersion\Policies\System");
            Utils.SendMessage(keyTextbox.Handle, Utils.EM_SETCUEBANNER, 1, @"Пример: DisableTaskMgr");
            Utils.SendMessage(descriptionBox.Handle, Utils.EM_SETCUEBANNER, 1, @"Пример: Блокировка диспетчера задач");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            object disableValue = null;

            if (!disableValueNoneBox.Checked) disableValue = disableValueNumber.Value;

            Restriction r = new Restriction()
            {
                RestrictionHive = new RegistryHive[] { (RegistryHive)(hiveCombobox.SelectedItem as ComboboxItem).Value },
                RestrictionName = keyTextbox.Text,
                RestrictionDescription = descriptionBox.Text,
                RestrictionKey = pathTextbox.Text,
                DisableValue = disableValue
            };

            if (!Directory.Exists("restrictions")) Directory.CreateDirectory("restrictions");
            File.WriteAllBytes($"restrictions/{keyTextbox.Text}.rsu", Encoding.UTF8.GetBytes(JSONHelper.Serialize(r)));
            DialogResult = DialogResult.OK;
            Close();
        }

        private void disableValueNoneBox_CheckedChanged(object sender, EventArgs e)
        {
            disableValueNumber.Enabled = !disableValueNoneBox.Checked;
        }
    }

    internal class ComboboxItem
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public ComboboxItem(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
