
namespace SU.Forms.UR
{
    partial class AddCustomRestriction
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
            this.restrictionBox = new System.Windows.Forms.GroupBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.keyTextbox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.hiveCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.disableValueNumber = new System.Windows.Forms.NumericUpDown();
            this.createBtn = new System.Windows.Forms.Button();
            this.disableValueNoneBox = new System.Windows.Forms.CheckBox();
            this.restrictionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disableValueNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // restrictionBox
            // 
            this.restrictionBox.Controls.Add(this.descriptionBox);
            this.restrictionBox.Controls.Add(this.descriptionLabel);
            this.restrictionBox.Controls.Add(this.keyTextbox);
            this.restrictionBox.Controls.Add(this.keyLabel);
            this.restrictionBox.Controls.Add(this.pathTextbox);
            this.restrictionBox.Controls.Add(this.pathLabel);
            this.restrictionBox.Controls.Add(this.hiveCombobox);
            this.restrictionBox.Controls.Add(this.label1);
            this.restrictionBox.Location = new System.Drawing.Point(12, 12);
            this.restrictionBox.Name = "restrictionBox";
            this.restrictionBox.Size = new System.Drawing.Size(415, 163);
            this.restrictionBox.TabIndex = 0;
            this.restrictionBox.TabStop = false;
            this.restrictionBox.Text = "Ограничение";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(72, 122);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(337, 20);
            this.descriptionBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 125);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Описание:";
            // 
            // keyTextbox
            // 
            this.keyTextbox.Location = new System.Drawing.Point(72, 87);
            this.keyTextbox.Name = "keyTextbox";
            this.keyTextbox.Size = new System.Drawing.Size(337, 20);
            this.keyTextbox.TabIndex = 5;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(30, 90);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(36, 13);
            this.keyLabel.TabIndex = 4;
            this.keyLabel.Text = "Ключ:";
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(72, 54);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.Size = new System.Drawing.Size(337, 20);
            this.pathTextbox.TabIndex = 3;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(32, 57);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(34, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Путь:";
            // 
            // hiveCombobox
            // 
            this.hiveCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hiveCombobox.FormattingEnabled = true;
            this.hiveCombobox.Location = new System.Drawing.Point(72, 22);
            this.hiveCombobox.Name = "hiveCombobox";
            this.hiveCombobox.Size = new System.Drawing.Size(337, 21);
            this.hiveCombobox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ветка:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(12, 183);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(121, 13);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Значение отключения:";
            // 
            // disableValueNumber
            // 
            this.disableValueNumber.Location = new System.Drawing.Point(139, 181);
            this.disableValueNumber.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.disableValueNumber.Name = "disableValueNumber";
            this.disableValueNumber.Size = new System.Drawing.Size(288, 20);
            this.disableValueNumber.TabIndex = 8;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(15, 235);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(412, 23);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Создать";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // disableValueNoneBox
            // 
            this.disableValueNoneBox.AutoSize = true;
            this.disableValueNoneBox.Location = new System.Drawing.Point(15, 212);
            this.disableValueNoneBox.Name = "disableValueNoneBox";
            this.disableValueNoneBox.Size = new System.Drawing.Size(157, 17);
            this.disableValueNoneBox.TabIndex = 10;
            this.disableValueNoneBox.Text = "Значения отключения нет";
            this.disableValueNoneBox.UseVisualStyleBackColor = true;
            this.disableValueNoneBox.CheckedChanged += new System.EventHandler(this.disableValueNoneBox_CheckedChanged);
            // 
            // AddCustomRestriction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 270);
            this.Controls.Add(this.disableValueNoneBox);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.disableValueNumber);
            this.Controls.Add(this.restrictionBox);
            this.Controls.Add(this.valueLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomRestriction";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.restrictionBox.ResumeLayout(false);
            this.restrictionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disableValueNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox restrictionBox;
        private System.Windows.Forms.ComboBox hiveCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox keyTextbox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox pathTextbox;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.NumericUpDown disableValueNumber;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.CheckBox disableValueNoneBox;
    }
}