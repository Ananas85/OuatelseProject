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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
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
            this.invoices = new System.Windows.Forms.ListView();
            this.Iden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code_postal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailOnUpdate = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.NumberTotalOfPaidInvoices = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ExpenseTotalOfPaidInvoices = new System.Windows.Forms.Label();
            this.NumberTotalOfUnpaidInvoices = new System.Windows.Forms.Label();
            this.ExpenseTotalOfUnpaidInvoices = new System.Windows.Forms.Label();
            this.numberOfCompleteInvoiceInMonth = new System.Windows.Forms.Label();
            this.ExpenseOfCompleteInvoiceInMonth = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.NumberTotalOfInvoice = new System.Windows.Forms.Label();
            this.ExpenseTotalOfInvoice = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.ExpenseOfCompleteInvoiceInYear = new System.Windows.Forms.Label();
            this.numberOfCompleteInvoiceInYear = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.CommentsContainer.SuspendLayout();
            this.Statistiques.SuspendLayout();
            this.Factures.SuspendLayout();
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
            this.CityPostalCode.MaxLength = 5;
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
            this.Statistiques.Controls.Add(this.label34);
            this.Statistiques.Controls.Add(this.ExpenseOfCompleteInvoiceInYear);
            this.Statistiques.Controls.Add(this.numberOfCompleteInvoiceInYear);
            this.Statistiques.Controls.Add(this.label40);
            this.Statistiques.Controls.Add(this.label31);
            this.Statistiques.Controls.Add(this.label30);
            this.Statistiques.Controls.Add(this.label29);
            this.Statistiques.Controls.Add(this.label28);
            this.Statistiques.Controls.Add(this.ExpenseTotalOfInvoice);
            this.Statistiques.Controls.Add(this.NumberTotalOfInvoice);
            this.Statistiques.Controls.Add(this.label25);
            this.Statistiques.Controls.Add(this.ExpenseOfCompleteInvoiceInMonth);
            this.Statistiques.Controls.Add(this.numberOfCompleteInvoiceInMonth);
            this.Statistiques.Controls.Add(this.ExpenseTotalOfUnpaidInvoices);
            this.Statistiques.Controls.Add(this.NumberTotalOfUnpaidInvoices);
            this.Statistiques.Controls.Add(this.ExpenseTotalOfPaidInvoices);
            this.Statistiques.Controls.Add(this.label16);
            this.Statistiques.Controls.Add(this.label15);
            this.Statistiques.Controls.Add(this.NumberTotalOfPaidInvoices);
            this.Statistiques.Controls.Add(this.label14);
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
            this.Factures.Controls.Add(this.invoices);
            this.Factures.Location = new System.Drawing.Point(4, 22);
            this.Factures.Name = "Factures";
            this.Factures.Size = new System.Drawing.Size(486, 220);
            this.Factures.TabIndex = 2;
            this.Factures.Text = "Factures";
            this.Factures.UseVisualStyleBackColor = true;
            // 
            // invoices
            // 
            this.invoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Iden,
            this.adresse,
            this.code_postal,
            this.pays,
            this.columnHeader2});
            this.invoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoices.FullRowSelect = true;
            this.invoices.GridLines = true;
            this.invoices.Location = new System.Drawing.Point(0, 0);
            this.invoices.MultiSelect = false;
            this.invoices.Name = "invoices";
            this.invoices.Size = new System.Drawing.Size(486, 220);
            this.invoices.TabIndex = 127;
            this.invoices.UseCompatibleStateImageBehavior = false;
            this.invoices.View = System.Windows.Forms.View.Details;
            this.invoices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.invoices_MouseDoubleClick);
            // 
            // Iden
            // 
            this.Iden.Name = "Iden";
            this.Iden.Text = "Ref";
            this.Iden.Width = 50;
            // 
            // adresse
            // 
            this.adresse.Name = "adresse";
            this.adresse.Text = "Date";
            this.adresse.Width = 80;
            // 
            // code_postal
            // 
            this.code_postal.Name = "code_postal";
            this.code_postal.Text = "Produits";
            this.code_postal.Width = 170;
            // 
            // pays
            // 
            this.pays.Name = "pays";
            this.pays.Text = "Prix TTC";
            this.pays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pays.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Reglé";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 70;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Nombre total de factures payées : ";
            // 
            // NumberTotalOfPaidInvoices
            // 
            this.NumberTotalOfPaidInvoices.AutoSize = true;
            this.NumberTotalOfPaidInvoices.Location = new System.Drawing.Point(224, 85);
            this.NumberTotalOfPaidInvoices.Name = "NumberTotalOfPaidInvoices";
            this.NumberTotalOfPaidInvoices.Size = new System.Drawing.Size(41, 13);
            this.NumberTotalOfPaidInvoices.TabIndex = 1;
            this.NumberTotalOfPaidInvoices.Text = "label15";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Nombre total de factures impayées : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Nombre de factures payées ce mois :";
            // 
            // ExpenseTotalOfPaidInvoices
            // 
            this.ExpenseTotalOfPaidInvoices.AutoSize = true;
            this.ExpenseTotalOfPaidInvoices.Location = new System.Drawing.Point(328, 85);
            this.ExpenseTotalOfPaidInvoices.Name = "ExpenseTotalOfPaidInvoices";
            this.ExpenseTotalOfPaidInvoices.Size = new System.Drawing.Size(41, 13);
            this.ExpenseTotalOfPaidInvoices.TabIndex = 5;
            this.ExpenseTotalOfPaidInvoices.Text = "label18";
            // 
            // NumberTotalOfUnpaidInvoices
            // 
            this.NumberTotalOfUnpaidInvoices.AutoSize = true;
            this.NumberTotalOfUnpaidInvoices.Location = new System.Drawing.Point(224, 115);
            this.NumberTotalOfUnpaidInvoices.Name = "NumberTotalOfUnpaidInvoices";
            this.NumberTotalOfUnpaidInvoices.Size = new System.Drawing.Size(41, 13);
            this.NumberTotalOfUnpaidInvoices.TabIndex = 6;
            this.NumberTotalOfUnpaidInvoices.Text = "label19";
            // 
            // ExpenseTotalOfUnpaidInvoices
            // 
            this.ExpenseTotalOfUnpaidInvoices.AutoSize = true;
            this.ExpenseTotalOfUnpaidInvoices.Location = new System.Drawing.Point(328, 115);
            this.ExpenseTotalOfUnpaidInvoices.Name = "ExpenseTotalOfUnpaidInvoices";
            this.ExpenseTotalOfUnpaidInvoices.Size = new System.Drawing.Size(41, 13);
            this.ExpenseTotalOfUnpaidInvoices.TabIndex = 7;
            this.ExpenseTotalOfUnpaidInvoices.Text = "label20";
            // 
            // numberOfCompleteInvoiceInMonth
            // 
            this.numberOfCompleteInvoiceInMonth.AutoSize = true;
            this.numberOfCompleteInvoiceInMonth.Location = new System.Drawing.Point(224, 25);
            this.numberOfCompleteInvoiceInMonth.Name = "numberOfCompleteInvoiceInMonth";
            this.numberOfCompleteInvoiceInMonth.Size = new System.Drawing.Size(41, 13);
            this.numberOfCompleteInvoiceInMonth.TabIndex = 8;
            this.numberOfCompleteInvoiceInMonth.Text = "label21";
            // 
            // ExpenseOfCompleteInvoiceInMonth
            // 
            this.ExpenseOfCompleteInvoiceInMonth.AutoSize = true;
            this.ExpenseOfCompleteInvoiceInMonth.Location = new System.Drawing.Point(328, 25);
            this.ExpenseOfCompleteInvoiceInMonth.Name = "ExpenseOfCompleteInvoiceInMonth";
            this.ExpenseOfCompleteInvoiceInMonth.Size = new System.Drawing.Size(41, 13);
            this.ExpenseOfCompleteInvoiceInMonth.TabIndex = 10;
            this.ExpenseOfCompleteInvoiceInMonth.Text = "label23";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 144);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(132, 13);
            this.label25.TabIndex = 12;
            this.label25.Text = "Nombre total de factures : ";
            // 
            // NumberTotalOfInvoice
            // 
            this.NumberTotalOfInvoice.AutoSize = true;
            this.NumberTotalOfInvoice.Location = new System.Drawing.Point(224, 145);
            this.NumberTotalOfInvoice.Name = "NumberTotalOfInvoice";
            this.NumberTotalOfInvoice.Size = new System.Drawing.Size(41, 13);
            this.NumberTotalOfInvoice.TabIndex = 13;
            this.NumberTotalOfInvoice.Text = "label15";
            // 
            // ExpenseTotalOfInvoice
            // 
            this.ExpenseTotalOfInvoice.AutoSize = true;
            this.ExpenseTotalOfInvoice.Location = new System.Drawing.Point(328, 145);
            this.ExpenseTotalOfInvoice.Name = "ExpenseTotalOfInvoice";
            this.ExpenseTotalOfInvoice.Size = new System.Drawing.Size(41, 13);
            this.ExpenseTotalOfInvoice.TabIndex = 14;
            this.ExpenseTotalOfInvoice.Text = "label27";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(286, 145);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 13);
            this.label28.TabIndex = 15;
            this.label28.Text = "soit";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(286, 85);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(23, 13);
            this.label29.TabIndex = 16;
            this.label29.Text = "soit";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(286, 115);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(23, 13);
            this.label30.TabIndex = 17;
            this.label30.Text = "soit";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(286, 25);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(23, 13);
            this.label31.TabIndex = 18;
            this.label31.Text = "soit";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(286, 55);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 13);
            this.label34.TabIndex = 26;
            this.label34.Text = "soit";
            // 
            // ExpenseOfCompleteInvoiceInYear
            // 
            this.ExpenseOfCompleteInvoiceInYear.AutoSize = true;
            this.ExpenseOfCompleteInvoiceInYear.Location = new System.Drawing.Point(328, 55);
            this.ExpenseOfCompleteInvoiceInYear.Name = "ExpenseOfCompleteInvoiceInYear";
            this.ExpenseOfCompleteInvoiceInYear.Size = new System.Drawing.Size(41, 13);
            this.ExpenseOfCompleteInvoiceInYear.TabIndex = 24;
            this.ExpenseOfCompleteInvoiceInYear.Text = "label36";
            // 
            // numberOfCompleteInvoiceInYear
            // 
            this.numberOfCompleteInvoiceInYear.AutoSize = true;
            this.numberOfCompleteInvoiceInYear.Location = new System.Drawing.Point(224, 55);
            this.numberOfCompleteInvoiceInYear.Name = "numberOfCompleteInvoiceInYear";
            this.numberOfCompleteInvoiceInYear.Size = new System.Drawing.Size(41, 13);
            this.numberOfCompleteInvoiceInYear.TabIndex = 22;
            this.numberOfCompleteInvoiceInYear.Text = "label38";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(5, 54);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(203, 13);
            this.label40.TabIndex = 20;
            this.label40.Text = "Nombre de factures payées cette année :";
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.CommentsContainer.ResumeLayout(false);
            this.CommentsContainer.PerformLayout();
            this.Statistiques.ResumeLayout(false);
            this.Statistiques.PerformLayout();
            this.Factures.ResumeLayout(false);
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
        private System.Windows.Forms.ListView invoices;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader code_postal;
        private System.Windows.Forms.ColumnHeader pays;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader Iden;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label NumberTotalOfPaidInvoices;
        private System.Windows.Forms.Label ExpenseOfCompleteInvoiceInMonth;
        private System.Windows.Forms.Label numberOfCompleteInvoiceInMonth;
        private System.Windows.Forms.Label ExpenseTotalOfUnpaidInvoices;
        private System.Windows.Forms.Label NumberTotalOfUnpaidInvoices;
        private System.Windows.Forms.Label ExpenseTotalOfPaidInvoices;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label ExpenseTotalOfInvoice;
        private System.Windows.Forms.Label NumberTotalOfInvoice;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label ExpenseOfCompleteInvoiceInYear;
        private System.Windows.Forms.Label numberOfCompleteInvoiceInYear;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
    }
}