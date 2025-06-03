namespace SU.Forms.Startup
{
    partial class TaskAbout
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
            this.doneBtn = new System.Windows.Forms.Button();
            this.TaskControl = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.taskDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.taskLastRunBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.taskActivityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.taskStatusBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taskPathBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taskNameBox = new System.Windows.Forms.TextBox();
            this.TriggerPage = new System.Windows.Forms.TabPage();
            this.TriggerView = new System.Windows.Forms.ListView();
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnabledColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionPage = new System.Windows.Forms.TabPage();
            this.ActionView = new System.Windows.Forms.ListView();
            this.CommandColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArgumentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskControl.SuspendLayout();
            this.MainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TriggerPage.SuspendLayout();
            this.ActionPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // doneBtn
            // 
            this.doneBtn.Location = new System.Drawing.Point(374, 339);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 0;
            this.doneBtn.Text = "ОК";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // TaskControl
            // 
            this.TaskControl.Controls.Add(this.MainPage);
            this.TaskControl.Controls.Add(this.TriggerPage);
            this.TaskControl.Controls.Add(this.ActionPage);
            this.TaskControl.Location = new System.Drawing.Point(12, 12);
            this.TaskControl.Name = "TaskControl";
            this.TaskControl.SelectedIndex = 0;
            this.TaskControl.Size = new System.Drawing.Size(441, 321);
            this.TaskControl.TabIndex = 1;
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.label7);
            this.MainPage.Controls.Add(this.taskDescriptionBox);
            this.MainPage.Controls.Add(this.label6);
            this.MainPage.Controls.Add(this.taskLastRunBox);
            this.MainPage.Controls.Add(this.label5);
            this.MainPage.Controls.Add(this.taskActivityBox);
            this.MainPage.Controls.Add(this.label4);
            this.MainPage.Controls.Add(this.taskStatusBox);
            this.MainPage.Controls.Add(this.label3);
            this.MainPage.Controls.Add(this.taskPathBox);
            this.MainPage.Controls.Add(this.label2);
            this.MainPage.Controls.Add(this.label1);
            this.MainPage.Controls.Add(this.pictureBox1);
            this.MainPage.Controls.Add(this.taskNameBox);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(433, 295);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Основное";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Описание:";
            // 
            // taskDescriptionBox
            // 
            this.taskDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskDescriptionBox.Location = new System.Drawing.Point(9, 207);
            this.taskDescriptionBox.Name = "taskDescriptionBox";
            this.taskDescriptionBox.ReadOnly = true;
            this.taskDescriptionBox.Size = new System.Drawing.Size(418, 82);
            this.taskDescriptionBox.TabIndex = 30;
            this.taskDescriptionBox.Text = "";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(4, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 2);
            this.label6.TabIndex = 28;
            // 
            // taskLastRunBox
            // 
            this.taskLastRunBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskLastRunBox.Location = new System.Drawing.Point(112, 152);
            this.taskLastRunBox.Name = "taskLastRunBox";
            this.taskLastRunBox.ReadOnly = true;
            this.taskLastRunBox.Size = new System.Drawing.Size(315, 13);
            this.taskLastRunBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Последний запуск:";
            // 
            // taskActivityBox
            // 
            this.taskActivityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskActivityBox.Location = new System.Drawing.Point(112, 124);
            this.taskActivityBox.Name = "taskActivityBox";
            this.taskActivityBox.ReadOnly = true;
            this.taskActivityBox.Size = new System.Drawing.Size(315, 13);
            this.taskActivityBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Активность:";
            // 
            // taskStatusBox
            // 
            this.taskStatusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskStatusBox.Location = new System.Drawing.Point(112, 96);
            this.taskStatusBox.Name = "taskStatusBox";
            this.taskStatusBox.ReadOnly = true;
            this.taskStatusBox.Size = new System.Drawing.Size(315, 13);
            this.taskStatusBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Состояние:";
            // 
            // taskPathBox
            // 
            this.taskPathBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskPathBox.Location = new System.Drawing.Point(112, 68);
            this.taskPathBox.Name = "taskPathBox";
            this.taskPathBox.ReadOnly = true;
            this.taskPathBox.Size = new System.Drawing.Size(315, 13);
            this.taskPathBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Путь:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 2);
            this.label1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SU.Properties.Resources.taskResize;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // taskNameBox
            // 
            this.taskNameBox.Location = new System.Drawing.Point(80, 26);
            this.taskNameBox.Name = "taskNameBox";
            this.taskNameBox.ReadOnly = true;
            this.taskNameBox.Size = new System.Drawing.Size(347, 20);
            this.taskNameBox.TabIndex = 29;
            // 
            // TriggerPage
            // 
            this.TriggerPage.Controls.Add(this.TriggerView);
            this.TriggerPage.Location = new System.Drawing.Point(4, 22);
            this.TriggerPage.Name = "TriggerPage";
            this.TriggerPage.Size = new System.Drawing.Size(433, 295);
            this.TriggerPage.TabIndex = 2;
            this.TriggerPage.Text = "Триггеры";
            this.TriggerPage.UseVisualStyleBackColor = true;
            // 
            // TriggerView
            // 
            this.TriggerView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.EnabledColumn});
            this.TriggerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TriggerView.FullRowSelect = true;
            this.TriggerView.GridLines = true;
            this.TriggerView.HideSelection = false;
            this.TriggerView.Location = new System.Drawing.Point(0, 0);
            this.TriggerView.Name = "TriggerView";
            this.TriggerView.Size = new System.Drawing.Size(433, 295);
            this.TriggerView.TabIndex = 0;
            this.TriggerView.UseCompatibleStateImageBehavior = false;
            this.TriggerView.View = System.Windows.Forms.View.Details;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Триггер";
            this.NameColumn.Width = 301;
            // 
            // EnabledColumn
            // 
            this.EnabledColumn.Text = "Активен";
            this.EnabledColumn.Width = 124;
            // 
            // ActionPage
            // 
            this.ActionPage.Controls.Add(this.ActionView);
            this.ActionPage.Location = new System.Drawing.Point(4, 22);
            this.ActionPage.Margin = new System.Windows.Forms.Padding(1);
            this.ActionPage.Name = "ActionPage";
            this.ActionPage.Size = new System.Drawing.Size(433, 295);
            this.ActionPage.TabIndex = 1;
            this.ActionPage.Text = "Действия";
            this.ActionPage.UseVisualStyleBackColor = true;
            // 
            // ActionView
            // 
            this.ActionView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CommandColumn,
            this.ArgumentColumn});
            this.ActionView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionView.FullRowSelect = true;
            this.ActionView.GridLines = true;
            this.ActionView.HideSelection = false;
            this.ActionView.Location = new System.Drawing.Point(0, 0);
            this.ActionView.Name = "ActionView";
            this.ActionView.Size = new System.Drawing.Size(433, 295);
            this.ActionView.TabIndex = 1;
            this.ActionView.UseCompatibleStateImageBehavior = false;
            this.ActionView.View = System.Windows.Forms.View.Details;
            // 
            // CommandColumn
            // 
            this.CommandColumn.Text = "Команда";
            this.CommandColumn.Width = 353;
            // 
            // ArgumentColumn
            // 
            this.ArgumentColumn.Text = "Аргументы";
            this.ArgumentColumn.Width = 74;
            // 
            // TaskAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 374);
            this.Controls.Add(this.TaskControl);
            this.Controls.Add(this.doneBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Свойства задачи";
            this.TaskControl.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TriggerPage.ResumeLayout(false);
            this.ActionPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.TabControl TaskControl;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox taskDescriptionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox taskLastRunBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox taskActivityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox taskStatusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox taskPathBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox taskNameBox;
        private System.Windows.Forms.TabPage ActionPage;
        private System.Windows.Forms.TabPage TriggerPage;
        private System.Windows.Forms.ListView TriggerView;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ColumnHeader EnabledColumn;
        private System.Windows.Forms.ListView ActionView;
        private System.Windows.Forms.ColumnHeader CommandColumn;
        private System.Windows.Forms.ColumnHeader ArgumentColumn;
    }
}