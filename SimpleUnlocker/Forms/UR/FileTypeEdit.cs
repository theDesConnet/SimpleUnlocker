using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SU.Classes;
using SU.Classes.UR;

namespace SU.Forms.UR
{
    public partial class FileTypeEdit : Form
    {
        public FileType _fileType;
        public FileTypeEdit(FileType ft)
        {
            InitializeComponent();

            List<TextBox> openBoxes = new List<TextBox> { openDefaultBox, defaultRunAsBox, isolateOpenBox, isolateRunAsBox, isolateRunAsUserBox, defaultRunAsUserBox };
            List<TextBox> delegateBoxes = new List<TextBox> { delegateOpenBox, delegateRunAsUserBox, delegateRunAsBox };

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
            _fileType = ft;

            nameBox.Text = _fileType.Name;
            descriptionBox.Text = _fileType?.Description;
            openDefaultBox.Text = _fileType?.ShellOpenCommand?.DefaultCommand;
            isolateOpenBox.Text = _fileType?.ShellOpenCommand?.IsolatedCommand;
            delegateOpenBox.Text = _fileType?.ShellOpenCommand?.DelegateExecute;
            defaultRunAsBox.Text = _fileType?.ShellRunAsCommand?.DefaultCommand;
            isolateRunAsBox.Text = _fileType?.ShellRunAsCommand?.IsolatedCommand;
            delegateRunAsBox.Text = _fileType?.ShellRunAsCommand?.DelegateExecute;
            defaultRunAsUserBox.Text = _fileType?.ShellRunAsUserCommand?.DefaultCommand;
            isolateRunAsUserBox.Text = _fileType?.ShellRunAsUserCommand?.IsolatedCommand;
            delegateRunAsUserBox.Text = _fileType?.ShellRunAsUserCommand?.DelegateExecute;
            defaultIconBox.Text = _fileType?.DefaultIcon;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            FileCommand open = Associations.CreateFileCommand("open", openDefaultBox.Text, isolateOpenBox.Text, delegateOpenBox.Text);
            FileCommand runas = Associations.CreateFileCommand("runas", defaultRunAsBox.Text, isolateRunAsBox.Text, delegateRunAsBox.Text);
            FileCommand runasuser = Associations.CreateFileCommand("runasuser", defaultRunAsUserBox.Text, isolateRunAsUserBox.Text, delegateRunAsUserBox.Text);
            _fileType = Associations.UpdateFileType(_fileType, defaultIconBox.Text, descriptionBox.Text, open, runas, runasuser);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
