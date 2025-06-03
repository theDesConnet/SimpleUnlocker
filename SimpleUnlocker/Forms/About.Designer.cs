namespace SU.Forms
{
    partial class About
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
            this.authorBtn = new System.Windows.Forms.Button();
            this.chkUpdateBtn = new System.Windows.Forms.Button();
            this.verLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "SimpleUnlocker";
            // 
            // authorBtn
            // 
            this.authorBtn.ForeColor = System.Drawing.Color.Black;
            this.authorBtn.Location = new System.Drawing.Point(12, 71);
            this.authorBtn.Name = "authorBtn";
            this.authorBtn.Size = new System.Drawing.Size(85, 23);
            this.authorBtn.TabIndex = 7;
            this.authorBtn.Text = "Сайт автора";
            this.authorBtn.UseVisualStyleBackColor = true;
            this.authorBtn.Click += new System.EventHandler(this.authorBtn_Click);
            // 
            // chkUpdateBtn
            // 
            this.chkUpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.chkUpdateBtn.Location = new System.Drawing.Point(103, 71);
            this.chkUpdateBtn.Name = "chkUpdateBtn";
            this.chkUpdateBtn.Size = new System.Drawing.Size(185, 23);
            this.chkUpdateBtn.TabIndex = 8;
            this.chkUpdateBtn.Text = "Проверка обновления";
            this.chkUpdateBtn.UseVisualStyleBackColor = true;
            this.chkUpdateBtn.Click += new System.EventHandler(this.chkUpdateBtn_Click);
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLabel.ForeColor = System.Drawing.Color.Black;
            this.verLabel.Location = new System.Drawing.Point(74, 44);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(134, 21);
            this.verLabel.TabIndex = 9;
            this.verLabel.Text = "Версия: Unknown";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SU.Properties.Resources.SULogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 100);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.verLabel);
            this.Controls.Add(this.chkUpdateBtn);
            this.Controls.Add(this.authorBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button authorBtn;
        private System.Windows.Forms.Button chkUpdateBtn;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}