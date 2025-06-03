namespace SU.Forms.TaskMgr
{
    partial class AntiGDI
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.prcBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Controls.Add(this.cancelBtn);
            this.mainBox.Controls.Add(this.runBtn);
            this.mainBox.Controls.Add(this.prcBox);
            this.mainBox.Controls.Add(this.label1);
            this.mainBox.Location = new System.Drawing.Point(12, 41);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(414, 75);
            this.mainBox.TabIndex = 1;
            this.mainBox.TabStop = false;
            this.mainBox.Text = "Главная";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(319, 46);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(9, 46);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 2;
            this.runBtn.Text = "Старт";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // prcBox
            // 
            this.prcBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prcBox.FormattingEnabled = true;
            this.prcBox.Location = new System.Drawing.Point(80, 15);
            this.prcBox.Name = "prcBox";
            this.prcBox.Size = new System.Drawing.Size(314, 21);
            this.prcBox.TabIndex = 1;
            this.prcBox.DropDown += new System.EventHandler(this.prcBox_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Процесс:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "AntiGDI";
            // 
            // AntiGDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 125);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mainBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AntiGDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AntiGDI_Load);
            this.mainBox.ResumeLayout(false);
            this.mainBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mainBox;
        private System.Windows.Forms.ComboBox prcBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label label2;
    }
}