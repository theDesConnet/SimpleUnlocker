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

namespace SU.Forms.UR
{
    public partial class AssociationEdit : Form
    {
        public Association _assoc { get; set; }
        public List<FileType> _avaliableTypes { get; }
        public AssociationEdit(Association assoc, List<FileType> avaliableTypes)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            _assoc = assoc;
            _avaliableTypes = avaliableTypes;
        }

        private void AssociationEdit_Load(object sender, EventArgs e)
        {
            foreach (FileType f in _avaliableTypes)
            {
                FileTypeBox.Items.Add(f.Name);
            }
            Console.WriteLine(_assoc.Type?.ShellOpenCommand?.DefaultCommand);
            FileTypeBox.SelectedItem = _assoc.Type.Name;
            AssocBox.Text = _assoc.Name;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            FileType selectedType = _avaliableTypes.Find(t => t.Name == FileTypeBox.SelectedItem.ToString());
            Associations.UpdateAssocFileType(_assoc, selectedType);
            _assoc.Type = selectedType;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
