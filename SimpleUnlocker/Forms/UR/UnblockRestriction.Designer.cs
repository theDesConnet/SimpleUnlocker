
namespace SU.Forms
{
    partial class UnblockRestriction
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
            this.AddonMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.useCustomRestrictionsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateAssocStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFileTypeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomRestrictionToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.URStatus = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.URControl = new System.Windows.Forms.TabControl();
            this.URPage = new System.Windows.Forms.TabPage();
            this.URTypeControl = new System.Windows.Forms.TabControl();
            this.URScanPage = new System.Windows.Forms.TabPage();
            this.ResultBox = new System.Windows.Forms.GroupBox();
            this.ResultView = new System.Windows.Forms.ListView();
            this.RestrictionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionRestricion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PathRestriction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AURControlPanel = new System.Windows.Forms.Panel();
            this.StartScanButton = new System.Windows.Forms.Button();
            this.AURCheckbox = new System.Windows.Forms.CheckBox();
            this.URManualPage = new System.Windows.Forms.TabPage();
            this.BasicRestrictionsGroupBox = new System.Windows.Forms.GroupBox();
            this.BasicRestrictionList = new System.Windows.Forms.ListView();
            this.BRMColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BRDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MURPanel = new System.Windows.Forms.Panel();
            this.SelectAllBox = new System.Windows.Forms.CheckBox();
            this.ManualUnlockBtn = new System.Windows.Forms.Button();
            this.AssocPage = new System.Windows.Forms.TabPage();
            this.AssocControl = new System.Windows.Forms.TabControl();
            this.AssocTab = new System.Windows.Forms.TabPage();
            this.AssocBox = new System.Windows.Forms.GroupBox();
            this.AssocView = new System.Windows.Forms.ListView();
            this.AssocNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AssocFileTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShellOpenCommandColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileTypesTab = new System.Windows.Forms.TabPage();
            this.FileTypesBox = new System.Windows.Forms.GroupBox();
            this.FileTypeView = new System.Windows.Forms.ListView();
            this.fTypeNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fTypeDefaultIconColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fTypeDescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fTypeOpenDefaultColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScanResultContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.URToolMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenRegistryToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AssocContextList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteAssocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeAssocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAssocMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileTypeContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delFTItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chgFTItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refFTItem = new System.Windows.Forms.ToolStripMenuItem();
            this.URMenu.SuspendLayout();
            this.URStatus.SuspendLayout();
            this.URControl.SuspendLayout();
            this.URPage.SuspendLayout();
            this.URTypeControl.SuspendLayout();
            this.URScanPage.SuspendLayout();
            this.ResultBox.SuspendLayout();
            this.AURControlPanel.SuspendLayout();
            this.URManualPage.SuspendLayout();
            this.BasicRestrictionsGroupBox.SuspendLayout();
            this.MURPanel.SuspendLayout();
            this.AssocPage.SuspendLayout();
            this.AssocControl.SuspendLayout();
            this.AssocTab.SuspendLayout();
            this.AssocBox.SuspendLayout();
            this.FileTypesTab.SuspendLayout();
            this.FileTypesBox.SuspendLayout();
            this.ScanResultContext.SuspendLayout();
            this.AssocContextList.SuspendLayout();
            this.FileTypeContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // URMenu
            // 
            this.URMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip,
            this.AddonMenuStrip});
            this.URMenu.Location = new System.Drawing.Point(0, 0);
            this.URMenu.Name = "URMenu";
            this.URMenu.Size = new System.Drawing.Size(955, 24);
            this.URMenu.TabIndex = 1;
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
            // AddonMenuStrip
            // 
            this.AddonMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useCustomRestrictionsToolStrip,
            this.CreateAssocStrip,
            this.CreateFileTypeStrip,
            this.createCustomRestrictionToolStrip});
            this.AddonMenuStrip.Name = "AddonMenuStrip";
            this.AddonMenuStrip.Size = new System.Drawing.Size(107, 20);
            this.AddonMenuStrip.Text = "Дополнительно";
            // 
            // useCustomRestrictionsToolStrip
            // 
            this.useCustomRestrictionsToolStrip.CheckOnClick = true;
            this.useCustomRestrictionsToolStrip.Name = "useCustomRestrictionsToolStrip";
            this.useCustomRestrictionsToolStrip.Size = new System.Drawing.Size(290, 22);
            this.useCustomRestrictionsToolStrip.Text = "Использовать кастомные ограничения";
            this.useCustomRestrictionsToolStrip.Click += new System.EventHandler(this.useCustomRestrictionsToolStrip_Click);
            // 
            // CreateAssocStrip
            // 
            this.CreateAssocStrip.Name = "CreateAssocStrip";
            this.CreateAssocStrip.Size = new System.Drawing.Size(290, 22);
            this.CreateAssocStrip.Text = "Создать резервную ассоциацию";
            this.CreateAssocStrip.Click += new System.EventHandler(this.CreateAssocStrip_Click);
            // 
            // CreateFileTypeStrip
            // 
            this.CreateFileTypeStrip.Name = "CreateFileTypeStrip";
            this.CreateFileTypeStrip.Size = new System.Drawing.Size(290, 22);
            this.CreateFileTypeStrip.Text = "Создать резервный тип файла";
            this.CreateFileTypeStrip.Click += new System.EventHandler(this.CreateFileTypeStrip_Click);
            // 
            // createCustomRestrictionToolStrip
            // 
            this.createCustomRestrictionToolStrip.Name = "createCustomRestrictionToolStrip";
            this.createCustomRestrictionToolStrip.Size = new System.Drawing.Size(290, 22);
            this.createCustomRestrictionToolStrip.Text = "Создать кастомное ограничение";
            this.createCustomRestrictionToolStrip.Click += new System.EventHandler(this.createCustomRestrictionToolStrip_Click);
            // 
            // URStatus
            // 
            this.URStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.URStatus.Location = new System.Drawing.Point(0, 549);
            this.URStatus.Name = "URStatus";
            this.URStatus.Size = new System.Drawing.Size(955, 24);
            this.URStatus.SizingGrip = false;
            this.URStatus.TabIndex = 2;
            // 
            // StatusText
            // 
            this.StatusText.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(264, 19);
            this.StatusText.Text = "Состояние: Ожидание действий пользователя";
            // 
            // URControl
            // 
            this.URControl.Controls.Add(this.URPage);
            this.URControl.Controls.Add(this.AssocPage);
            this.URControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.URControl.Location = new System.Drawing.Point(0, 24);
            this.URControl.Name = "URControl";
            this.URControl.SelectedIndex = 0;
            this.URControl.Size = new System.Drawing.Size(955, 525);
            this.URControl.TabIndex = 3;
            // 
            // URPage
            // 
            this.URPage.Controls.Add(this.URTypeControl);
            this.URPage.Location = new System.Drawing.Point(4, 22);
            this.URPage.Name = "URPage";
            this.URPage.Padding = new System.Windows.Forms.Padding(3);
            this.URPage.Size = new System.Drawing.Size(947, 499);
            this.URPage.TabIndex = 0;
            this.URPage.Text = "Разблокировка ограничений";
            this.URPage.UseVisualStyleBackColor = true;
            // 
            // URTypeControl
            // 
            this.URTypeControl.Controls.Add(this.URScanPage);
            this.URTypeControl.Controls.Add(this.URManualPage);
            this.URTypeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.URTypeControl.Location = new System.Drawing.Point(3, 3);
            this.URTypeControl.Name = "URTypeControl";
            this.URTypeControl.SelectedIndex = 0;
            this.URTypeControl.Size = new System.Drawing.Size(941, 493);
            this.URTypeControl.TabIndex = 0;
            // 
            // URScanPage
            // 
            this.URScanPage.Controls.Add(this.ResultBox);
            this.URScanPage.Controls.Add(this.AURControlPanel);
            this.URScanPage.Location = new System.Drawing.Point(4, 22);
            this.URScanPage.Name = "URScanPage";
            this.URScanPage.Padding = new System.Windows.Forms.Padding(3);
            this.URScanPage.Size = new System.Drawing.Size(933, 467);
            this.URScanPage.TabIndex = 0;
            this.URScanPage.Text = "Сканирование";
            this.URScanPage.UseVisualStyleBackColor = true;
            // 
            // ResultBox
            // 
            this.ResultBox.Controls.Add(this.ResultView);
            this.ResultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultBox.Location = new System.Drawing.Point(3, 3);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(927, 434);
            this.ResultBox.TabIndex = 6;
            this.ResultBox.TabStop = false;
            this.ResultBox.Text = "Результаты сканирования";
            // 
            // ResultView
            // 
            this.ResultView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RestrictionName,
            this.DescriptionRestricion,
            this.PathRestriction});
            this.ResultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultView.FullRowSelect = true;
            this.ResultView.GridLines = true;
            this.ResultView.HideSelection = false;
            this.ResultView.Location = new System.Drawing.Point(3, 16);
            this.ResultView.Name = "ResultView";
            this.ResultView.Size = new System.Drawing.Size(921, 415);
            this.ResultView.TabIndex = 0;
            this.ResultView.UseCompatibleStateImageBehavior = false;
            this.ResultView.View = System.Windows.Forms.View.Details;
            this.ResultView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ResultView_MouseClick);
            // 
            // RestrictionName
            // 
            this.RestrictionName.Text = "Ограничение";
            this.RestrictionName.Width = 159;
            // 
            // DescriptionRestricion
            // 
            this.DescriptionRestricion.Text = "Описание ограничения";
            this.DescriptionRestricion.Width = 422;
            // 
            // PathRestriction
            // 
            this.PathRestriction.Text = "Путь";
            this.PathRestriction.Width = 330;
            // 
            // AURControlPanel
            // 
            this.AURControlPanel.Controls.Add(this.StartScanButton);
            this.AURControlPanel.Controls.Add(this.AURCheckbox);
            this.AURControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AURControlPanel.Location = new System.Drawing.Point(3, 437);
            this.AURControlPanel.Name = "AURControlPanel";
            this.AURControlPanel.Size = new System.Drawing.Size(927, 27);
            this.AURControlPanel.TabIndex = 0;
            // 
            // StartScanButton
            // 
            this.StartScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartScanButton.Location = new System.Drawing.Point(770, 1);
            this.StartScanButton.Name = "StartScanButton";
            this.StartScanButton.Size = new System.Drawing.Size(157, 25);
            this.StartScanButton.TabIndex = 1;
            this.StartScanButton.Text = "Начать сканирование";
            this.StartScanButton.UseVisualStyleBackColor = true;
            this.StartScanButton.Click += new System.EventHandler(this.StartScanButton_Click);
            // 
            // AURCheckbox
            // 
            this.AURCheckbox.AutoSize = true;
            this.AURCheckbox.Location = new System.Drawing.Point(3, 6);
            this.AURCheckbox.Name = "AURCheckbox";
            this.AURCheckbox.Size = new System.Drawing.Size(258, 17);
            this.AURCheckbox.TabIndex = 0;
            this.AURCheckbox.Text = "Автоматическая разблокировка ограничений";
            this.AURCheckbox.UseVisualStyleBackColor = true;
            // 
            // URManualPage
            // 
            this.URManualPage.Controls.Add(this.BasicRestrictionsGroupBox);
            this.URManualPage.Controls.Add(this.MURPanel);
            this.URManualPage.Location = new System.Drawing.Point(4, 22);
            this.URManualPage.Name = "URManualPage";
            this.URManualPage.Padding = new System.Windows.Forms.Padding(3);
            this.URManualPage.Size = new System.Drawing.Size(933, 467);
            this.URManualPage.TabIndex = 1;
            this.URManualPage.Text = "Ручная разблокировка";
            this.URManualPage.UseVisualStyleBackColor = true;
            // 
            // BasicRestrictionsGroupBox
            // 
            this.BasicRestrictionsGroupBox.Controls.Add(this.BasicRestrictionList);
            this.BasicRestrictionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicRestrictionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.BasicRestrictionsGroupBox.Name = "BasicRestrictionsGroupBox";
            this.BasicRestrictionsGroupBox.Size = new System.Drawing.Size(927, 434);
            this.BasicRestrictionsGroupBox.TabIndex = 8;
            this.BasicRestrictionsGroupBox.TabStop = false;
            this.BasicRestrictionsGroupBox.Text = "Список ограничений";
            // 
            // BasicRestrictionList
            // 
            this.BasicRestrictionList.CheckBoxes = true;
            this.BasicRestrictionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BRMColumn,
            this.BRDColumn});
            this.BasicRestrictionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicRestrictionList.FullRowSelect = true;
            this.BasicRestrictionList.GridLines = true;
            this.BasicRestrictionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.BasicRestrictionList.HideSelection = false;
            this.BasicRestrictionList.Location = new System.Drawing.Point(3, 16);
            this.BasicRestrictionList.Name = "BasicRestrictionList";
            this.BasicRestrictionList.Size = new System.Drawing.Size(921, 415);
            this.BasicRestrictionList.TabIndex = 0;
            this.BasicRestrictionList.UseCompatibleStateImageBehavior = false;
            this.BasicRestrictionList.View = System.Windows.Forms.View.Details;
            this.BasicRestrictionList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.BasicRestrictionList_ItemChecked);
            // 
            // BRMColumn
            // 
            this.BRMColumn.Text = "Ограничение";
            this.BRMColumn.Width = 159;
            // 
            // BRDColumn
            // 
            this.BRDColumn.Text = "Описание ограничения";
            this.BRDColumn.Width = 599;
            // 
            // MURPanel
            // 
            this.MURPanel.Controls.Add(this.SelectAllBox);
            this.MURPanel.Controls.Add(this.ManualUnlockBtn);
            this.MURPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MURPanel.Location = new System.Drawing.Point(3, 437);
            this.MURPanel.Name = "MURPanel";
            this.MURPanel.Size = new System.Drawing.Size(927, 27);
            this.MURPanel.TabIndex = 7;
            // 
            // SelectAllBox
            // 
            this.SelectAllBox.AutoSize = true;
            this.SelectAllBox.Location = new System.Drawing.Point(3, 6);
            this.SelectAllBox.Name = "SelectAllBox";
            this.SelectAllBox.Size = new System.Drawing.Size(91, 17);
            this.SelectAllBox.TabIndex = 2;
            this.SelectAllBox.Text = "Выбрать все";
            this.SelectAllBox.UseVisualStyleBackColor = true;
            this.SelectAllBox.CheckedChanged += new System.EventHandler(this.SelectAllBox_CheckedChanged);
            // 
            // ManualUnlockBtn
            // 
            this.ManualUnlockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ManualUnlockBtn.Enabled = false;
            this.ManualUnlockBtn.Location = new System.Drawing.Point(672, 1);
            this.ManualUnlockBtn.Name = "ManualUnlockBtn";
            this.ManualUnlockBtn.Size = new System.Drawing.Size(255, 25);
            this.ManualUnlockBtn.TabIndex = 1;
            this.ManualUnlockBtn.Text = "Разблокировать выбранные ограничения";
            this.ManualUnlockBtn.UseVisualStyleBackColor = true;
            this.ManualUnlockBtn.Click += new System.EventHandler(this.ManualUnlockBtn_Click);
            // 
            // AssocPage
            // 
            this.AssocPage.Controls.Add(this.AssocControl);
            this.AssocPage.Location = new System.Drawing.Point(4, 22);
            this.AssocPage.Name = "AssocPage";
            this.AssocPage.Padding = new System.Windows.Forms.Padding(3);
            this.AssocPage.Size = new System.Drawing.Size(947, 499);
            this.AssocPage.TabIndex = 1;
            this.AssocPage.Text = "Восстановление ассоциаций";
            this.AssocPage.UseVisualStyleBackColor = true;
            // 
            // AssocControl
            // 
            this.AssocControl.Controls.Add(this.AssocTab);
            this.AssocControl.Controls.Add(this.FileTypesTab);
            this.AssocControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssocControl.Location = new System.Drawing.Point(3, 3);
            this.AssocControl.Name = "AssocControl";
            this.AssocControl.SelectedIndex = 0;
            this.AssocControl.Size = new System.Drawing.Size(941, 493);
            this.AssocControl.TabIndex = 0;
            // 
            // AssocTab
            // 
            this.AssocTab.Controls.Add(this.AssocBox);
            this.AssocTab.Location = new System.Drawing.Point(4, 22);
            this.AssocTab.Name = "AssocTab";
            this.AssocTab.Padding = new System.Windows.Forms.Padding(3);
            this.AssocTab.Size = new System.Drawing.Size(933, 467);
            this.AssocTab.TabIndex = 0;
            this.AssocTab.Text = "Ассоциации";
            this.AssocTab.UseVisualStyleBackColor = true;
            // 
            // AssocBox
            // 
            this.AssocBox.Controls.Add(this.AssocView);
            this.AssocBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssocBox.Location = new System.Drawing.Point(3, 3);
            this.AssocBox.Name = "AssocBox";
            this.AssocBox.Size = new System.Drawing.Size(927, 461);
            this.AssocBox.TabIndex = 1;
            this.AssocBox.TabStop = false;
            this.AssocBox.Text = "Ассоциации";
            // 
            // AssocView
            // 
            this.AssocView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AssocNameColumn,
            this.AssocFileTypeColumn,
            this.ShellOpenCommandColumn});
            this.AssocView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssocView.FullRowSelect = true;
            this.AssocView.GridLines = true;
            this.AssocView.HideSelection = false;
            this.AssocView.Location = new System.Drawing.Point(3, 16);
            this.AssocView.Name = "AssocView";
            this.AssocView.Size = new System.Drawing.Size(921, 442);
            this.AssocView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.AssocView.TabIndex = 0;
            this.AssocView.UseCompatibleStateImageBehavior = false;
            this.AssocView.View = System.Windows.Forms.View.Details;
            this.AssocView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AssocView_MouseClick);
            this.AssocView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AssocView_MouseDoubleClick);
            // 
            // AssocNameColumn
            // 
            this.AssocNameColumn.Text = "Расширение файла";
            this.AssocNameColumn.Width = 130;
            // 
            // AssocFileTypeColumn
            // 
            this.AssocFileTypeColumn.Text = "Тип файла";
            this.AssocFileTypeColumn.Width = 189;
            // 
            // ShellOpenCommandColumn
            // 
            this.ShellOpenCommandColumn.Text = "Команда";
            this.ShellOpenCommandColumn.Width = 455;
            // 
            // FileTypesTab
            // 
            this.FileTypesTab.Controls.Add(this.FileTypesBox);
            this.FileTypesTab.Location = new System.Drawing.Point(4, 22);
            this.FileTypesTab.Name = "FileTypesTab";
            this.FileTypesTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileTypesTab.Size = new System.Drawing.Size(933, 467);
            this.FileTypesTab.TabIndex = 1;
            this.FileTypesTab.Text = "Типы файлов";
            this.FileTypesTab.UseVisualStyleBackColor = true;
            // 
            // FileTypesBox
            // 
            this.FileTypesBox.Controls.Add(this.FileTypeView);
            this.FileTypesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTypesBox.Location = new System.Drawing.Point(3, 3);
            this.FileTypesBox.Name = "FileTypesBox";
            this.FileTypesBox.Size = new System.Drawing.Size(927, 461);
            this.FileTypesBox.TabIndex = 0;
            this.FileTypesBox.TabStop = false;
            this.FileTypesBox.Text = "Типы файлов";
            // 
            // FileTypeView
            // 
            this.FileTypeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fTypeNameColumn,
            this.fTypeDefaultIconColumn,
            this.fTypeDescriptionColumn,
            this.fTypeOpenDefaultColumn});
            this.FileTypeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileTypeView.FullRowSelect = true;
            this.FileTypeView.GridLines = true;
            this.FileTypeView.HideSelection = false;
            this.FileTypeView.Location = new System.Drawing.Point(3, 16);
            this.FileTypeView.Name = "FileTypeView";
            this.FileTypeView.Size = new System.Drawing.Size(921, 442);
            this.FileTypeView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.FileTypeView.TabIndex = 1;
            this.FileTypeView.UseCompatibleStateImageBehavior = false;
            this.FileTypeView.View = System.Windows.Forms.View.Details;
            this.FileTypeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FileTypeView_MouseClick);
            this.FileTypeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FileTypeView_MouseDoubleClick);
            // 
            // fTypeNameColumn
            // 
            this.fTypeNameColumn.Text = "Тип файла";
            this.fTypeNameColumn.Width = 181;
            // 
            // fTypeDefaultIconColumn
            // 
            this.fTypeDefaultIconColumn.Text = "Иконка";
            this.fTypeDefaultIconColumn.Width = 210;
            // 
            // fTypeDescriptionColumn
            // 
            this.fTypeDescriptionColumn.Text = "Описание";
            this.fTypeDescriptionColumn.Width = 191;
            // 
            // fTypeOpenDefaultColumn
            // 
            this.fTypeOpenDefaultColumn.Text = "Команда по умолчанию";
            this.fTypeOpenDefaultColumn.Width = 332;
            // 
            // ScanResultContext
            // 
            this.ScanResultContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.URToolMenuStrip,
            this.OpenRegistryToolStripMenu});
            this.ScanResultContext.Name = "ScanResultContext";
            this.ScanResultContext.Size = new System.Drawing.Size(239, 48);
            // 
            // URToolMenuStrip
            // 
            this.URToolMenuStrip.Name = "URToolMenuStrip";
            this.URToolMenuStrip.Size = new System.Drawing.Size(238, 22);
            this.URToolMenuStrip.Text = "Разблокировать ограничение";
            this.URToolMenuStrip.Click += new System.EventHandler(this.URToolMenuStrip_Click);
            // 
            // OpenRegistryToolStripMenu
            // 
            this.OpenRegistryToolStripMenu.Name = "OpenRegistryToolStripMenu";
            this.OpenRegistryToolStripMenu.Size = new System.Drawing.Size(238, 22);
            this.OpenRegistryToolStripMenu.Text = "Открыть в реестре";
            this.OpenRegistryToolStripMenu.Click += new System.EventHandler(this.OpenRegistryToolStripMenu_Click);
            // 
            // AssocContextList
            // 
            this.AssocContextList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAssocMenuItem,
            this.changeAssocMenuItem,
            this.refreshAssocMenuItem});
            this.AssocContextList.Name = "AssocContextList";
            this.AssocContextList.Size = new System.Drawing.Size(129, 70);
            // 
            // deleteAssocMenuItem
            // 
            this.deleteAssocMenuItem.Name = "deleteAssocMenuItem";
            this.deleteAssocMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteAssocMenuItem.Text = "Удалить";
            this.deleteAssocMenuItem.Click += new System.EventHandler(this.deleteAssocMenuItem_Click);
            // 
            // changeAssocMenuItem
            // 
            this.changeAssocMenuItem.Name = "changeAssocMenuItem";
            this.changeAssocMenuItem.Size = new System.Drawing.Size(128, 22);
            this.changeAssocMenuItem.Text = "Изменить";
            this.changeAssocMenuItem.Click += new System.EventHandler(this.changeAssocMenuItem_Click);
            // 
            // refreshAssocMenuItem
            // 
            this.refreshAssocMenuItem.Name = "refreshAssocMenuItem";
            this.refreshAssocMenuItem.Size = new System.Drawing.Size(128, 22);
            this.refreshAssocMenuItem.Text = "Обновить";
            this.refreshAssocMenuItem.Click += new System.EventHandler(this.refreshAssocMenuItem_Click);
            // 
            // FileTypeContext
            // 
            this.FileTypeContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delFTItem,
            this.chgFTItem,
            this.refFTItem});
            this.FileTypeContext.Name = "AssocContextList";
            this.FileTypeContext.Size = new System.Drawing.Size(129, 70);
            // 
            // delFTItem
            // 
            this.delFTItem.Name = "delFTItem";
            this.delFTItem.Size = new System.Drawing.Size(128, 22);
            this.delFTItem.Text = "Удалить";
            this.delFTItem.Click += new System.EventHandler(this.delFTItem_Click);
            // 
            // chgFTItem
            // 
            this.chgFTItem.Name = "chgFTItem";
            this.chgFTItem.Size = new System.Drawing.Size(128, 22);
            this.chgFTItem.Text = "Изменить";
            this.chgFTItem.Click += new System.EventHandler(this.chgFTItem_Click);
            // 
            // refFTItem
            // 
            this.refFTItem.Name = "refFTItem";
            this.refFTItem.Size = new System.Drawing.Size(128, 22);
            this.refFTItem.Text = "Обновить";
            this.refFTItem.Click += new System.EventHandler(this.refFTItem_Click);
            // 
            // UnblockRestriction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 573);
            this.Controls.Add(this.URControl);
            this.Controls.Add(this.URStatus);
            this.Controls.Add(this.URMenu);
            this.MainMenuStrip = this.URMenu;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "UnblockRestriction";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UnblockRestriction_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnblockRestriction_FormClosed);
            this.Load += new System.EventHandler(this.UnblockRestriction_Load);
            this.URMenu.ResumeLayout(false);
            this.URMenu.PerformLayout();
            this.URStatus.ResumeLayout(false);
            this.URStatus.PerformLayout();
            this.URControl.ResumeLayout(false);
            this.URPage.ResumeLayout(false);
            this.URTypeControl.ResumeLayout(false);
            this.URScanPage.ResumeLayout(false);
            this.ResultBox.ResumeLayout(false);
            this.AURControlPanel.ResumeLayout(false);
            this.AURControlPanel.PerformLayout();
            this.URManualPage.ResumeLayout(false);
            this.BasicRestrictionsGroupBox.ResumeLayout(false);
            this.MURPanel.ResumeLayout(false);
            this.MURPanel.PerformLayout();
            this.AssocPage.ResumeLayout(false);
            this.AssocControl.ResumeLayout(false);
            this.AssocTab.ResumeLayout(false);
            this.AssocBox.ResumeLayout(false);
            this.FileTypesTab.ResumeLayout(false);
            this.FileTypesBox.ResumeLayout(false);
            this.ScanResultContext.ResumeLayout(false);
            this.AssocContextList.ResumeLayout(false);
            this.FileTypeContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip URMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddonMenuStrip;
        private System.Windows.Forms.StatusStrip URStatus;
        private System.Windows.Forms.TabControl URControl;
        private System.Windows.Forms.TabPage URPage;
        private System.Windows.Forms.TabControl URTypeControl;
        private System.Windows.Forms.TabPage URScanPage;
        private System.Windows.Forms.TabPage URManualPage;
        private System.Windows.Forms.TabPage AssocPage;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.GroupBox ResultBox;
        private System.Windows.Forms.ListView ResultView;
        private System.Windows.Forms.ColumnHeader RestrictionName;
        private System.Windows.Forms.ColumnHeader DescriptionRestricion;
        private System.Windows.Forms.ColumnHeader PathRestriction;
        private System.Windows.Forms.Panel AURControlPanel;
        private System.Windows.Forms.Button StartScanButton;
        private System.Windows.Forms.CheckBox AURCheckbox;
        private System.Windows.Forms.ToolStripMenuItem BackToMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStrip;
        private System.Windows.Forms.ToolStripMenuItem CreateAssocStrip;
        private System.Windows.Forms.ContextMenuStrip ScanResultContext;
        private System.Windows.Forms.ToolStripMenuItem URToolMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenRegistryToolStripMenu;
        private System.Windows.Forms.GroupBox BasicRestrictionsGroupBox;
        private System.Windows.Forms.ListView BasicRestrictionList;
        private System.Windows.Forms.ColumnHeader BRMColumn;
        private System.Windows.Forms.ColumnHeader BRDColumn;
        private System.Windows.Forms.Panel MURPanel;
        private System.Windows.Forms.Button ManualUnlockBtn;
        private System.Windows.Forms.CheckBox SelectAllBox;
        private System.Windows.Forms.ToolStripMenuItem CreateFileTypeStrip;
        private System.Windows.Forms.ContextMenuStrip AssocContextList;
        private System.Windows.Forms.ToolStripMenuItem deleteAssocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAssocMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshAssocMenuItem;
        private System.Windows.Forms.TabControl AssocControl;
        private System.Windows.Forms.TabPage AssocTab;
        private System.Windows.Forms.GroupBox AssocBox;
        private System.Windows.Forms.ListView AssocView;
        private System.Windows.Forms.ColumnHeader AssocNameColumn;
        private System.Windows.Forms.ColumnHeader AssocFileTypeColumn;
        private System.Windows.Forms.ColumnHeader ShellOpenCommandColumn;
        private System.Windows.Forms.TabPage FileTypesTab;
        private System.Windows.Forms.GroupBox FileTypesBox;
        private System.Windows.Forms.ListView FileTypeView;
        private System.Windows.Forms.ColumnHeader fTypeNameColumn;
        private System.Windows.Forms.ColumnHeader fTypeDescriptionColumn;
        private System.Windows.Forms.ColumnHeader fTypeOpenDefaultColumn;
        private System.Windows.Forms.ColumnHeader fTypeDefaultIconColumn;
        private System.Windows.Forms.ContextMenuStrip FileTypeContext;
        private System.Windows.Forms.ToolStripMenuItem delFTItem;
        private System.Windows.Forms.ToolStripMenuItem chgFTItem;
        private System.Windows.Forms.ToolStripMenuItem refFTItem;
        private System.Windows.Forms.ToolStripMenuItem useCustomRestrictionsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem createCustomRestrictionToolStrip;
    }
}