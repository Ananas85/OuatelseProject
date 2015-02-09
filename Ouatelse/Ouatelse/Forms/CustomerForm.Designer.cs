namespace Ouatelse.Forms
{
    partial class CustomerForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.validateButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.adress1TB = new System.Windows.Forms.TextBox();
            this.civilityBox = new System.Windows.Forms.ComboBox();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.adress2TB = new System.Windows.Forms.TextBox();
            this.zipCodeTB = new System.Windows.Forms.TextBox();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.mobilePhoneTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(43, 348);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 251);
            this.tabControl1.TabIndex = 92;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Statistiques";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(62, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "Prénom: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "Nom: ";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(368, 31);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 40);
            this.cancelButton.TabIndex = 85;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // validateButton
            // 
            this.validateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.validateButton.FlatAppearance.BorderSize = 0;
            this.validateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validateButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.validateButton.Location = new System.Drawing.Point(467, 31);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(89, 40);
            this.validateButton.TabIndex = 84;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = false;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Courriel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Date de naissance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tél/Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Pays: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Code postal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Adresse: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Civilité:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Code Client:";
            // 
            // DateBirthPicker
            // 
            this.DateBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBirthPicker.Location = new System.Drawing.Point(456, 283);
            this.DateBirthPicker.Name = "DateBirthPicker";
            this.DateBirthPicker.Size = new System.Drawing.Size(100, 20);
            this.DateBirthPicker.TabIndex = 75;
            // 
            // adress1TB
            // 
            this.adress1TB.Location = new System.Drawing.Point(114, 203);
            this.adress1TB.Name = "adress1TB";
            this.adress1TB.Size = new System.Drawing.Size(442, 20);
            this.adress1TB.TabIndex = 74;
            // 
            // civilityBox
            // 
            this.civilityBox.FormattingEnabled = true;
            this.civilityBox.Location = new System.Drawing.Point(232, 123);
            this.civilityBox.Name = "civilityBox";
            this.civilityBox.Size = new System.Drawing.Size(53, 21);
            this.civilityBox.TabIndex = 73;
            // 
            // firstnameTB
            // 
            this.firstnameTB.Location = new System.Drawing.Point(114, 149);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(171, 20);
            this.firstnameTB.TabIndex = 72;
            // 
            // lastnameTB
            // 
            this.lastnameTB.Location = new System.Drawing.Point(114, 177);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(171, 20);
            this.lastnameTB.TabIndex = 71;
            // 
            // adress2TB
            // 
            this.adress2TB.Location = new System.Drawing.Point(114, 229);
            this.adress2TB.Name = "adress2TB";
            this.adress2TB.Size = new System.Drawing.Size(442, 20);
            this.adress2TB.TabIndex = 70;
            // 
            // zipCodeTB
            // 
            this.zipCodeTB.Location = new System.Drawing.Point(114, 255);
            this.zipCodeTB.Name = "zipCodeTB";
            this.zipCodeTB.Size = new System.Drawing.Size(69, 20);
            this.zipCodeTB.TabIndex = 69;
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(436, 255);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(120, 20);
            this.countryTB.TabIndex = 67;
            // 
            // mobilePhoneTB
            // 
            this.mobilePhoneTB.Location = new System.Drawing.Point(114, 283);
            this.mobilePhoneTB.Name = "mobilePhoneTB";
            this.mobilePhoneTB.Size = new System.Drawing.Size(111, 20);
            this.mobilePhoneTB.TabIndex = 66;
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(232, 283);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(111, 20);
            this.phoneTB.TabIndex = 65;
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(114, 309);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(442, 20);
            this.mailTB.TabIndex = 64;
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(114, 123);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(69, 20);
            this.idTB.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 40);
            this.label1.TabIndex = 62;
            this.label1.Text = "Détails d\'un client";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(212, 258);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 17);
            this.listBox1.TabIndex = 93;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(505, 225);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Factures";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 652);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateBirthPicker);
            this.Controls.Add(this.adress1TB);
            this.Controls.Add(this.civilityBox);
            this.Controls.Add(this.firstnameTB);
            this.Controls.Add(this.lastnameTB);
            this.Controls.Add(this.adress2TB);
            this.Controls.Add(this.zipCodeTB);
            this.Controls.Add(this.countryTB);
            this.Controls.Add(this.mobilePhoneTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateBirthPicker;
        private System.Windows.Forms.TextBox adress1TB;
        private System.Windows.Forms.ComboBox civilityBox;
        private System.Windows.Forms.TextBox firstnameTB;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.TextBox adress2TB;
        private System.Windows.Forms.TextBox zipCodeTB;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.TextBox mobilePhoneTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox1;
    }
}