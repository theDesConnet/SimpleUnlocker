
namespace SU.Forms.UR
{
    partial class AssociationEdit
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
            this.AssocLabel = new System.Windows.Forms.Label();
            this.AssocBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FileTypeBox = new System.Windows.Forms.ComboBox();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssocLabel
            // 
            this.AssocLabel.AutoSize = true;
            this.AssocLabel.Location = new System.Drawing.Point(12, 28);
            this.AssocLabel.Name = "AssocLabel";
            this.AssocLabel.Size = new System.Drawing.Size(71, 13);
            this.AssocLabel.TabIndex = 0;
            this.AssocLabel.Text = "Ассоциация:";
            // 
            // AssocBox
            // 
            this.AssocBox.BackColor = System.Drawing.SystemColors.Control;
            this.AssocBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AssocBox.Location = new System.Drawing.Point(89, 28);
            this.AssocBox.Name = "AssocBox";
            this.AssocBox.ReadOnly = true;
            this.AssocBox.Size = new System.Drawing.Size(309, 13);
            this.AssocBox.TabIndex = 4;
            this.AssocBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип файла:";
            // 
            // FileTypeBox
            // 
            this.FileTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileTypeBox.FormattingEnabled = true;
            this.FileTypeBox.Location = new System.Drawing.Point(89, 49);
            this.FileTypeBox.Name = "FileTypeBox";
            this.FileTypeBox.Size = new System.Drawing.Size(309, 21);
            this.FileTypeBox.TabIndex = 4;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(242, 83);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(75, 23);
            this.AcceptBtn.TabIndex = 5;
            this.AcceptBtn.Text = "ОК";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(323, 83);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AssociationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 121);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.FileTypeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AssocBox);
            this.Controls.Add(this.AssocLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssociationEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AssociationEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AssocLabel;
        private System.Windows.Forms.TextBox AssocBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FileTypeBox;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}