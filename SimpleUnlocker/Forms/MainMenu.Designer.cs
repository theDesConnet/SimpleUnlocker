
namespace SU.Forms
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPanel = new System.Windows.Forms.GroupBox();
            this.APButton = new System.Windows.Forms.Button();
            this.SButton = new System.Windows.Forms.Button();
            this.MBButton = new System.Windows.Forms.Button();
            this.RUButton = new System.Windows.Forms.Button();
            this.ARButton = new System.Windows.Forms.Button();
            this.TMButton = new System.Windows.Forms.Button();
            this.URButton = new System.Windows.Forms.Button();
            this.MenuStatus = new System.Windows.Forms.StatusStrip();
            this.StatusVersionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgName = new System.Windows.Forms.Label();
            this.checkUpdateWorker = new System.ComponentModel.BackgroundWorker();
            this.updaterUnpacker = new System.ComponentModel.BackgroundWorker();
            this.MenuPanel.SuspendLayout();
            this.MenuStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.APButton);
            this.MenuPanel.Controls.Add(this.SButton);
            this.MenuPanel.Controls.Add(this.MBButton);
            this.MenuPanel.Controls.Add(this.RUButton);
            this.MenuPanel.Controls.Add(this.ARButton);
            this.MenuPanel.Controls.Add(this.TMButton);
            this.MenuPanel.Controls.Add(this.URButton);
            this.MenuPanel.Location = new System.Drawing.Point(12, 42);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(452, 164);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.TabStop = false;
            this.MenuPanel.Text = "Меню";
            // 
            // APButton
            // 
            this.APButton.Location = new System.Drawing.Point(230, 132);
            this.APButton.Name = "APButton";
            this.APButton.Size = new System.Drawing.Size(216, 23);
            this.APButton.TabIndex = 6;
            this.APButton.Text = "О программе";
            this.APButton.UseVisualStyleBackColor = true;
            this.APButton.Click += new System.EventHandler(this.APButton_Click);
            // 
            // SButton
            // 
            this.SButton.Location = new System.Drawing.Point(6, 132);
            this.SButton.Name = "SButton";
            this.SButton.Size = new System.Drawing.Size(216, 23);
            this.SButton.TabIndex = 5;
            this.SButton.Text = "Настройки";
            this.SButton.UseVisualStyleBackColor = true;
            this.SButton.Click += new System.EventHandler(this.SButton_Click);
            // 
            // MBButton
            // 
            this.MBButton.Location = new System.Drawing.Point(6, 103);
            this.MBButton.Name = "MBButton";
            this.MBButton.Size = new System.Drawing.Size(440, 23);
            this.MBButton.TabIndex = 4;
            this.MBButton.Text = "Восстановление MBR";
            this.MBButton.UseVisualStyleBackColor = true;
            this.MBButton.Click += new System.EventHandler(this.MBButton_Click);
            // 
            // RUButton
            // 
            this.RUButton.Location = new System.Drawing.Point(230, 61);
            this.RUButton.Name = "RUButton";
            this.RUButton.Size = new System.Drawing.Size(216, 36);
            this.RUButton.TabIndex = 3;
            this.RUButton.Text = "Запуск сторонних утилит";
            this.RUButton.UseVisualStyleBackColor = true;
            this.RUButton.Click += new System.EventHandler(this.RUButton_Click);
            // 
            // ARButton
            // 
            this.ARButton.Location = new System.Drawing.Point(6, 61);
            this.ARButton.Name = "ARButton";
            this.ARButton.Size = new System.Drawing.Size(216, 36);
            this.ARButton.TabIndex = 2;
            this.ARButton.Text = "Автозапуск програм";
            this.ARButton.UseVisualStyleBackColor = true;
            this.ARButton.Click += new System.EventHandler(this.ARButton_Click);
            // 
            // TMButton
            // 
            this.TMButton.Location = new System.Drawing.Point(230, 19);
            this.TMButton.Name = "TMButton";
            this.TMButton.Size = new System.Drawing.Size(216, 36);
            this.TMButton.TabIndex = 1;
            this.TMButton.Text = "Диспетчер задач";
            this.TMButton.UseVisualStyleBackColor = true;
            this.TMButton.Click += new System.EventHandler(this.TMButton_Click);
            // 
            // URButton
            // 
            this.URButton.Location = new System.Drawing.Point(6, 19);
            this.URButton.Name = "URButton";
            this.URButton.Size = new System.Drawing.Size(216, 36);
            this.URButton.TabIndex = 0;
            this.URButton.Text = "Разблокировка ограничений";
            this.URButton.UseVisualStyleBackColor = true;
            this.URButton.Click += new System.EventHandler(this.URButton_Click);
            // 
            // MenuStatus
            // 
            this.MenuStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusVersionLabel});
            this.MenuStatus.Location = new System.Drawing.Point(0, 213);
            this.MenuStatus.Name = "MenuStatus";
            this.MenuStatus.Size = new System.Drawing.Size(476, 24);
            this.MenuStatus.SizingGrip = false;
            this.MenuStatus.TabIndex = 2;
            // 
            // StatusVersionLabel
            // 
            this.StatusVersionLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StatusVersionLabel.Name = "StatusVersionLabel";
            this.StatusVersionLabel.Size = new System.Drawing.Size(89, 19);
            this.StatusVersionLabel.Text = "Версия: 0.0.0.0";
            // 
            // ProgName
            // 
            this.ProgName.AutoSize = true;
            this.ProgName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProgName.Location = new System.Drawing.Point(153, 9);
            this.ProgName.Name = "ProgName";
            this.ProgName.Size = new System.Drawing.Size(165, 30);
            this.ProgName.TabIndex = 3;
            this.ProgName.Text = "SimpleUnlocker";
            // 
            // checkUpdateWorker
            // 
            this.checkUpdateWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkUpdateWorker_DoWork);
            // 
            // updaterUnpacker
            // 
            this.updaterUnpacker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.unpackerWorker_DoWork);
            this.updaterUnpacker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.updaterUnpacker_RunWorkerCompleted);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 237);
            this.Controls.Add(this.ProgName);
            this.Controls.Add(this.MenuStatus);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuStatus.ResumeLayout(false);
            this.MenuStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox MenuPanel;
        private System.Windows.Forms.StatusStrip MenuStatus;
        private System.Windows.Forms.ToolStripStatusLabel StatusVersionLabel;
        private System.Windows.Forms.Button APButton;
        private System.Windows.Forms.Button SButton;
        private System.Windows.Forms.Button MBButton;
        private System.Windows.Forms.Button RUButton;
        private System.Windows.Forms.Button ARButton;
        private System.Windows.Forms.Button TMButton;
        private System.Windows.Forms.Button URButton;
        private System.Windows.Forms.Label ProgName;
        private System.ComponentModel.BackgroundWorker checkUpdateWorker;
        private System.ComponentModel.BackgroundWorker updaterUnpacker;
    }
}

