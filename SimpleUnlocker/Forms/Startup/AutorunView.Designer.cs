
namespace SU.Forms
{
    partial class AutorunView
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
            this.components = new System.ComponentModel.Container();
            this.URMenu = new System.Windows.Forms.MenuStrip();
            this.MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToMainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ARTab = new System.Windows.Forms.TabControl();
            this.RegistryPage = new System.Windows.Forms.TabPage();
            this.RegTab = new System.Windows.Forms.TabControl();
            this.RegRunPage = new System.Windows.Forms.TabPage();
            this.RunRegView = new System.Windows.Forms.ListView();
            this.nameRegRunCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueRegRunCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegRunOncePage = new System.Windows.Forms.TabPage();
            this.RunOnceRegView = new System.Windows.Forms.ListView();
            this.nameRunOnceRegCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueRunOnceRegCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegWinlogonPage = new System.Windows.Forms.TabPage();
            this.WinlogonRegView = new System.Windows.Forms.ListView();
            this.nameWinlogonRegCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueWinlogonRegCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ARFolderPage = new System.Windows.Forms.TabPage();
            this.ShellFolderView = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ARTPage = new System.Windows.Forms.TabPage();
            this.TaskShedView = new System.Windows.Forms.ListView();
            this.taskViewName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destTaskView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskShedViewImg = new System.Windows.Forms.ImageList(this.components);
            this.TaskShedToolStrip = new System.Windows.Forms.ToolStrip();
            this.backTaskStripBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteTaskStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.AutorunMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delToolStripContext = new System.Windows.Forms.ToolStripMenuItem();
            this.locateToolStripContext = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripContext = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskShedContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutTaskStripBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskContextBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.URMenu.SuspendLayout();
            this.ARTab.SuspendLayout();
            this.RegistryPage.SuspendLayout();
            this.RegTab.SuspendLayout();
            this.RegRunPage.SuspendLayout();
            this.RegRunOncePage.SuspendLayout();
            this.RegWinlogonPage.SuspendLayout();
            this.ARFolderPage.SuspendLayout();
            this.ARTPage.SuspendLayout();
            this.TaskShedToolStrip.SuspendLayout();
            this.AutorunMenuStrip.SuspendLayout();
            this.TaskShedContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // URMenu
            // 
            this.URMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip});
            this.URMenu.Location = new System.Drawing.Point(0, 0);
            this.URMenu.Name = "URMenu";
            this.URMenu.Size = new System.Drawing.Size(800, 24);
            this.URMenu.TabIndex = 2;
            this.URMenu.Text = "menuStrip1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToMainMenuStrip,
            this.ExitStrip});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(53, 20);
            this.MenuStrip.Text = "Меню";
            // 
            // BackToMainMenuStrip
            // 
            this.BackToMainMenuStrip.Name = "BackToMainMenuStrip";
            this.BackToMainMenuStrip.Size = new System.Drawing.Size(215, 22);
            this.BackToMainMenuStrip.Text = "Вернутся в главное меню";
            this.BackToMainMenuStrip.Click += new System.EventHandler(this.BackToMainMenuStrip_Click);
            // 
            // ExitStrip
            // 
            this.ExitStrip.Name = "ExitStrip";
            this.ExitStrip.Size = new System.Drawing.Size(215, 22);
            this.ExitStrip.Text = "Выход";
            this.ExitStrip.Click += new System.EventHandler(this.ExitStrip_Click);
            // 
            // ARTab
            // 
            this.ARTab.Controls.Add(this.RegistryPage);
            this.ARTab.Controls.Add(this.ARFolderPage);
            this.ARTab.Controls.Add(this.ARTPage);
            this.ARTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ARTab.Location = new System.Drawing.Point(0, 24);
            this.ARTab.Name = "ARTab";
            this.ARTab.SelectedIndex = 0;
            this.ARTab.Size = new System.Drawing.Size(800, 426);
            this.ARTab.TabIndex = 3;
            // 
            // RegistryPage
            // 
            this.RegistryPage.Controls.Add(this.RegTab);
            this.RegistryPage.Location = new System.Drawing.Point(4, 22);
            this.RegistryPage.Name = "RegistryPage";
            this.RegistryPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistryPage.Size = new System.Drawing.Size(792, 400);
            this.RegistryPage.TabIndex = 0;
            this.RegistryPage.Text = "Реестр";
            this.RegistryPage.UseVisualStyleBackColor = true;
            // 
            // RegTab
            // 
            this.RegTab.Controls.Add(this.RegRunPage);
            this.RegTab.Controls.Add(this.RegRunOncePage);
            this.RegTab.Controls.Add(this.RegWinlogonPage);
            this.RegTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegTab.Location = new System.Drawing.Point(3, 3);
            this.RegTab.Name = "RegTab";
            this.RegTab.SelectedIndex = 0;
            this.RegTab.Size = new System.Drawing.Size(786, 394);
            this.RegTab.TabIndex = 0;
            // 
            // RegRunPage
            // 
            this.RegRunPage.Controls.Add(this.RunRegView);
            this.RegRunPage.Location = new System.Drawing.Point(4, 22);
            this.RegRunPage.Name = "RegRunPage";
            this.RegRunPage.Size = new System.Drawing.Size(778, 368);
            this.RegRunPage.TabIndex = 0;
            this.RegRunPage.Text = "Run";
            this.RegRunPage.UseVisualStyleBackColor = true;
            // 
            // RunRegView
            // 
            this.RunRegView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameRegRunCol,
            this.valueRegRunCol});
            this.RunRegView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunRegView.FullRowSelect = true;
            this.RunRegView.GridLines = true;
            this.RunRegView.HideSelection = false;
            this.RunRegView.Location = new System.Drawing.Point(0, 0);
            this.RunRegView.Name = "RunRegView";
            this.RunRegView.Size = new System.Drawing.Size(778, 368);
            this.RunRegView.TabIndex = 0;
            this.RunRegView.UseCompatibleStateImageBehavior = false;
            this.RunRegView.View = System.Windows.Forms.View.Details;
            this.RunRegView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RunRegView_MouseClick);
            // 
            // nameRegRunCol
            // 
            this.nameRegRunCol.Text = "Значение";
            this.nameRegRunCol.Width = 193;
            // 
            // valueRegRunCol
            // 
            this.valueRegRunCol.Text = "Путь";
            this.valueRegRunCol.Width = 566;
            // 
            // RegRunOncePage
            // 
            this.RegRunOncePage.Controls.Add(this.RunOnceRegView);
            this.RegRunOncePage.Location = new System.Drawing.Point(4, 22);
            this.RegRunOncePage.Name = "RegRunOncePage";
            this.RegRunOncePage.Size = new System.Drawing.Size(778, 368);
            this.RegRunOncePage.TabIndex = 2;
            this.RegRunOncePage.Text = "RunOnce";
            this.RegRunOncePage.UseVisualStyleBackColor = true;
            // 
            // RunOnceRegView
            // 
            this.RunOnceRegView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameRunOnceRegCol,
            this.valueRunOnceRegCol});
            this.RunOnceRegView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RunOnceRegView.FullRowSelect = true;
            this.RunOnceRegView.GridLines = true;
            this.RunOnceRegView.HideSelection = false;
            this.RunOnceRegView.Location = new System.Drawing.Point(0, 0);
            this.RunOnceRegView.Name = "RunOnceRegView";
            this.RunOnceRegView.Size = new System.Drawing.Size(778, 368);
            this.RunOnceRegView.TabIndex = 3;
            this.RunOnceRegView.UseCompatibleStateImageBehavior = false;
            this.RunOnceRegView.View = System.Windows.Forms.View.Details;
            this.RunOnceRegView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RunOnceRegView_MouseClick);
            // 
            // nameRunOnceRegCol
            // 
            this.nameRunOnceRegCol.Text = "Значение";
            this.nameRunOnceRegCol.Width = 193;
            // 
            // valueRunOnceRegCol
            // 
            this.valueRunOnceRegCol.Text = "Путь";
            this.valueRunOnceRegCol.Width = 566;
            // 
            // RegWinlogonPage
            // 
            this.RegWinlogonPage.Controls.Add(this.WinlogonRegView);
            this.RegWinlogonPage.Location = new System.Drawing.Point(4, 22);
            this.RegWinlogonPage.Margin = new System.Windows.Forms.Padding(0);
            this.RegWinlogonPage.Name = "RegWinlogonPage";
            this.RegWinlogonPage.Size = new System.Drawing.Size(778, 368);
            this.RegWinlogonPage.TabIndex = 1;
            this.RegWinlogonPage.Text = "Winlogon";
            this.RegWinlogonPage.UseVisualStyleBackColor = true;
            // 
            // WinlogonRegView
            // 
            this.WinlogonRegView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameWinlogonRegCol,
            this.valueWinlogonRegCol});
            this.WinlogonRegView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinlogonRegView.FullRowSelect = true;
            this.WinlogonRegView.GridLines = true;
            this.WinlogonRegView.HideSelection = false;
            this.WinlogonRegView.Location = new System.Drawing.Point(0, 0);
            this.WinlogonRegView.Name = "WinlogonRegView";
            this.WinlogonRegView.Size = new System.Drawing.Size(778, 368);
            this.WinlogonRegView.TabIndex = 1;
            this.WinlogonRegView.UseCompatibleStateImageBehavior = false;
            this.WinlogonRegView.View = System.Windows.Forms.View.Details;
            this.WinlogonRegView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WinlogonRegView_MouseClick);
            // 
            // nameWinlogonRegCol
            // 
            this.nameWinlogonRegCol.Text = "Значение";
            this.nameWinlogonRegCol.Width = 193;
            // 
            // valueWinlogonRegCol
            // 
            this.valueWinlogonRegCol.Text = "Путь";
            this.valueWinlogonRegCol.Width = 566;
            // 
            // ARFolderPage
            // 
            this.ARFolderPage.Controls.Add(this.ShellFolderView);
            this.ARFolderPage.Location = new System.Drawing.Point(4, 22);
            this.ARFolderPage.Name = "ARFolderPage";
            this.ARFolderPage.Padding = new System.Windows.Forms.Padding(3);
            this.ARFolderPage.Size = new System.Drawing.Size(792, 400);
            this.ARFolderPage.TabIndex = 1;
            this.ARFolderPage.Text = "Папка автозагрузки";
            this.ARFolderPage.UseVisualStyleBackColor = true;
            // 
            // ShellFolderView
            // 
            this.ShellFolderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.PathFile});
            this.ShellFolderView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShellFolderView.FullRowSelect = true;
            this.ShellFolderView.GridLines = true;
            this.ShellFolderView.HideSelection = false;
            this.ShellFolderView.Location = new System.Drawing.Point(3, 3);
            this.ShellFolderView.Name = "ShellFolderView";
            this.ShellFolderView.Size = new System.Drawing.Size(786, 394);
            this.ShellFolderView.TabIndex = 1;
            this.ShellFolderView.UseCompatibleStateImageBehavior = false;
            this.ShellFolderView.View = System.Windows.Forms.View.Details;
            this.ShellFolderView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShellFolderView_MouseClick);
            // 
            // FileName
            // 
            this.FileName.Text = "Имя файла";
            this.FileName.Width = 193;
            // 
            // PathFile
            // 
            this.PathFile.Text = "Путь";
            this.PathFile.Width = 566;
            // 
            // ARTPage
            // 
            this.ARTPage.Controls.Add(this.TaskShedView);
            this.ARTPage.Controls.Add(this.TaskShedToolStrip);
            this.ARTPage.Location = new System.Drawing.Point(4, 22);
            this.ARTPage.Name = "ARTPage";
            this.ARTPage.Size = new System.Drawing.Size(792, 400);
            this.ARTPage.TabIndex = 2;
            this.ARTPage.Text = "Планировщик заданий";
            this.ARTPage.UseVisualStyleBackColor = true;
            // 
            // TaskShedView
            // 
            this.TaskShedView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskViewName,
            this.destTaskView});
            this.TaskShedView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskShedView.FullRowSelect = true;
            this.TaskShedView.HideSelection = false;
            this.TaskShedView.Location = new System.Drawing.Point(0, 23);
            this.TaskShedView.Name = "TaskShedView";
            this.TaskShedView.Size = new System.Drawing.Size(792, 377);
            this.TaskShedView.SmallImageList = this.TaskShedViewImg;
            this.TaskShedView.TabIndex = 1;
            this.TaskShedView.UseCompatibleStateImageBehavior = false;
            this.TaskShedView.View = System.Windows.Forms.View.Details;
            this.TaskShedView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TaskShedView_MouseClick);
            this.TaskShedView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TaskShedView_MouseDoubleClick);
            // 
            // taskViewName
            // 
            this.taskViewName.Text = "Имя";
            this.taskViewName.Width = 205;
            // 
            // destTaskView
            // 
            this.destTaskView.Text = "Расположение";
            this.destTaskView.Width = 557;
            // 
            // TaskShedViewImg
            // 
            this.TaskShedViewImg.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.TaskShedViewImg.ImageSize = new System.Drawing.Size(16, 16);
            this.TaskShedViewImg.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TaskShedToolStrip
            // 
            this.TaskShedToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backTaskStripBtn,
            this.deleteTaskStripBtn,
            this.toolStripTextBox1});
            this.TaskShedToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.TaskShedToolStrip.Location = new System.Drawing.Point(0, 0);
            this.TaskShedToolStrip.Name = "TaskShedToolStrip";
            this.TaskShedToolStrip.Size = new System.Drawing.Size(792, 23);
            this.TaskShedToolStrip.TabIndex = 0;
            this.TaskShedToolStrip.Text = "toolStrip1";
            // 
            // backTaskStripBtn
            // 
            this.backTaskStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backTaskStripBtn.Image = global::SU.Properties.Resources.left;
            this.backTaskStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backTaskStripBtn.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.backTaskStripBtn.Name = "backTaskStripBtn";
            this.backTaskStripBtn.Size = new System.Drawing.Size(23, 20);
            this.backTaskStripBtn.Text = "Назад";
            this.backTaskStripBtn.Click += new System.EventHandler(this.backTaskStripBtn_Click);
            // 
            // deleteTaskStripBtn
            // 
            this.deleteTaskStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTaskStripBtn.Image = global::SU.Properties.Resources.delete;
            this.deleteTaskStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTaskStripBtn.Name = "deleteTaskStripBtn";
            this.deleteTaskStripBtn.Size = new System.Drawing.Size(23, 20);
            this.deleteTaskStripBtn.Text = "Удалить";
            this.deleteTaskStripBtn.Click += new System.EventHandler(this.deleteTaskStripBtn_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(500, 23);
            // 
            // AutorunMenuStrip
            // 
            this.AutorunMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delToolStripContext,
            this.locateToolStripContext,
            this.refreshToolStripContext});
            this.AutorunMenuStrip.Name = "AutorunMenuStrip";
            this.AutorunMenuStrip.Size = new System.Drawing.Size(207, 70);
            // 
            // delToolStripContext
            // 
            this.delToolStripContext.Name = "delToolStripContext";
            this.delToolStripContext.Size = new System.Drawing.Size(206, 22);
            this.delToolStripContext.Text = "Удалить";
            this.delToolStripContext.Click += new System.EventHandler(this.delToolStripContext_Click);
            // 
            // locateToolStripContext
            // 
            this.locateToolStripContext.Name = "locateToolStripContext";
            this.locateToolStripContext.Size = new System.Drawing.Size(206, 22);
            this.locateToolStripContext.Text = "Открыть расположение";
            this.locateToolStripContext.Click += new System.EventHandler(this.locateToolStripContext_Click);
            // 
            // refreshToolStripContext
            // 
            this.refreshToolStripContext.Name = "refreshToolStripContext";
            this.refreshToolStripContext.Size = new System.Drawing.Size(206, 22);
            this.refreshToolStripContext.Text = "Обновить";
            this.refreshToolStripContext.Click += new System.EventHandler(this.refreshToolStripContext_Click);
            // 
            // TaskShedContextMenu
            // 
            this.TaskShedContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTaskStripBtn,
            this.deleteTaskContextBtn});
            this.TaskShedContextMenu.Name = "TaskShedContextMenu";
            this.TaskShedContextMenu.Size = new System.Drawing.Size(126, 48);
            // 
            // aboutTaskStripBtn
            // 
            this.aboutTaskStripBtn.Name = "aboutTaskStripBtn";
            this.aboutTaskStripBtn.Size = new System.Drawing.Size(180, 22);
            this.aboutTaskStripBtn.Text = "Свойства";
            this.aboutTaskStripBtn.Click += new System.EventHandler(this.aboutTaskStripBtn_Click);
            // 
            // deleteTaskContextBtn
            // 
            this.deleteTaskContextBtn.Name = "deleteTaskContextBtn";
            this.deleteTaskContextBtn.Size = new System.Drawing.Size(180, 22);
            this.deleteTaskContextBtn.Text = "Удалить";
            this.deleteTaskContextBtn.Click += new System.EventHandler(this.deleteTaskContextBtn_Click);
            // 
            // AutorunView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ARTab);
            this.Controls.Add(this.URMenu);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "AutorunView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutorunView_FormClosing);
            this.Load += new System.EventHandler(this.Autorun_Load);
            this.URMenu.ResumeLayout(false);
            this.URMenu.PerformLayout();
            this.ARTab.ResumeLayout(false);
            this.RegistryPage.ResumeLayout(false);
            this.RegTab.ResumeLayout(false);
            this.RegRunPage.ResumeLayout(false);
            this.RegRunOncePage.ResumeLayout(false);
            this.RegWinlogonPage.ResumeLayout(false);
            this.ARFolderPage.ResumeLayout(false);
            this.ARTPage.ResumeLayout(false);
            this.ARTPage.PerformLayout();
            this.TaskShedToolStrip.ResumeLayout(false);
            this.TaskShedToolStrip.PerformLayout();
            this.AutorunMenuStrip.ResumeLayout(false);
            this.TaskShedContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip URMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem BackToMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStrip;
        private System.Windows.Forms.TabControl ARTab;
        private System.Windows.Forms.TabPage RegistryPage;
        private System.Windows.Forms.TabPage ARFolderPage;
        private System.Windows.Forms.TabControl RegTab;
        private System.Windows.Forms.TabPage RegRunPage;
        private System.Windows.Forms.TabPage RegRunOncePage;
        private System.Windows.Forms.TabPage RegWinlogonPage;
        private System.Windows.Forms.TabPage ARTPage;
        private System.Windows.Forms.ListView RunRegView;
        private System.Windows.Forms.ColumnHeader nameRegRunCol;
        private System.Windows.Forms.ColumnHeader valueRegRunCol;
        private System.Windows.Forms.ListView RunOnceRegView;
        private System.Windows.Forms.ColumnHeader nameRunOnceRegCol;
        private System.Windows.Forms.ColumnHeader valueRunOnceRegCol;
        private System.Windows.Forms.ListView WinlogonRegView;
        private System.Windows.Forms.ColumnHeader nameWinlogonRegCol;
        private System.Windows.Forms.ColumnHeader valueWinlogonRegCol;
        private System.Windows.Forms.ListView ShellFolderView;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader PathFile;
        private System.Windows.Forms.ContextMenuStrip AutorunMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem delToolStripContext;
        private System.Windows.Forms.ToolStripMenuItem locateToolStripContext;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripContext;
        private System.Windows.Forms.ListView TaskShedView;
        private System.Windows.Forms.ColumnHeader taskViewName;
        private System.Windows.Forms.ColumnHeader destTaskView;
        private System.Windows.Forms.ToolStrip TaskShedToolStrip;
        private System.Windows.Forms.ToolStripButton backTaskStripBtn;
        private System.Windows.Forms.ToolStripButton deleteTaskStripBtn;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ImageList TaskShedViewImg;
        private System.Windows.Forms.ContextMenuStrip TaskShedContextMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutTaskStripBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskContextBtn;
    }
}