namespace Ouatelse.Forms
{
    partial class InvoiceForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.label11 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.validateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adresseClient = new System.Windows.Forms.TextBox();
            this.nomClient = new System.Windows.Forms.TextBox();
            this.adresseClient2 = new System.Windows.Forms.TextBox();
            this.villeClient = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.items = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.aRendre = new System.Windows.Forms.TextBox();
            this.aRegler = new System.Windows.Forms.TextBox();
            this.aRendreLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.regle = new System.Windows.Forms.NumericUpDown();
            this.methodePaiement = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.reduction = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.quickAdd = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.totalHT = new System.Windows.Forms.TextBox();
            this.totalTVA = new System.Windows.Forms.TextBox();
            this.totalTTC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(404, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 113;
            this.label11.Text = "Nom: ";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(547, 18);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 40);
            this.cancelButton.TabIndex = 112;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // validateButton
            // 
            this.validateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.validateButton.FlatAppearance.BorderSize = 0;
            this.validateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validateButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.validateButton.Location = new System.Drawing.Point(646, 18);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(89, 40);
            this.validateButton.TabIndex = 111;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = false;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Ville :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 108;
            this.label4.Text = "Adresse: ";
            // 
            // adresseClient
            // 
            this.adresseClient.Location = new System.Drawing.Point(443, 145);
            this.adresseClient.Name = "adresseClient";
            this.adresseClient.ReadOnly = true;
            this.adresseClient.Size = new System.Drawing.Size(236, 20);
            this.adresseClient.TabIndex = 99;
            // 
            // nomClient
            // 
            this.nomClient.Location = new System.Drawing.Point(443, 119);
            this.nomClient.Name = "nomClient";
            this.nomClient.ReadOnly = true;
            this.nomClient.Size = new System.Drawing.Size(236, 20);
            this.nomClient.TabIndex = 98;
            // 
            // adresseClient2
            // 
            this.adresseClient2.Location = new System.Drawing.Point(443, 171);
            this.adresseClient2.Name = "adresseClient2";
            this.adresseClient2.ReadOnly = true;
            this.adresseClient2.Size = new System.Drawing.Size(236, 20);
            this.adresseClient2.TabIndex = 100;
            // 
            // villeClient
            // 
            this.villeClient.Location = new System.Drawing.Point(443, 197);
            this.villeClient.Name = "villeClient";
            this.villeClient.ReadOnly = true;
            this.villeClient.Size = new System.Drawing.Size(236, 20);
            this.villeClient.TabIndex = 101;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(56, 107);
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Size = new System.Drawing.Size(190, 20);
            this.code.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Ref :";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(56, 133);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(190, 20);
            this.date.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Date :";
            // 
            // items
            // 
            this.items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.items.GridLines = true;
            this.items.Location = new System.Drawing.Point(12, 230);
            this.items.MaximumSize = new System.Drawing.Size(723, 300);
            this.items.MinimumSize = new System.Drawing.Size(723, 183);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(723, 232);
            this.items.StateImageList = this.imageList1;
            this.items.TabIndex = 116;
            this.items.UseCompatibleStateImageBehavior = false;
            this.items.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ref";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Désignation";
            this.columnHeader2.Width = 353;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qte";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 47;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prix U";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prix HT";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 117;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 24);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.aRendre);
            this.groupBox1.Controls.Add(this.aRegler);
            this.groupBox1.Controls.Add(this.aRendreLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.regle);
            this.groupBox1.Controls.Add(this.methodePaiement);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 502);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 116);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Réglement de la Facture";
            // 
            // aRendre
            // 
            this.aRendre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRendre.Location = new System.Drawing.Point(261, 83);
            this.aRendre.Name = "aRendre";
            this.aRendre.ReadOnly = true;
            this.aRendre.Size = new System.Drawing.Size(103, 26);
            this.aRendre.TabIndex = 112;
            this.aRendre.Text = "0,00";
            this.aRendre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aRegler
            // 
            this.aRegler.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRegler.Location = new System.Drawing.Point(261, 20);
            this.aRegler.Name = "aRegler";
            this.aRegler.ReadOnly = true;
            this.aRegler.Size = new System.Drawing.Size(103, 26);
            this.aRegler.TabIndex = 112;
            this.aRegler.Text = "0,00";
            this.aRegler.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aRendreLabel
            // 
            this.aRendreLabel.Location = new System.Drawing.Point(166, 83);
            this.aRendreLabel.Name = "aRendreLabel";
            this.aRendreLabel.Size = new System.Drawing.Size(88, 26);
            this.aRendreLabel.TabIndex = 3;
            this.aRendreLabel.Text = "A rendre :";
            this.aRendreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Réglé :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "A régler :";
            // 
            // regle
            // 
            this.regle.DecimalPlaces = 2;
            this.regle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regle.Location = new System.Drawing.Point(261, 52);
            this.regle.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.regle.Name = "regle";
            this.regle.Size = new System.Drawing.Size(103, 26);
            this.regle.TabIndex = 2;
            this.regle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.regle.ThousandsSeparator = true;
            this.regle.ValueChanged += new System.EventHandler(this.regle_ValueChanged);
            // 
            // methodePaiement
            // 
            this.methodePaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodePaiement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodePaiement.FormattingEnabled = true;
            this.methodePaiement.Location = new System.Drawing.Point(6, 46);
            this.methodePaiement.Name = "methodePaiement";
            this.methodePaiement.Size = new System.Drawing.Size(170, 33);
            this.methodePaiement.TabIndex = 1;
            this.methodePaiement.SelectedIndexChanged += new System.EventHandler(this.methodePaiement_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(377, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 91);
            this.button1.TabIndex = 111;
            this.button1.Text = "Régler la Facture";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Méthode de Paiement :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 479);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total HT :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 511);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "TVA :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(514, 579);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Total TTC :";
            // 
            // reduction
            // 
            this.reduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reduction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduction.Location = new System.Drawing.Point(591, 536);
            this.reduction.Name = "reduction";
            this.reduction.Size = new System.Drawing.Size(120, 26);
            this.reduction.TabIndex = 2;
            this.reduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.reduction.ThousandsSeparator = true;
            this.reduction.ValueChanged += new System.EventHandler(this.reduction_ValueChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(506, 542);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Réduction (%) :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 23);
            this.button2.TabIndex = 118;
            this.button2.Text = "Sélection Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 40);
            this.label1.TabIndex = 120;
            this.label1.Text = "Edition d\'une facture";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.Ouatelse_full_05;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(118, -8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(715, 90);
            this.label15.TabIndex = 121;
            // 
            // quickAdd
            // 
            this.quickAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quickAdd.Location = new System.Drawing.Point(12, 473);
            this.quickAdd.Name = "quickAdd";
            this.quickAdd.Size = new System.Drawing.Size(113, 20);
            this.quickAdd.TabIndex = 122;
            this.quickAdd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.quickAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.No;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(127, 468);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 32);
            this.button3.TabIndex = 111;
            this.button3.Text = "Rechercher un produit...";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // totalHT
            // 
            this.totalHT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalHT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHT.Location = new System.Drawing.Point(591, 472);
            this.totalHT.Name = "totalHT";
            this.totalHT.ReadOnly = true;
            this.totalHT.Size = new System.Drawing.Size(120, 26);
            this.totalHT.TabIndex = 112;
            this.totalHT.Text = "0,00";
            this.totalHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTVA
            // 
            this.totalTVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalTVA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTVA.ForeColor = System.Drawing.Color.Gray;
            this.totalTVA.Location = new System.Drawing.Point(591, 504);
            this.totalTVA.Name = "totalTVA";
            this.totalTVA.ReadOnly = true;
            this.totalTVA.Size = new System.Drawing.Size(120, 26);
            this.totalTVA.TabIndex = 112;
            this.totalTVA.Text = "0,00";
            this.totalTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalTTC
            // 
            this.totalTTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalTTC.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTTC.Location = new System.Drawing.Point(591, 568);
            this.totalTTC.Name = "totalTTC";
            this.totalTTC.ReadOnly = true;
            this.totalTTC.Size = new System.Drawing.Size(120, 32);
            this.totalTTC.TabIndex = 112;
            this.totalTTC.Text = "0,00";
            this.totalTTC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 630);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.totalTTC);
            this.Controls.Add(this.totalTVA);
            this.Controls.Add(this.totalHT);
            this.Controls.Add(this.quickAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.items);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reduction);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adresseClient);
            this.Controls.Add(this.code);
            this.Controls.Add(this.nomClient);
            this.Controls.Add(this.adresseClient2);
            this.Controls.Add(this.villeClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(763, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(763, 613);
            this.Name = "InvoiceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facture";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adresseClient;
        private System.Windows.Forms.TextBox nomClient;
        private System.Windows.Forms.TextBox adresseClient2;
        private System.Windows.Forms.TextBox villeClient;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView items;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox methodePaiement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label aRendreLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown regle;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown reduction;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox quickAdd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox aRendre;
        private System.Windows.Forms.TextBox aRegler;
        private System.Windows.Forms.TextBox totalHT;
        private System.Windows.Forms.TextBox totalTVA;
        private System.Windows.Forms.TextBox totalTTC;
    }
}