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
using SU.Forms.UR;
using System.Diagnostics;
using SU.Classes;

namespace SU.Forms
{
    public partial class UnblockRestriction : Form
    {
        private List<FileType> _fileTypes;
        private bool _AutoRestrictDel = false;
        private IProgress<ScanRestrictionResult> scanProgress;
        private void GetListAssocs()
        {
            AssocView.Items.Clear();
            foreach (Association a in Associations.GetAssocs())
            {
                ListViewItem assoc = new ListViewItem(new string[] { a.Name, a.Type.Name, a.Type?.ShellOpenCommand?.DefaultCommand })
                {
                    Tag = a
                };
                AssocView.Items.Add(assoc);
            }
        }
        private void GetListFileTypes()
        {
            FileTypeView.Items.Clear();
            foreach (FileType a in _fileTypes)
            {
                ListViewItem assoc = new ListViewItem(new string[] { a.Name, a?.DefaultIcon, a?.Description, a?.ShellOpenCommand?.DefaultCommand })
                {
                    Tag = a
                };
                FileTypeView.Items.Add(assoc);
            }
        }
        public UnblockRestriction()
        {
            InitializeComponent();
            _fileTypes = Associations.GetFileTypes();
        }

        private async void StartScanButton_Click(object sender, EventArgs e)
        {
            _AutoRestrictDel = AURCheckbox.Checked;
            ResultView.MultiSelect = !_AutoRestrictDel;

            ListViewItem restriction;
            ResultView.Items.Clear();

            scanProgress = new Progress<ScanRestrictionResult>((value) => {
                restriction = new ListViewItem(new string[] { value.restriction.RestrictionName, value.restriction.RestrictionDescription, $@"{value.rKey.Name}\{value.restriction.RestrictionKey}" })
                {
                    Tag = value.restriction
                };

                if (_AutoRestrictDel)
                {
                    try
                    {
                        value.restriction.Unlock(true);
                    } 
                    catch
                    {
                        Utils.RegistryUnlock(value.restriction.RestrictionKey, value.restriction.RestrictionHive, true);
                        Utils.RegistryUnlock(value.restriction.RestrictionKey, value.restriction.RestrictionHive, false);
                        value.restriction.Unlock(true);
                    }
                    
                    restriction.BackColor = Color.LightGreen;
                }

                ResultView.Items.Add(restriction);
            });


            await RestrictionList.GetBasicRestictions(scanProgress);
            await RestrictionList.GetDisallowApps(scanProgress);
            await RestrictionList.GetDebuggerApps(scanProgress);

            using (RegistryKey ScanCode = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Keyboard Layout"))
            {
                object sc = ScanCode.GetValue("Scancode Map");

                if (sc != null)
                {
                    Restriction SCode = new Restriction()
                    {
                        RestrictionName = "Scancode Map",
                        RestrictionDescription = "Scancode Map это ключ в реестре который позволяет переназначать клавишы или отключить их.",
                        RestrictionHive = new RegistryHive[] { RegistryHive.LocalMachine },
                        RestrictionKey = @"SYSTEM\CurrentControlSet\Control\Keyboard Layout"
                    };
                    restriction = new ListViewItem(new string[] { SCode.RestrictionName, SCode.RestrictionDescription, $@"HKEY_LOCAL_MACHINE\{SCode.RestrictionKey}" })
                    {
                        Tag = SCode
                    };

                    if (_AutoRestrictDel)
                    {
                        SCode.Unlock(true);
                        restriction.BackColor = Color.LightGreen;
                    }

                    ResultView.Items.Add(restriction);
                }
            }

            if (useCustomRestrictionsToolStrip.Checked)
            {
                await RestrictionList.GetCustomRestrictions(scanProgress);
            }

            StatusText.Text = _AutoRestrictDel ? $"Состояние: Сканирование и разблокировка ограничений успешно завершена! [{ResultView.Items.Count}]" : "Состояние: Сканирование успешно завершено!";
        }

        private void ResultView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && 
                ResultView.FocusedItem != null && 
                ResultView.FocusedItem.Bounds.Contains(e.Location) &&
                !_AutoRestrictDel)
            {
                ScanResultContext.Show(Cursor.Position);
            }
        }

        private void UnblockRestriction_Load(object sender, EventArgs e)
        {
            foreach (Restriction BR in RestrictionList.BasicRestrictions)
            {
                ListViewItem restriction = new ListViewItem(new string[] { BR.RestrictionName, BR.RestrictionDescription })
                {
                    Tag = BR
                };

                BasicRestrictionList.Items.Add(restriction);
            }
            GetListAssocs();
            GetListFileTypes();
        }

        private void BasicRestrictionList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ManualUnlockBtn.Enabled = BasicRestrictionList.CheckedItems.Count > 0;
        }

        private void SelectAllBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem br in BasicRestrictionList.Items)
            {
                br.Checked = SelectAllBox.Checked;
            }
        }

        private void URToolMenuStrip_Click(object sender, EventArgs e)
        {
            int Count = ResultView.SelectedItems.Count;
            foreach (ListViewItem restricion in ResultView.SelectedItems)
            {
                Restriction r = (Restriction)restricion.Tag;
                try
                {
                    r.Unlock(true);
                }
                catch
                {
                    Utils.RegistryUnlock(r.RestrictionKey, r.RestrictionHive, true);
                    Utils.RegistryUnlock(r.RestrictionKey, r.RestrictionHive, false);
                    r.Unlock(true);
                }
                

                restricion.Remove();
            }
            StatusText.Text = $"Состояние: Ограничения успешно разблокированны [{Count}]";
        }

        private void ManualUnlockBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem ur in BasicRestrictionList.CheckedItems)
            {
                Restriction res = (Restriction)ur.Tag;
                res.Unlock(true);
            }
            StatusText.Text = "Состояние: Успех!";
        }

        private void UnblockRestriction_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void AssocView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && AssocView.SelectedItems.Count > 0)
            {
                using (AssociationEdit ep = new AssociationEdit((Association)AssocView.FocusedItem.Tag, _fileTypes))
                {
                    if (ep.ShowDialog() == DialogResult.OK)
                    {
                        AssocView.Items[AssocView.FocusedItem.Index] = new ListViewItem(new string[] { ep._assoc.Name, ep._assoc.Type.Name, ep._assoc.Type?.ShellOpenCommand?.DefaultCommand }) { Tag = ep._assoc };
                        AssocView.Update();
                        StatusText.Text = $"Состояние: Успешно изменена ассоциация {ep._assoc.Name}";
                    }
                }
            }
        }

        private void CreateAssocStrip_Click(object sender, EventArgs e)
        {
            using (AssociationBackup assocBackup = new AssociationBackup(_fileTypes))
            {
                if (assocBackup.ShowDialog() == DialogResult.OK)
                {
                    StatusText.Text = $"Состояние: Успешно создана ассоциация {assocBackup._assoc.Name}";
                    GetListAssocs();
                }
            }
        }

        private void AssocView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right 
                && AssocView.FocusedItem != null 
                && AssocView.FocusedItem.Bounds.Contains(e.Location))
            {
                AssocContextList.Show(Cursor.Position);
            }
        }

        private void deleteAssocMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Внимание! Данное действие является необратимым!\nВы точно хотите удалить данные ассоциации?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (ListViewItem i in AssocView.SelectedItems)
                {
                    Associations.RemoveAssociation((Association)i.Tag);
                }
                StatusText.Text = $"Состояние: Удаление ассоциаций прошло успешно! [{AssocView.SelectedItems.Count}]";
                GetListAssocs();
            }
        }

        private void changeAssocMenuItem_Click(object sender, EventArgs e)
        {
            using (AssociationEdit ep = new AssociationEdit((Association)AssocView.FocusedItem.Tag, _fileTypes))
            {
                if (ep.ShowDialog() == DialogResult.OK)
                {
                    AssocView.Items[AssocView.FocusedItem.Index] = new ListViewItem(new string[] { ep._assoc.Name, ep._assoc.Type.Name, ep._assoc.Type?.ShellOpenCommand?.DefaultCommand }) { Tag = ep._assoc };
                    AssocView.Update();
                    StatusText.Text = $"Состояние: Успешно изменена ассоциация {ep._assoc.Name}";
                }
            }
        }

        private void refreshAssocMenuItem_Click(object sender, EventArgs e)
        {
            GetListAssocs();
        }

        private void CreateFileTypeStrip_Click(object sender, EventArgs e)
        {
            using (FileTypeBackup fTypeBackup = new FileTypeBackup(_fileTypes))
            {
                if (fTypeBackup.ShowDialog() == DialogResult.OK)
                {
                    StatusText.Text = $"Состояние: Успешно создан тип файла {fTypeBackup._createdFileType.Name}";
                    _fileTypes = Associations.GetFileTypes();
                    GetListFileTypes();
                }
            }
        }

        private void FileTypeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && FileTypeView.SelectedItems.Count > 0)
            {
                using (FileTypeEdit fte = new FileTypeEdit((FileType)FileTypeView.FocusedItem.Tag))
                {
                    if (fte.ShowDialog() == DialogResult.OK)
                    {
                        FileTypeView.Items[FileTypeView.FocusedItem.Index] = new ListViewItem(new string[] { fte._fileType.Name, fte._fileType.DefaultIcon, fte._fileType.Description, fte._fileType.ShellOpenCommand.DefaultCommand })
                        { 
                            Tag = fte._fileType 
                        };
                        FileTypeView.Update();
                        StatusText.Text = $"Состояние: Успешно изменён тип файла {fte._fileType.Name}";
                    }
                }
            }
        }

        private void FileTypeView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right
                && FileTypeView.FocusedItem != null
                && FileTypeView.FocusedItem.Bounds.Contains(e.Location))
            {
                FileTypeContext.Show(Cursor.Position);
            }
        }

        private void delFTItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Внимание! Данное действие является необратимым!\nВы точно хотите удалить данные типы файлов?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (ListViewItem i in FileTypeView.SelectedItems)
                {
                    Associations.RemoveFileType((FileType)i.Tag);
                }
                StatusText.Text = $"Состояние: Удаление типов файлов прошло успешно! [{FileTypeView.SelectedItems.Count}]";
                _fileTypes = Associations.GetFileTypes();
                GetListFileTypes();
            }
        }

        private void chgFTItem_Click(object sender, EventArgs e)
        {
            using (FileTypeEdit fte = new FileTypeEdit((FileType)FileTypeView.FocusedItem.Tag))
            {
                if (fte.ShowDialog() == DialogResult.OK)
                {
                    FileTypeView.Items[FileTypeView.FocusedItem.Index] = new ListViewItem(new string[] { fte._fileType.Name, fte._fileType.DefaultIcon, fte._fileType.Description, fte._fileType.ShellOpenCommand.DefaultCommand })
                    {
                        Tag = fte._fileType
                    };
                    FileTypeView.Update();
                    StatusText.Text = $"Состояние: Успешно изменён тип файла {fte._fileType.Name}";
                }
            }
        }

        private void refFTItem_Click(object sender, EventArgs e)
        {
            _fileTypes = Associations.GetFileTypes();
            GetListFileTypes();
        }

        private void OpenRegistryToolStripMenu_Click(object sender, EventArgs e)
        {
            using (RegistryKey rEdit = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Applets\Regedit"))
            {
                foreach (Process p in Process.GetProcessesByName("regedit"))
                {
                    p.Kill();
                }
                rEdit.SetValue("LastKey", $@"{ResultView.FocusedItem.SubItems[2].Text}");
                Process.Start("regedit.exe");
            }
        }

        private void ExitStrip_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void UnblockRestriction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.CloseForm(e);
        }

        private void BackToMainMenuStrip_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void createCustomRestrictionToolStrip_Click(object sender, EventArgs e)
        {
            using (AddCustomRestriction aCR = new AddCustomRestriction())
            {
                aCR.ShowDialog();
            }
        }

        private void useCustomRestrictionsToolStrip_Click(object sender, EventArgs e)
        {
            if (useCustomRestrictionsToolStrip.Checked && 
                MessageBox.Show(
                    "Автор SimpleUnlocker не несёт ответственности за кастомные ограничения. Используйте их на свой страх и риск.\n\nВы действительно хотите использовать кастомные ограничения?", 
                    "Внимание!" , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                useCustomRestrictionsToolStrip.Checked = false;
            }
        }
    }
}
