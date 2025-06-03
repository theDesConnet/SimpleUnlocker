
namespace SU.Forms
{
    partial class TaskManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManager));
            this.ManagerStatusStrip = new System.Windows.Forms.StatusStrip();
            this.CPUSSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RAMSSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProcessesSSLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.addonStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ManagerMenu = new System.Windows.Forms.MenuStrip();
            this.MenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.runStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackToMainMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addonStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiGDIStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCheckPrcStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noHiddenFormStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncriticalPrcStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerMenuStrip = new System.Windows.Forms.ToolStrip();
            this.RefreshMenuBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TerminateMenuBtn = new System.Windows.Forms.ToolStripButton();
            this.SuspendMenuBtn = new System.Windows.Forms.ToolStripButton();
            this.ResumeMenuBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CriticalMenuBtn = new System.Windows.Forms.ToolStripButton();
            this.UncriticalMenuBtn = new System.Windows.Forms.ToolStripButton();
            this.ManagerMode = new System.Windows.Forms.TabControl();
            this.TaskMgrPage = new System.Windows.Forms.TabPage();
            this.TMView = new System.Windows.Forms.ListView();
            this.ProcessColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CriticalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServicesPage = new System.Windows.Forms.TabPage();
            this.ServiceView = new System.Windows.Forms.ListView();
            this.srvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.srvDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.srvStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.srvType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrcTimer = new System.Windows.Forms.Timer(this.components);
            this.CPUTimer = new System.Windows.Forms.Timer(this.components);
            this.RAMTimer = new System.Windows.Forms.Timer(this.components);
            this.ProcessContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePrcMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suspendPrcMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criticalPrcMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorMItem = new System.Windows.Forms.ToolStripSeparator();
            this.addonMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiGDIMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prcPathMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPrcMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopMostTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckMinimaze = new System.Windows.Forms.Timer(this.components);
            this.ServiceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runSrvMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopSrvMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSrvMItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerStatusStrip.SuspendLayout();
            this.ManagerMenu.SuspendLayout();
            this.ManagerMenuStrip.SuspendLayout();
            this.ManagerMode.SuspendLayout();
            this.TaskMgrPage.SuspendLayout();
            this.ServicesPage.SuspendLayout();
            this.ProcessContextMenu.SuspendLayout();
            this.ServiceContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagerStatusStrip
            // 
            this.ManagerStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CPUSSLabel,
            this.RAMSSLabel,
            this.ProcessesSSLabel,
            this.addonStripLabel});
            this.ManagerStatusStrip.Location = new System.Drawing.Point(0, 524);
            this.ManagerStatusStrip.Name = "ManagerStatusStrip";
            this.ManagerStatusStrip.Size = new System.Drawing.Size(950, 22);
            this.ManagerStatusStrip.TabIndex = 1;
            this.ManagerStatusStrip.Text = "statusStrip1";
            // 
            // CPUSSLabel
            // 
            this.CPUSSLabel.Name = "CPUSSLabel";
            this.CPUSSLabel.Size = new System.Drawing.Size(87, 17);
            this.CPUSSLabel.Text = "CPU Usage: 0%";
            // 
            // RAMSSLabel
            // 
            this.RAMSSLabel.Name = "RAMSSLabel";
            this.RAMSSLabel.Size = new System.Drawing.Size(101, 17);
            this.RAMSSLabel.Text = "RAM Usage: 0 MB";
            // 
            // ProcessesSSLabel
            // 
            this.ProcessesSSLabel.Name = "ProcessesSSLabel";
            this.ProcessesSSLabel.Size = new System.Drawing.Size(80, 17);
            this.ProcessesSSLabel.Text = "Процессов: 0";
            // 
            // addonStripLabel
            // 
            this.addonStripLabel.Name = "addonStripLabel";
            this.addonStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ManagerMenu
            // 
            this.ManagerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip,
            this.addonStripItem,
            this.settingsStripItem});
            this.ManagerMenu.Location = new System.Drawing.Point(0, 0);
            this.ManagerMenu.Name = "ManagerMenu";
            this.ManagerMenu.Size = new System.Drawing.Size(950, 24);
            this.ManagerMenu.TabIndex = 4;
            this.ManagerMenu.Text = "menuStrip1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runStripItem,
            this.BackToMainMenuStrip,
            this.ExitStrip});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(53, 20);
            this.MenuStrip.Text = "Меню";
            // 
            // runStripItem
            // 
            this.runStripItem.Name = "runStripItem";
            this.runStripItem.Size = new System.Drawing.Size(215, 22);
            this.runStripItem.Text = "Выполнить";
            this.runStripItem.Click += new System.EventHandler(this.runStripItem_Click);
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
            // addonStripItem
            // 
            this.addonStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiGDIStripItem});
            this.addonStripItem.Name = "addonStripItem";
            this.addonStripItem.Size = new System.Drawing.Size(107, 20);
            this.addonStripItem.Text = "Дополнительно";
            // 
            // antiGDIStripItem
            // 
            this.antiGDIStripItem.Name = "antiGDIStripItem";
            this.antiGDIStripItem.Size = new System.Drawing.Size(115, 22);
            this.antiGDIStripItem.Text = "AntiGDI";
            this.antiGDIStripItem.Click += new System.EventHandler(this.antiGDIStripItem_Click);
            // 
            // settingsStripItem
            // 
            this.settingsStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoCheckPrcStripItem,
            this.topMostStripItem,
            this.noHiddenFormStripItem,
            this.uncriticalPrcStripItem});
            this.settingsStripItem.Name = "settingsStripItem";
            this.settingsStripItem.Size = new System.Drawing.Size(79, 20);
            this.settingsStripItem.Text = "Настройки";
            // 
            // autoCheckPrcStripItem
            // 
            this.autoCheckPrcStripItem.Checked = true;
            this.autoCheckPrcStripItem.CheckOnClick = true;
            this.autoCheckPrcStripItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoCheckPrcStripItem.Name = "autoCheckPrcStripItem";
            this.autoCheckPrcStripItem.Size = new System.Drawing.Size(369, 22);
            this.autoCheckPrcStripItem.Text = "Автообновление списка процессов";
            this.autoCheckPrcStripItem.Click += new System.EventHandler(this.autoCheckPrcStripItem_Click);
            // 
            // topMostStripItem
            // 
            this.topMostStripItem.CheckOnClick = true;
            this.topMostStripItem.Name = "topMostStripItem";
            this.topMostStripItem.Size = new System.Drawing.Size(369, 22);
            this.topMostStripItem.Text = "Принудительно поверх всех окон";
            this.topMostStripItem.Click += new System.EventHandler(this.topMostStripItem_Click);
            // 
            // noHiddenFormStripItem
            // 
            this.noHiddenFormStripItem.CheckOnClick = true;
            this.noHiddenFormStripItem.Name = "noHiddenFormStripItem";
            this.noHiddenFormStripItem.Size = new System.Drawing.Size(369, 22);
            this.noHiddenFormStripItem.Text = "Предотвращение сворачивания окна";
            this.noHiddenFormStripItem.Click += new System.EventHandler(this.noHiddenFormStripItem_Click);
            // 
            // uncriticalPrcStripItem
            // 
            this.uncriticalPrcStripItem.Checked = true;
            this.uncriticalPrcStripItem.CheckOnClick = true;
            this.uncriticalPrcStripItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uncriticalPrcStripItem.Name = "uncriticalPrcStripItem";
            this.uncriticalPrcStripItem.Size = new System.Drawing.Size(369, 22);
            this.uncriticalPrcStripItem.Text = "Делать процесс не критическим при его завершении";
            // 
            // ManagerMenuStrip
            // 
            this.ManagerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshMenuBtn,
            this.toolStripSeparator1,
            this.TerminateMenuBtn,
            this.SuspendMenuBtn,
            this.ResumeMenuBtn,
            this.toolStripSeparator2,
            this.CriticalMenuBtn,
            this.UncriticalMenuBtn});
            this.ManagerMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ManagerMenuStrip.Location = new System.Drawing.Point(0, 24);
            this.ManagerMenuStrip.Name = "ManagerMenuStrip";
            this.ManagerMenuStrip.Size = new System.Drawing.Size(950, 23);
            this.ManagerMenuStrip.TabIndex = 5;
            // 
            // RefreshMenuBtn
            // 
            this.RefreshMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshMenuBtn.Image")));
            this.RefreshMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshMenuBtn.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.RefreshMenuBtn.Name = "RefreshMenuBtn";
            this.RefreshMenuBtn.Size = new System.Drawing.Size(81, 20);
            this.RefreshMenuBtn.Text = "Обновить";
            this.RefreshMenuBtn.Click += new System.EventHandler(this.RefreshMenuBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // TerminateMenuBtn
            // 
            this.TerminateMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TerminateMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("TerminateMenuBtn.Image")));
            this.TerminateMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TerminateMenuBtn.Name = "TerminateMenuBtn";
            this.TerminateMenuBtn.Size = new System.Drawing.Size(23, 20);
            this.TerminateMenuBtn.Text = "toolStripButton2";
            this.TerminateMenuBtn.ToolTipText = "Завершить процесс";
            this.TerminateMenuBtn.Click += new System.EventHandler(this.TerminateMenuBtn_Click);
            // 
            // SuspendMenuBtn
            // 
            this.SuspendMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SuspendMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("SuspendMenuBtn.Image")));
            this.SuspendMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SuspendMenuBtn.Name = "SuspendMenuBtn";
            this.SuspendMenuBtn.Size = new System.Drawing.Size(23, 20);
            this.SuspendMenuBtn.Text = "Заморозить";
            this.SuspendMenuBtn.ToolTipText = "Заморозить процесс";
            this.SuspendMenuBtn.Click += new System.EventHandler(this.SuspendMenuBtn_Click);
            // 
            // ResumeMenuBtn
            // 
            this.ResumeMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResumeMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("ResumeMenuBtn.Image")));
            this.ResumeMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResumeMenuBtn.Name = "ResumeMenuBtn";
            this.ResumeMenuBtn.Size = new System.Drawing.Size(23, 20);
            this.ResumeMenuBtn.Text = "Разморозить";
            this.ResumeMenuBtn.ToolTipText = "Разморозить процесс";
            this.ResumeMenuBtn.Click += new System.EventHandler(this.ResumeMenuBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // CriticalMenuBtn
            // 
            this.CriticalMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CriticalMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("CriticalMenuBtn.Image")));
            this.CriticalMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CriticalMenuBtn.Name = "CriticalMenuBtn";
            this.CriticalMenuBtn.Size = new System.Drawing.Size(23, 20);
            this.CriticalMenuBtn.Text = "Critical";
            this.CriticalMenuBtn.ToolTipText = "Сделать процесс критическим";
            this.CriticalMenuBtn.Click += new System.EventHandler(this.CriticalMenuBtn_Click);
            // 
            // UncriticalMenuBtn
            // 
            this.UncriticalMenuBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UncriticalMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("UncriticalMenuBtn.Image")));
            this.UncriticalMenuBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UncriticalMenuBtn.Name = "UncriticalMenuBtn";
            this.UncriticalMenuBtn.Size = new System.Drawing.Size(23, 20);
            this.UncriticalMenuBtn.Text = "Uncritical";
            this.UncriticalMenuBtn.ToolTipText = "Сделать процесс некритическим";
            this.UncriticalMenuBtn.Click += new System.EventHandler(this.UncriticalMenuBtn_Click);
            // 
            // ManagerMode
            // 
            this.ManagerMode.Controls.Add(this.TaskMgrPage);
            this.ManagerMode.Controls.Add(this.ServicesPage);
            this.ManagerMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManagerMode.Location = new System.Drawing.Point(0, 47);
            this.ManagerMode.Name = "ManagerMode";
            this.ManagerMode.SelectedIndex = 0;
            this.ManagerMode.Size = new System.Drawing.Size(950, 477);
            this.ManagerMode.TabIndex = 6;
            // 
            // TaskMgrPage
            // 
            this.TaskMgrPage.Controls.Add(this.TMView);
            this.TaskMgrPage.Location = new System.Drawing.Point(4, 22);
            this.TaskMgrPage.Name = "TaskMgrPage";
            this.TaskMgrPage.Padding = new System.Windows.Forms.Padding(3);
            this.TaskMgrPage.Size = new System.Drawing.Size(942, 451);
            this.TaskMgrPage.TabIndex = 0;
            this.TaskMgrPage.Text = "Процессы";
            this.TaskMgrPage.UseVisualStyleBackColor = true;
            // 
            // TMView
            // 
            this.TMView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessColumn,
            this.IdColumn,
            this.StatusColumn,
            this.UserColumn,
            this.CriticalColumn,
            this.DescriptionColumn});
            this.TMView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TMView.FullRowSelect = true;
            this.TMView.GridLines = true;
            this.TMView.HideSelection = false;
            this.TMView.Location = new System.Drawing.Point(3, 3);
            this.TMView.Name = "TMView";
            this.TMView.Size = new System.Drawing.Size(936, 445);
            this.TMView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.TMView.TabIndex = 0;
            this.TMView.UseCompatibleStateImageBehavior = false;
            this.TMView.View = System.Windows.Forms.View.Details;
            this.TMView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TMView_KeyDown);
            this.TMView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TMView_MouseClick);
            // 
            // ProcessColumn
            // 
            this.ProcessColumn.Text = "Process";
            this.ProcessColumn.Width = 222;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "ID";
            this.IdColumn.Width = 70;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Text = "Status";
            this.StatusColumn.Width = 100;
            // 
            // UserColumn
            // 
            this.UserColumn.Text = "Username";
            this.UserColumn.Width = 153;
            // 
            // CriticalColumn
            // 
            this.CriticalColumn.Text = "Critical";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 324;
            // 
            // ServicesPage
            // 
            this.ServicesPage.Controls.Add(this.ServiceView);
            this.ServicesPage.Location = new System.Drawing.Point(4, 22);
            this.ServicesPage.Name = "ServicesPage";
            this.ServicesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ServicesPage.Size = new System.Drawing.Size(942, 451);
            this.ServicesPage.TabIndex = 1;
            this.ServicesPage.Text = "Службы";
            this.ServicesPage.UseVisualStyleBackColor = true;
            // 
            // ServiceView
            // 
            this.ServiceView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.srvName,
            this.srvDescription,
            this.srvStatus,
            this.srvType});
            this.ServiceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceView.FullRowSelect = true;
            this.ServiceView.GridLines = true;
            this.ServiceView.HideSelection = false;
            this.ServiceView.Location = new System.Drawing.Point(3, 3);
            this.ServiceView.Name = "ServiceView";
            this.ServiceView.Size = new System.Drawing.Size(936, 445);
            this.ServiceView.TabIndex = 1;
            this.ServiceView.UseCompatibleStateImageBehavior = false;
            this.ServiceView.View = System.Windows.Forms.View.Details;
            this.ServiceView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ServiceView_MouseClick);
            // 
            // srvName
            // 
            this.srvName.Text = "Имя службы";
            this.srvName.Width = 209;
            // 
            // srvDescription
            // 
            this.srvDescription.Text = "Отображаемое имя";
            this.srvDescription.Width = 468;
            // 
            // srvStatus
            // 
            this.srvStatus.Text = "Статус";
            this.srvStatus.Width = 100;
            // 
            // srvType
            // 
            this.srvType.Text = "Тип запуска";
            this.srvType.Width = 153;
            // 
            // PrcTimer
            // 
            this.PrcTimer.Interval = 1000;
            this.PrcTimer.Tick += new System.EventHandler(this.PrcTimer_Tick);
            // 
            // CPUTimer
            // 
            this.CPUTimer.Interval = 1000;
            this.CPUTimer.Tick += new System.EventHandler(this.CPUTimer_Tick);
            // 
            // RAMTimer
            // 
            this.RAMTimer.Enabled = true;
            this.RAMTimer.Interval = 1000;
            this.RAMTimer.Tick += new System.EventHandler(this.RAMTimer_Tick);
            // 
            // ProcessContextMenu
            // 
            this.ProcessContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePrcMItem,
            this.suspendPrcMItem,
            this.criticalPrcMItem,
            this.separatorMItem,
            this.addonMItem,
            this.prcPathMItem,
            this.infoPrcMItem});
            this.ProcessContextMenu.Name = "ProcessContextMenu";
            this.ProcessContextMenu.Size = new System.Drawing.Size(237, 142);
            // 
            // deletePrcMItem
            // 
            this.deletePrcMItem.Name = "deletePrcMItem";
            this.deletePrcMItem.ShortcutKeyDisplayString = "Delete";
            this.deletePrcMItem.Size = new System.Drawing.Size(236, 22);
            this.deletePrcMItem.Text = "Завершить";
            this.deletePrcMItem.Click += new System.EventHandler(this.deletePrcMItem_Click);
            // 
            // suspendPrcMItem
            // 
            this.suspendPrcMItem.Name = "suspendPrcMItem";
            this.suspendPrcMItem.ShortcutKeyDisplayString = "Pause";
            this.suspendPrcMItem.Size = new System.Drawing.Size(236, 22);
            this.suspendPrcMItem.Text = "Заморозить";
            this.suspendPrcMItem.Click += new System.EventHandler(this.suspendPrcMItem_Click);
            // 
            // criticalPrcMItem
            // 
            this.criticalPrcMItem.Name = "criticalPrcMItem";
            this.criticalPrcMItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.criticalPrcMItem.Size = new System.Drawing.Size(236, 22);
            this.criticalPrcMItem.Text = "Сделать критическим";
            this.criticalPrcMItem.Click += new System.EventHandler(this.criticalPrcMItem_Click);
            // 
            // separatorMItem
            // 
            this.separatorMItem.Name = "separatorMItem";
            this.separatorMItem.Size = new System.Drawing.Size(233, 6);
            // 
            // addonMItem
            // 
            this.addonMItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.antiGDIMItem});
            this.addonMItem.Name = "addonMItem";
            this.addonMItem.Size = new System.Drawing.Size(236, 22);
            this.addonMItem.Text = "Дополнительно";
            // 
            // antiGDIMItem
            // 
            this.antiGDIMItem.Name = "antiGDIMItem";
            this.antiGDIMItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.antiGDIMItem.Size = new System.Drawing.Size(157, 22);
            this.antiGDIMItem.Text = "AntiGDI";
            this.antiGDIMItem.Click += new System.EventHandler(this.antiGDIMItem_Click);
            // 
            // prcPathMItem
            // 
            this.prcPathMItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.prcPathMItem.Name = "prcPathMItem";
            this.prcPathMItem.Size = new System.Drawing.Size(236, 22);
            this.prcPathMItem.Text = "Расположение файла";
            this.prcPathMItem.Click += new System.EventHandler(this.prcPathMItem_Click);
            // 
            // infoPrcMItem
            // 
            this.infoPrcMItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.infoPrcMItem.Name = "infoPrcMItem";
            this.infoPrcMItem.Size = new System.Drawing.Size(236, 22);
            this.infoPrcMItem.Text = "Свойства";
            this.infoPrcMItem.Click += new System.EventHandler(this.infoPrcMItem_Click);
            // 
            // TopMostTimer
            // 
            this.TopMostTimer.Interval = 1;
            this.TopMostTimer.Tick += new System.EventHandler(this.TopMostTimer_Tick);
            // 
            // CheckMinimaze
            // 
            this.CheckMinimaze.Interval = 1;
            this.CheckMinimaze.Tick += new System.EventHandler(this.CheckMinimaze_Tick);
            // 
            // ServiceContextMenu
            // 
            this.ServiceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runSrvMItem,
            this.stopSrvMItem,
            this.deleteSrvMItem});
            this.ServiceContextMenu.Name = "ServiceContextMenu";
            this.ServiceContextMenu.Size = new System.Drawing.Size(139, 70);
            // 
            // runSrvMItem
            // 
            this.runSrvMItem.Name = "runSrvMItem";
            this.runSrvMItem.Size = new System.Drawing.Size(138, 22);
            this.runSrvMItem.Text = "Запустить";
            this.runSrvMItem.Click += new System.EventHandler(this.runSrvMItem_Click);
            // 
            // stopSrvMItem
            // 
            this.stopSrvMItem.Name = "stopSrvMItem";
            this.stopSrvMItem.Size = new System.Drawing.Size(138, 22);
            this.stopSrvMItem.Text = "Остановить";
            this.stopSrvMItem.Click += new System.EventHandler(this.stopSrvMItem_Click);
            // 
            // deleteSrvMItem
            // 
            this.deleteSrvMItem.Name = "deleteSrvMItem";
            this.deleteSrvMItem.Size = new System.Drawing.Size(138, 22);
            this.deleteSrvMItem.Text = "Удалить";
            this.deleteSrvMItem.Click += new System.EventHandler(this.deleteSrvMItem_Click);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 546);
            this.Controls.Add(this.ManagerMode);
            this.Controls.Add(this.ManagerMenuStrip);
            this.Controls.Add(this.ManagerMenu);
            this.Controls.Add(this.ManagerStatusStrip);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "TaskManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskManager_FormClosing);
            this.Shown += new System.EventHandler(this.TaskManager_Shown);
            this.ManagerStatusStrip.ResumeLayout(false);
            this.ManagerStatusStrip.PerformLayout();
            this.ManagerMenu.ResumeLayout(false);
            this.ManagerMenu.PerformLayout();
            this.ManagerMenuStrip.ResumeLayout(false);
            this.ManagerMenuStrip.PerformLayout();
            this.ManagerMode.ResumeLayout(false);
            this.TaskMgrPage.ResumeLayout(false);
            this.ServicesPage.ResumeLayout(false);
            this.ProcessContextMenu.ResumeLayout(false);
            this.ServiceContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ManagerStatusStrip;
        private System.Windows.Forms.MenuStrip ManagerMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem BackToMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStrip;
        private System.Windows.Forms.ToolStrip ManagerMenuStrip;
        private System.Windows.Forms.TabControl ManagerMode;
        private System.Windows.Forms.TabPage TaskMgrPage;
        private System.Windows.Forms.TabPage ServicesPage;
        private System.Windows.Forms.ToolStripButton RefreshMenuBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TerminateMenuBtn;
        private System.Windows.Forms.ToolStripButton SuspendMenuBtn;
        private System.Windows.Forms.ToolStripButton ResumeMenuBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CriticalMenuBtn;
        private System.Windows.Forms.ToolStripButton UncriticalMenuBtn;
        private System.Windows.Forms.ToolStripStatusLabel CPUSSLabel;
        private System.Windows.Forms.ToolStripStatusLabel RAMSSLabel;
        private System.Windows.Forms.ToolStripStatusLabel ProcessesSSLabel;
        private System.Windows.Forms.ListView TMView;
        private System.Windows.Forms.ColumnHeader ProcessColumn;
        private System.Windows.Forms.ColumnHeader IdColumn;
        private System.Windows.Forms.ColumnHeader StatusColumn;
        private System.Windows.Forms.ColumnHeader UserColumn;
        private System.Windows.Forms.ColumnHeader CriticalColumn;
        private System.Windows.Forms.ColumnHeader DescriptionColumn;
        private System.Windows.Forms.ListView ServiceView;
        private System.Windows.Forms.ColumnHeader srvName;
        private System.Windows.Forms.ColumnHeader srvDescription;
        private System.Windows.Forms.ColumnHeader srvStatus;
        private System.Windows.Forms.ColumnHeader srvType;
        private System.Windows.Forms.Timer PrcTimer;
        private System.Windows.Forms.Timer CPUTimer;
        private System.Windows.Forms.Timer RAMTimer;
        private System.Windows.Forms.ContextMenuStrip ProcessContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deletePrcMItem;
        private System.Windows.Forms.ToolStripMenuItem suspendPrcMItem;
        private System.Windows.Forms.ToolStripMenuItem criticalPrcMItem;
        private System.Windows.Forms.ToolStripSeparator separatorMItem;
        private System.Windows.Forms.ToolStripMenuItem addonMItem;
        private System.Windows.Forms.ToolStripMenuItem antiGDIMItem;
        private System.Windows.Forms.ToolStripMenuItem prcPathMItem;
        private System.Windows.Forms.ToolStripMenuItem infoPrcMItem;
        private System.Windows.Forms.ToolStripMenuItem addonStripItem;
        private System.Windows.Forms.ToolStripMenuItem antiGDIStripItem;
        private System.Windows.Forms.ToolStripMenuItem settingsStripItem;
        private System.Windows.Forms.ToolStripMenuItem autoCheckPrcStripItem;
        private System.Windows.Forms.ToolStripMenuItem topMostStripItem;
        private System.Windows.Forms.ToolStripMenuItem noHiddenFormStripItem;
        private System.Windows.Forms.ToolStripMenuItem uncriticalPrcStripItem;
        private System.Windows.Forms.Timer TopMostTimer;
        private System.Windows.Forms.Timer CheckMinimaze;
        private System.Windows.Forms.ToolStripMenuItem runStripItem;
        private System.Windows.Forms.ContextMenuStrip ServiceContextMenu;
        private System.Windows.Forms.ToolStripMenuItem runSrvMItem;
        private System.Windows.Forms.ToolStripMenuItem stopSrvMItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSrvMItem;
        private System.Windows.Forms.ToolStripStatusLabel addonStripLabel;
    }
}