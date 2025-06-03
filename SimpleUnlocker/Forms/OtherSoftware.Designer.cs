
namespace SU.Forms
{
    partial class OtherSoftware
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
            this.osBox = new System.Windows.Forms.GroupBox();
            this.osView = new System.Windows.Forms.ListView();
            this.nameSoftwareColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionSoftwareColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuToolStrip.SuspendLayout();
            this.osBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuToolStrip
            // 
            this.menuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem});
            this.menuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.menuToolStrip.Name = "menuToolStrip";
            this.menuToolStrip.Size = new System.Drawing.Size(800, 24);
            this.menuToolStrip.TabIndex = 2;
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
            // osBox
            // 
            this.osBox.Controls.Add(this.osView);
            this.osBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.osBox.Location = new System.Drawing.Point(0, 24);
            this.osBox.Name = "osBox";
            this.osBox.Size = new System.Drawing.Size(800, 426);
            this.osBox.TabIndex = 3;
            this.osBox.TabStop = false;
            this.osBox.Text = "Сторонние утилиты";
            // 
            // osView
            // 
            this.osView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameSoftwareColumn,
            this.descriptionSoftwareColumn});
            this.osView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.osView.FullRowSelect = true;
            this.osView.GridLines = true;
            this.osView.HideSelection = false;
            this.osView.Location = new System.Drawing.Point(3, 16);
            this.osView.MultiSelect = false;
            this.osView.Name = "osView";
            this.osView.Size = new System.Drawing.Size(794, 407);
            this.osView.TabIndex = 0;
            this.osView.UseCompatibleStateImageBehavior = false;
            this.osView.View = System.Windows.Forms.View.Details;
            this.osView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.osView_MouseDoubleClick);
            // 
            // nameSoftwareColumn
            // 
            this.nameSoftwareColumn.Text = "Название";
            this.nameSoftwareColumn.Width = 181;
            // 
            // descriptionSoftwareColumn
            // 
            this.descriptionSoftwareColumn.Text = "Описание";
            this.descriptionSoftwareColumn.Width = 607;
            // 
            // OtherSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.osBox);
            this.Controls.Add(this.menuToolStrip);
            this.Name = "OtherSoftware";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtherSoftware_FormClosing);
            this.menuToolStrip.ResumeLayout(false);
            this.menuToolStrip.PerformLayout();
            this.osBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuToolStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramItem;
        private System.Windows.Forms.GroupBox osBox;
        private System.Windows.Forms.ListView osView;
        private System.Windows.Forms.ColumnHeader nameSoftwareColumn;
        private System.Windows.Forms.ColumnHeader descriptionSoftwareColumn;
    }
}