namespace SU.Forms
{
    partial class MBRBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuToolStrip = new System.Windows.Forms.MenuStrip();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MBRBox = new System.Windows.Forms.GroupBox();
            this.DiskBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.restoreMBRBtn = new System.Windows.Forms.Button();
            this.backupMBRBtn = new System.Windows.Forms.Button();
            this.menuToolStrip.SuspendLayout();
            this.MBRBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem});
            this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(271, 24);
            this.menuToolStrip.TabIndex = 1;
            this.menuToolStrip.Text = "menuStrip1";
            // 
            // menuItem
            // 
            this.menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuItem,
            this.exitProgramItem});
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(53, 20);
            this.menuItem.Text = "Меню";
            // 
            // backMenuItem
            // 
            this.backMenuItem.Name = "backMenuItem";
            this.backMenuItem.Size = new System.Drawing.Size(221, 22);
            this.backMenuItem.Text = "Вернуться в главное меню";
            this.backMenuItem.Click += new System.EventHandler(this.backMenuItem_Click);
            // 
            // exitProgramItem
            // 
            this.exitProgramItem.Name = "exitProgramItem";
            this.exitProgramItem.Size = new System.Drawing.Size(221, 22);
            this.exitProgramItem.Text = "Выйти из программы";
            this.exitProgramItem.Click += new System.EventHandler(this.exitProgramItem_Click);
            // 
            // MBRBox
            // 
            this.MBRBox.Controls.Add(this.DiskBox);
            this.MBRBox.Controls.Add(this.label1);
            this.MBRBox.Controls.Add(this.restoreMBRBtn);
            this.MBRBox.Controls.Add(this.backupMBRBtn);
            this.MBRBox.Location = new System.Drawing.Point(12, 27);
            this.MBRBox.Name = "MBRBox";
            this.MBRBox.Size = new System.Drawing.Size(243, 109);
            this.MBRBox.TabIndex = 2;
            this.MBRBox.TabStop = false;
            this.MBRBox.Text = "MBR Backup";
            // 
            // DiskBox
            // 
            this.DiskBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiskBox.FormattingEnabled = true;
            this.DiskBox.Location = new System.Drawing.Point(53, 19);
            this.DiskBox.Name = "DiskBox";
            this.DiskBox.Size = new System.Drawing.Size(180, 21);
            this.DiskBox.TabIndex = 2;
            this.DiskBox.DropDown += new System.EventHandler(this.DiskBox_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Диск:";
            // 
            // restoreMBRBtn
            // 
            this.restoreMBRBtn.Location = new System.Drawing.Point(10, 46);
            this.restoreMBRBtn.Name = "restoreMBRBtn";
            this.restoreMBRBtn.Size = new System.Drawing.Size(223, 23);
            this.restoreMBRBtn.TabIndex = 0;
            this.restoreMBRBtn.Text = "Восстановить из файла";
            this.restoreMBRBtn.UseVisualStyleBackColor = true;
            this.restoreMBRBtn.Click += new System.EventHandler(this.restoreMBRBtn_Click);
            // 
            // backupMBRBtn
            // 
            this.backupMBRBtn.Location = new System.Drawing.Point(10, 75);
            this.backupMBRBtn.Name = "backupMBRBtn";
            this.backupMBRBtn.Size = new System.Drawing.Size(223, 23);
            this.backupMBRBtn.TabIndex = 1;
            this.backupMBRBtn.Text = "Сделать backup";
            this.backupMBRBtn.UseVisualStyleBackColor = true;
            this.backupMBRBtn.Click += new System.EventHandler(this.backupMBRBtn_Click);
            // 
            // MBRBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 145);
            this.Controls.Add(this.MBRBox);
            this.Controls.Add(this.menuToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MBRBackup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MBRBackup_FormClosing);
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            this.MBRBox.ResumeLayout(false);
            this.MBRBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramItem;
        private System.Windows.Forms.GroupBox MBRBox;
        private System.Windows.Forms.Button backupMBRBtn;
        private System.Windows.Forms.Button restoreMBRBtn;
        private System.Windows.Forms.ComboBox DiskBox;
        private System.Windows.Forms.Label label1;
    }
}