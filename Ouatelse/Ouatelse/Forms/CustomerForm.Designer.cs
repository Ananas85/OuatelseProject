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
            this.Address1 = new System.Windows.Forms.TextBox();
            this.GenderName = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Address2 = new System.Windows.Forms.TextBox();
            this.CityPostalCode = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.MobilePhoneNumber = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CityName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CommentsContainer = new System.Windows.Forms.TabPage();
            this.Comments = new System.Windows.Forms.TextBox();
            this.Statistiques = new System.Windows.Forms.TabPage();
            this.Factures = new System.Windows.Forms.TabPage();
            this.EmailOnUpdate = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.CommentsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 87;
            this.label12.Text = "Prénom: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(75, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
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
            this.cancelButton.Location = new System.Drawing.Point(392, 24);
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
            this.validateButton.Location = new System.Drawing.Point(487, 24);
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
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Courriel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Date de naissance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tél/Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Pays: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Code postal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Adresse: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Civilité:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Code Client:";
            // 
            // DateBirthPicker
            // 
            this.DateBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateBirthPicker.Location = new System.Drawing.Point(456, 283);
            this.DateBirthPicker.Name = "DateBirthPicker";
            this.DateBirthPicker.Size = new System.Drawing.Size(100, 20);
            this.DateBirthPicker.TabIndex = 10;
            // 
            // Address1
            // 
            this.Address1.Location = new System.Drawing.Point(114, 203);
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(442, 20);
            this.Address1.TabIndex = 4;
            // 
            // GenderName
            // 
            this.GenderName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderName.FormattingEnabled = true;
            this.GenderName.Location = new System.Drawing.Point(232, 123);
            this.GenderName.Name = "GenderName";
            this.GenderName.Size = new System.Drawing.Size(53, 21);
            this.GenderName.TabIndex = 1;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(114, 149);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(171, 20);
            this.FirstName.TabIndex = 2;
            this.FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstName_KeyPress);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(114, 177);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(171, 20);
            this.LastName.TabIndex = 3;
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_KeyPress);
            // 
            // Address2
            // 
            this.Address2.Location = new System.Drawing.Point(114, 229);
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(442, 20);
            this.Address2.TabIndex = 5;
            // 
            // CityPostalCode
            // 
            this.CityPostalCode.Location = new System.Drawing.Point(114, 255);
            this.CityPostalCode.Name = "CityPostalCode";
            this.CityPostalCode.Size = new System.Drawing.Size(69, 20);
            this.CityPostalCode.TabIndex = 6;
            this.CityPostalCode.TextChanged += new System.EventHandler(this.CityPostalCode_TextChanged);
            this.CityPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityPostalCode_KeyPress);
            // 
            // Country
            // 
            this.Country.Location = new System.Drawing.Point(456, 255);
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Size = new System.Drawing.Size(100, 20);
            this.Country.TabIndex = 67;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(114, 283);
            this.PhoneNumber.MaxLength = 10;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(111, 20);
            this.PhoneNumber.TabIndex = 8;
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber_KeyPress);
            // 
            // MobilePhoneNumber
            // 
            this.MobilePhoneNumber.Location = new System.Drawing.Point(232, 283);
            this.MobilePhoneNumber.MaxLength = 10;
            this.MobilePhoneNumber.Name = "MobilePhoneNumber";
            this.MobilePhoneNumber.Size = new System.Drawing.Size(111, 20);
            this.MobilePhoneNumber.TabIndex = 9;
            this.MobilePhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MobilePhoneNumber_KeyPress);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(114, 309);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(308, 20);
            this.Email.TabIndex = 11;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(114, 123);
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Size = new System.Drawing.Size(69, 20);
            this.Id.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 40);
            this.label1.TabIndex = 62;
            this.label1.Text = "Détails d\'un client";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.Ouatelse_full_05;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // CityName
            // 
            this.CityName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityName.FormattingEnabled = true;
            this.CityName.Location = new System.Drawing.Point(232, 256);
            this.CityName.Name = "CityName";
            this.CityName.Size = new System.Drawing.Size(175, 21);
            this.CityName.TabIndex = 7;
            this.CityName.SelectedIndexChanged += new System.EventHandler(this.CityName_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(185, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Ville : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CommentsContainer);
            this.tabControl1.Controls.Add(this.Statistiques);
            this.tabControl1.Controls.Add(this.Factures);
            this.tabControl1.Location = new System.Drawing.Point(62, 347);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 246);
            this.tabControl1.TabIndex = 95;
            // 
            // CommentsContainer
            // 
            this.CommentsContainer.BackColor = System.Drawing.Color.Transparent;
            this.CommentsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CommentsContainer.Controls.Add(this.Comments);
            this.CommentsContainer.Location = new System.Drawing.Point(4, 22);
            this.CommentsContainer.Name = "CommentsContainer";
            this.CommentsContainer.Padding = new System.Windows.Forms.Padding(3);
            this.CommentsContainer.Size = new System.Drawing.Size(486, 220);
            this.CommentsContainer.TabIndex = 0;
            this.CommentsContainer.Text = "Notes";
            // 
            // Comments
            // 
            this.Comments.Location = new System.Drawing.Point(2, 2);
            this.Comments.Multiline = true;
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(480, 214);
            this.Comments.TabIndex = 0;
            // 
            // Statistiques
            // 
            this.Statistiques.Location = new System.Drawing.Point(4, 22);
            this.Statistiques.Name = "Statistiques";
            this.Statistiques.Padding = new System.Windows.Forms.Padding(3);
            this.Statistiques.Size = new System.Drawing.Size(486, 220);
            this.Statistiques.TabIndex = 1;
            this.Statistiques.Text = "Statistiques";
            this.Statistiques.UseVisualStyleBackColor = true;
            // 
            // Factures
            // 
            this.Factures.Location = new System.Drawing.Point(4, 22);
            this.Factures.Name = "Factures";
            this.Factures.Size = new System.Drawing.Size(486, 220);
            this.Factures.TabIndex = 2;
            this.Factures.Text = "Factures";
            this.Factures.UseVisualStyleBackColor = true;
            // 
            // EmailOnUpdate
            // 
            this.EmailOnUpdate.AutoSize = true;
            this.EmailOnUpdate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EmailOnUpdate.Location = new System.Drawing.Point(428, 311);
            this.EmailOnUpdate.Name = "EmailOnUpdate";
            this.EmailOnUpdate.Size = new System.Drawing.Size(130, 17);
            this.EmailOnUpdate.TabIndex = 97;
            this.EmailOnUpdate.Text = "Email à la modification";
            this.EmailOnUpdate.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(111, -2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(525, 90);
            this.label13.TabIndex = 98;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(586, 606);
            this.Controls.Add(this.EmailOnUpdate);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CityName);
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
            this.Controls.Add(this.Address1);
            this.Controls.Add(this.GenderName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Address2);
            this.Controls.Add(this.CityPostalCode);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.MobilePhoneNumber);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.CommentsContainer.ResumeLayout(false);
            this.CommentsContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox Address1;
        private System.Windows.Forms.ComboBox GenderName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Address2;
        private System.Windows.Forms.TextBox CityPostalCode;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox MobilePhoneNumber;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CityName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CommentsContainer;
        private System.Windows.Forms.TextBox Comments;
        private System.Windows.Forms.TabPage Statistiques;
        private System.Windows.Forms.TabPage Factures;
        private System.Windows.Forms.CheckBox EmailOnUpdate;
        private System.Windows.Forms.Label label13;
    }
}