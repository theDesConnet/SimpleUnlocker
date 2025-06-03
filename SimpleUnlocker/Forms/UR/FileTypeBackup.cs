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
using SU.Classes;

namespace SU.Forms.UR
{
    public partial class FileTypeBackup : Form
    {
        public List<FileType> _fileTypes { get; }
        public FileType _createdFileType { get; set; }
        public FileTypeBackup(List<FileType> fileTypes)
        {
            InitializeComponent();
            List<TextBox> openBoxes = new List<TextBox> { openDefaultBox, defaultRunAsBox, isolateOpenBox, isolateRunAsBox, isolateRunAsUserBox, defaultRunAsUserBox };
            List<TextBox> delegateBoxes = new List<TextBox> { delegateOpenBox, delegateRunAsUserBox, delegateRunAsBox };

            Utils.SendMessage(nameBox.Handle, Utils.EM_SETCUEBANNER, 1, "Пример: CoolFileType");
            Utils.SendMessage(descriptionBox.Handle, Utils.EM_SETCUEBANNER, 1, "Пример: Cool FileType Really");
            Utils.SendMessage(defaultIconBox.Handle, Utils.EM_SETCUEBANNER, 1, @"Пример: C:\Windows\system32\imageres.dll,-67");
            foreach (TextBox box in openBoxes)
            {
                Utils.SendMessage(box.Handle, Utils.EM_SETCUEBANNER, 1, "Пример: %1 %");
            }
            foreach (TextBox box in delegateBoxes)
            {
                Utils.SendMessage(box.Handle, Utils.EM_SETCUEBANNER, 1, "Пример: {ea72d00e-4960-42fa-ba92-7792a7944c1d}");
            }
            DialogResult = DialogResult.Cancel;
            _fileTypes = fileTypes;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameBox.Text))
            {
                
                MessageBox.Show("Вы не указали название типа файла", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (nameBox.Text.StartsWith("."))
            {
                MessageBox.Show("Тип файла не может начинатся с точки", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            FileCommand open = Associations.CreateFileCommand("open", openDefaultBox.Text, isolateOpenBox.Text, delegateOpenBox.Text);
            FileCommand runas = Associations.CreateFileCommand("runas", defaultRunAsBox.Text, isolateRunAsBox.Text, delegateRunAsBox.Text);
            FileCommand runasuser = Associations.CreateFileCommand("runasuser", defaultRunAsUserBox.Text, isolateRunAsUserBox.Text, delegateRunAsUserBox.Text);
            _createdFileType = Associations.CreateFileType(nameBox.Text, descriptionBox.Text, defaultIconBox.Text, open, runas, runasuser);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void FileTypeBackup_Load(object sender, EventArgs e)
        {
            foreach (FileType f in _fileTypes)
            {
                copyFileTypeBox.Items.Add(f.Name);
            }
        }

        private void copyFileTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileType getType = _fileTypes.Find(t => t.Name == copyFileTypeBox.SelectedItem.ToString());

            descriptionBox.Text = getType?.Description;
            openDefaultBox.Text = getType?.ShellOpenCommand?.DefaultCommand;
            isolateOpenBox.Text = getType?.ShellOpenCommand?.IsolatedCommand;
            delegateOpenBox.Text = getType?.ShellOpenCommand?.DelegateExecute;
            defaultRunAsBox.Text = getType?.ShellRunAsCommand?.DefaultCommand;
            isolateRunAsBox.Text = getType?.ShellRunAsCommand?.IsolatedCommand;
            delegateRunAsBox.Text = getType?.ShellRunAsCommand?.DelegateExecute;
            defaultRunAsUserBox.Text = getType?.ShellRunAsUserCommand?.DefaultCommand;
            isolateRunAsUserBox.Text = getType?.ShellRunAsUserCommand?.IsolatedCommand;
            delegateRunAsUserBox.Text = getType?.ShellRunAsUserCommand?.DelegateExecute;
            defaultIconBox.Text = getType?.DefaultIcon;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
