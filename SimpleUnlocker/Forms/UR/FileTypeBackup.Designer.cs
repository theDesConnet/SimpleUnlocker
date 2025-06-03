
namespace SU.Forms.UR
{
    partial class FileTypeBackup
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.runControl = new System.Windows.Forms.TabControl();
            this.openTab = new System.Windows.Forms.TabPage();
            this.delegateOpenBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.isolateOpenBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.openDefaultBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.runAsTab = new System.Windows.Forms.TabPage();
            this.delegateRunAsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isolateRunAsBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.defaultRunAsBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.runAsUserTab = new System.Windows.Forms.TabPage();
            this.delegateRunAsUserBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.isolateRunAsUserBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.defaultRunAsUserBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.copyFileTypeBox = new System.Windows.Forms.ComboBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.defaultIconBox = new System.Windows.Forms.TextBox();
            this.runControl.SuspendLayout();
            this.openTab.SuspendLayout();
            this.runAsTab.SuspendLayout();
            this.runAsUserTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(106, 15);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(468, 20);
            this.nameBox.TabIndex = 1;
            // 
            // runControl
            // 
            this.runControl.Controls.Add(this.openTab);
            this.runControl.Controls.Add(this.runAsTab);
            this.runControl.Controls.Add(this.runAsUserTab);
            this.runControl.Location = new System.Drawing.Point(16, 94);
            this.runControl.Name = "runControl";
            this.runControl.SelectedIndex = 0;
            this.runControl.Size = new System.Drawing.Size(562, 166);
            this.runControl.TabIndex = 2;
            // 
            // openTab
            // 
            this.openTab.Controls.Add(this.delegateOpenBox);
            this.openTab.Controls.Add(this.label4);
            this.openTab.Controls.Add(this.isolateOpenBox);
            this.openTab.Controls.Add(this.label3);
            this.openTab.Controls.Add(this.openDefaultBox);
            this.openTab.Controls.Add(this.label2);
            this.openTab.Location = new System.Drawing.Point(4, 22);
            this.openTab.Name = "openTab";
            this.openTab.Padding = new System.Windows.Forms.Padding(3);
            this.openTab.Size = new System.Drawing.Size(554, 140);
            this.openTab.TabIndex = 0;
            this.openTab.Text = "Open";
            this.openTab.UseVisualStyleBackColor = true;
            // 
            // delegateOpenBox
            // 
            this.delegateOpenBox.Location = new System.Drawing.Point(11, 106);
            this.delegateOpenBox.Name = "delegateOpenBox";
            this.delegateOpenBox.Size = new System.Drawing.Size(528, 20);
            this.delegateOpenBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Делегированное выполнение";
            // 
            // isolateOpenBox
            // 
            this.isolateOpenBox.Location = new System.Drawing.Point(11, 67);
            this.isolateOpenBox.Name = "isolateOpenBox";
            this.isolateOpenBox.Size = new System.Drawing.Size(528, 20);
            this.isolateOpenBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Изолированная команда";
            // 
            // openDefaultBox
            // 
            this.openDefaultBox.Location = new System.Drawing.Point(11, 28);
            this.openDefaultBox.Name = "openDefaultBox";
            this.openDefaultBox.Size = new System.Drawing.Size(528, 20);
            this.openDefaultBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "По умолчанию";
            // 
            // runAsTab
            // 
            this.runAsTab.Controls.Add(this.delegateRunAsBox);
            this.runAsTab.Controls.Add(this.label5);
            this.runAsTab.Controls.Add(this.isolateRunAsBox);
            this.runAsTab.Controls.Add(this.label6);
            this.runAsTab.Controls.Add(this.defaultRunAsBox);
            this.runAsTab.Controls.Add(this.label7);
            this.runAsTab.Location = new System.Drawing.Point(4, 22);
            this.runAsTab.Name = "runAsTab";
            this.runAsTab.Padding = new System.Windows.Forms.Padding(3);
            this.runAsTab.Size = new System.Drawing.Size(554, 140);
            this.runAsTab.TabIndex = 1;
            this.runAsTab.Text = "Runas";
            this.runAsTab.UseVisualStyleBackColor = true;
            // 
            // delegateRunAsBox
            // 
            this.delegateRunAsBox.Location = new System.Drawing.Point(11, 106);
            this.delegateRunAsBox.Name = "delegateRunAsBox";
            this.delegateRunAsBox.Size = new System.Drawing.Size(528, 20);
            this.delegateRunAsBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Делегированное выполнение";
            // 
            // isolateRunAsBox
            // 
            this.isolateRunAsBox.Location = new System.Drawing.Point(11, 67);
            this.isolateRunAsBox.Name = "isolateRunAsBox";
            this.isolateRunAsBox.Size = new System.Drawing.Size(528, 20);
            this.isolateRunAsBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Изолированная команда";
            // 
            // defaultRunAsBox
            // 
            this.defaultRunAsBox.Location = new System.Drawing.Point(11, 28);
            this.defaultRunAsBox.Name = "defaultRunAsBox";
            this.defaultRunAsBox.Size = new System.Drawing.Size(528, 20);
            this.defaultRunAsBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "По умолчанию";
            // 
            // runAsUserTab
            // 
            this.runAsUserTab.Controls.Add(this.delegateRunAsUserBox);
            this.runAsUserTab.Controls.Add(this.label8);
            this.runAsUserTab.Controls.Add(this.isolateRunAsUserBox);
            this.runAsUserTab.Controls.Add(this.label9);
            this.runAsUserTab.Controls.Add(this.defaultRunAsUserBox);
            this.runAsUserTab.Controls.Add(this.label10);
            this.runAsUserTab.Location = new System.Drawing.Point(4, 22);
            this.runAsUserTab.Name = "runAsUserTab";
            this.runAsUserTab.Size = new System.Drawing.Size(554, 140);
            this.runAsUserTab.TabIndex = 2;
            this.runAsUserTab.Text = "RunasUser";
            this.runAsUserTab.UseVisualStyleBackColor = true;
            // 
            // delegateRunAsUserBox
            // 
            this.delegateRunAsUserBox.Location = new System.Drawing.Point(11, 106);
            this.delegateRunAsUserBox.Name = "delegateRunAsUserBox";
            this.delegateRunAsUserBox.Size = new System.Drawing.Size(528, 20);
            this.delegateRunAsUserBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Делегированное выполнение";
            // 
            // isolateRunAsUserBox
            // 
            this.isolateRunAsUserBox.Location = new System.Drawing.Point(11, 67);
            this.isolateRunAsUserBox.Name = "isolateRunAsUserBox";
            this.isolateRunAsUserBox.Size = new System.Drawing.Size(528, 20);
            this.isolateRunAsUserBox.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Изолированная команда";
            // 
            // defaultRunAsUserBox
            // 
            this.defaultRunAsUserBox.Location = new System.Drawing.Point(11, 28);
            this.defaultRunAsUserBox.Name = "defaultRunAsUserBox";
            this.defaultRunAsUserBox.Size = new System.Drawing.Size(528, 20);
            this.defaultRunAsUserBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "По умолчанию";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(499, 262);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(418, 262);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 4;
            this.acceptBtn.Text = "ОК";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Скопировать из:";
            // 
            // copyFileTypeBox
            // 
            this.copyFileTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.copyFileTypeBox.FormattingEnabled = true;
            this.copyFileTypeBox.Location = new System.Drawing.Point(110, 264);
            this.copyFileTypeBox.Name = "copyFileTypeBox";
            this.copyFileTypeBox.Size = new System.Drawing.Size(277, 21);
            this.copyFileTypeBox.TabIndex = 6;
            this.copyFileTypeBox.SelectedIndexChanged += new System.EventHandler(this.copyFileTypeBox_SelectedIndexChanged);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(106, 41);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(468, 20);
            this.descriptionBox.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Описание:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Иконка:";
            // 
            // defaultIconBox
            // 
            this.defaultIconBox.Location = new System.Drawing.Point(106, 67);
            this.defaultIconBox.Name = "defaultIconBox";
            this.defaultIconBox.Size = new System.Drawing.Size(468, 20);
            this.defaultIconBox.TabIndex = 10;
            // 
            // FileTypeBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 295);
            this.Controls.Add(this.defaultIconBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.copyFileTypeBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.runControl);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileTypeBackup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FileTypeBackup_Load);
            this.runControl.ResumeLayout(false);
            this.openTab.ResumeLayout(false);
            this.openTab.PerformLayout();
            this.runAsTab.ResumeLayout(false);
            this.runAsTab.PerformLayout();
            this.runAsUserTab.ResumeLayout(false);
            this.runAsUserTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TabControl runControl;
        private System.Windows.Forms.TabPage openTab;
        private System.Windows.Forms.TextBox delegateOpenBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isolateOpenBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox openDefaultBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage runAsTab;
        private System.Windows.Forms.TabPage runAsUserTab;
        private System.Windows.Forms.TextBox delegateRunAsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isolateRunAsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox defaultRunAsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox delegateRunAsUserBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox isolateRunAsUserBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox defaultRunAsUserBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox copyFileTypeBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox defaultIconBox;
    }
}