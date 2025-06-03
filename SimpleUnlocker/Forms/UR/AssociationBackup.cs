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
    public partial class AssociationBackup : Form
    {
        public List<FileType> _avaliableTypes { get; }
        public Association _assoc { get; set; }
        private string _assocName;
        public AssociationBackup(List<FileType> aTypes)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            _avaliableTypes = aTypes;
        }

        private void AssociationBackup_Load(object sender, EventArgs e)
        {
            Utils.SendMessage(AssocBox.Handle, Utils.EM_SETCUEBANNER, 1, "Пример: su или .su");
            foreach (FileType f in _avaliableTypes)
            {
                FileTypeBox.Items.Add(f.Name);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            _assocName = AssocBox.Text;
            if (String.IsNullOrWhiteSpace(_assocName))
            {
                MessageBox.Show("Вы не указали название ассоциации", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_assocName.Count(x => x == '.') > 1)
            {
                MessageBox.Show($"Вы превысили лимит точек (Максимальное количество: 1)", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (!_assocName.StartsWith(".")) _assocName = $".{_assocName}";

            _assoc = Associations.CreateAssociation(_assocName, _avaliableTypes.Find(t => t.Name == FileTypeBox.SelectedItem.ToString()), true);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
