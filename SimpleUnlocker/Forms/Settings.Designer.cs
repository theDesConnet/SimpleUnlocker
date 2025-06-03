namespace SU.Forms
{
    partial class Settings
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
            this.mainBox = new System.Windows.Forms.GroupBox();
            this.AutoUpdate = new System.Windows.Forms.CheckBox();
            this.RandomWindowName = new System.Windows.Forms.CheckBox();
            this.AlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.actionBox = new System.Windows.Forms.GroupBox();
            this.CloseApp = new System.Windows.Forms.CheckBox();
            this.MainMenuClose = new System.Windows.Forms.CheckBox();
            this.mainBox.SuspendLayout();
            this.actionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Controls.Add(this.AutoUpdate);
            this.mainBox.Controls.Add(this.RandomWindowName);
            this.mainBox.Controls.Add(this.AlwaysOnTop);
            this.mainBox.Location = new System.Drawing.Point(12, 45);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(341, 90);
            this.mainBox.TabIndex = 0;
            this.mainBox.TabStop = false;
            this.mainBox.Text = "Основные";
            // 
            // AutoUpdate
            // 
            this.AutoUpdate.AutoSize = true;
            this.AutoUpdate.Location = new System.Drawing.Point(6, 18);
            this.AutoUpdate.Name = "AutoUpdate";
            this.AutoUpdate.Size = new System.Drawing.Size(288, 17);
            this.AutoUpdate.TabIndex = 2;
            this.AutoUpdate.Text = "Автоматически проверять обновления при запуске";
            this.AutoUpdate.UseVisualStyleBackColor = true;
            this.AutoUpdate.CheckedChanged += new System.EventHandler(this.AutoUpdate_CheckedChanged);
            // 
            // RandomWindowName
            // 
            this.RandomWindowName.AutoSize = true;
            this.RandomWindowName.Location = new System.Drawing.Point(6, 41);
            this.RandomWindowName.Name = "RandomWindowName";
            this.RandomWindowName.Size = new System.Drawing.Size(269, 17);
            this.RandomWindowName.TabIndex = 1;
            this.RandomWindowName.Text = "Рандомное название окна при каждом запуске";
            this.RandomWindowName.UseVisualStyleBackColor = true;
            this.RandomWindowName.CheckedChanged += new System.EventHandler(this.RandomWindowName_CheckedChanged);
            // 
            // AlwaysOnTop
            // 
            this.AlwaysOnTop.AutoSize = true;
            this.AlwaysOnTop.Location = new System.Drawing.Point(6, 64);
            this.AlwaysOnTop.Name = "AlwaysOnTop";
            this.AlwaysOnTop.Size = new System.Drawing.Size(143, 17);
            this.AlwaysOnTop.TabIndex = 0;
            this.AlwaysOnTop.Text = "Быть поверх всех окон";
            this.AlwaysOnTop.UseVisualStyleBackColor = true;
            this.AlwaysOnTop.CheckedChanged += new System.EventHandler(this.AlwaysOnTop_CheckedChanged);
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(12, 218);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 2;
            this.doneBtn.Text = "Применить";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(278, 218);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(109, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Настройки";
            // 
            // actionBox
            // 
            this.actionBox.Controls.Add(this.CloseApp);
            this.actionBox.Controls.Add(this.MainMenuClose);
            this.actionBox.Location = new System.Drawing.Point(12, 141);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(341, 71);
            this.actionBox.TabIndex = 5;
            this.actionBox.TabStop = false;
            this.actionBox.Text = "Поведение";
            // 
            // CloseApp
            // 
            this.CloseApp.AutoSize = true;
            this.CloseApp.Location = new System.Drawing.Point(6, 42);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(267, 17);
            this.CloseApp.TabIndex = 1;
            this.CloseApp.Text = "Закрывать программу при нажатии на крестик";
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.CheckedChanged += new System.EventHandler(this.CloseApp_CheckedChanged);
            // 
            // MainMenuClose
            // 
            this.MainMenuClose.AutoSize = true;
            this.MainMenuClose.Location = new System.Drawing.Point(6, 19);
            this.MainMenuClose.Name = "MainMenuClose";
            this.MainMenuClose.Size = new System.Drawing.Size(272, 17);
            this.MainMenuClose.TabIndex = 0;
            this.MainMenuClose.Text = "Закрывать главное меню при запуске действия";
            this.MainMenuClose.UseVisualStyleBackColor = true;
            this.MainMenuClose.CheckedChanged += new System.EventHandler(this.MainMenuClose_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 252);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.mainBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.mainBox.ResumeLayout(false);
            this.mainBox.PerformLayout();
            this.actionBox.ResumeLayout(false);
            this.actionBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mainBox;
        private System.Windows.Forms.CheckBox RandomWindowName;
        private System.Windows.Forms.CheckBox AlwaysOnTop;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox AutoUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox actionBox;
        private System.Windows.Forms.CheckBox MainMenuClose;
        private System.Windows.Forms.CheckBox CloseApp;
    }
}