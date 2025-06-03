
namespace SU.Forms.TaskMgr
{
    partial class Run
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ExecBox = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.doneBtn = new System.Windows.Forms.Button();
            this.ofdRun = new System.Windows.Forms.OpenFileDialog();
            this.runBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.runBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя программы, папки, документа или ресурса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(90, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Интернета, которые требуется открыть.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Открыть:";
            // 
            // ExecBox
            // 
            this.ExecBox.Location = new System.Drawing.Point(93, 75);
            this.ExecBox.Name = "ExecBox";
            this.ExecBox.Size = new System.Drawing.Size(330, 20);
            this.ExecBox.TabIndex = 3;
            this.ExecBox.TextChanged += new System.EventHandler(this.ExecBox_TextChanged);
            this.ExecBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecBox_KeyPress);
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(348, 121);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 4;
            this.viewBtn.Text = "Обзор...";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(267, 121);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // doneBtn
            // 
            this.doneBtn.Enabled = false;
            this.doneBtn.Location = new System.Drawing.Point(186, 121);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(75, 23);
            this.doneBtn.TabIndex = 6;
            this.doneBtn.Text = "Выполнить";
            this.doneBtn.UseVisualStyleBackColor = true;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // ofdRun
            // 
            this.ofdRun.Filter = "Приложения| *.exe *.bat *.cmd *.vbs|Все файлы|*.*";
            this.ofdRun.RestoreDirectory = true;
            // 
            // runBox
            // 
            this.runBox.Image = global::SU.Properties.Resources.runIcon;
            this.runBox.Location = new System.Drawing.Point(15, 22);
            this.runBox.Name = "runBox";
            this.runBox.Size = new System.Drawing.Size(59, 45);
            this.runBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.runBox.TabIndex = 7;
            this.runBox.TabStop = false;
            // 
            // Run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 156);
            this.Controls.Add(this.runBox);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.ExecBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Run";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.runBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExecBox;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.OpenFileDialog ofdRun;
        private System.Windows.Forms.PictureBox runBox;
    }
}