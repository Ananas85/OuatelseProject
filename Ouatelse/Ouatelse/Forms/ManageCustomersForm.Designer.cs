namespace Ouatelse
{
    partial class ManageCustomersForm
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
            this.customerLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.customerListView = new System.Windows.Forms.ListView();
            this.Référence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodePostal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deletecustomer = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.nouveau = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CustomersNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-27, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(953, 142);
            this.label1.TabIndex = 4;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(151, 44);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(327, 47);
            this.customerLabel.TabIndex = 6;
            this.customerLabel.Text = "Gestion des clients";
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(668, 152);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(231, 26);
            this.searchBox.TabIndex = 7;
            this.searchBox.TextChanged += new System.EventHandler(this.Reload);
            // 
            // customerListView
            // 
            this.customerListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Référence,
            this.Prénom,
            this.Nom,
            this.Adresse,
            this.CodePostal,
            this.Ville,
            this.Pays});
            this.customerListView.FullRowSelect = true;
            this.customerListView.GridLines = true;
            this.customerListView.Location = new System.Drawing.Point(12, 201);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(887, 279);
            this.customerListView.TabIndex = 8;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.View = System.Windows.Forms.View.Details;
            this.customerListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customerListView_MouseClick);
            this.customerListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.customerListView_MouseDoubleClick);
            // 
            // Référence
            // 
            this.Référence.Text = "Référence";
            this.Référence.Width = 74;
            // 
            // Prénom
            // 
            this.Prénom.Text = "Prénom";
            this.Prénom.Width = 108;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 133;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 190;
            // 
            // CodePostal
            // 
            this.CodePostal.Text = "Code Postal";
            this.CodePostal.Width = 113;
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            this.Ville.Width = 150;
            // 
            // Pays
            // 
            this.Pays.Text = "Pays";
            this.Pays.Width = 89;
            // 
            // deletecustomer
            // 
            this.deletecustomer.BackColor = System.Drawing.Color.IndianRed;
            this.deletecustomer.FlatAppearance.BorderSize = 0;
            this.deletecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletecustomer.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletecustomer.Location = new System.Drawing.Point(392, 143);
            this.deletecustomer.Name = "deletecustomer";
            this.deletecustomer.Size = new System.Drawing.Size(191, 41);
            this.deletecustomer.TabIndex = 23;
            this.deletecustomer.Text = "Supprimer un client";
            this.deletecustomer.UseVisualStyleBackColor = false;
            this.deletecustomer.Click += new System.EventHandler(this.deletecustomer_Click);
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.Color.DodgerBlue;
            this.modify.FlatAppearance.BorderSize = 0;
            this.modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modify.Location = new System.Drawing.Point(202, 143);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(184, 41);
            this.modify.TabIndex = 22;
            this.modify.Text = "Modifier un client";
            this.modify.UseVisualStyleBackColor = false;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // nouveau
            // 
            this.nouveau.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.nouveau.FlatAppearance.BorderSize = 0;
            this.nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveau.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nouveau.Location = new System.Drawing.Point(12, 143);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(184, 41);
            this.nouveau.TabIndex = 21;
            this.nouveau.Text = "Nouveau client";
            this.nouveau.UseVisualStyleBackColor = false;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Ouatelse.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(630, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CustomersNumber
            // 
            this.CustomersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersNumber.Location = new System.Drawing.Point(773, 486);
            this.CustomersNumber.Name = "CustomersNumber";
            this.CustomersNumber.Size = new System.Drawing.Size(126, 22);
            this.CustomersNumber.TabIndex = 25;
            this.CustomersNumber.Text = "--";
            this.CustomersNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ManageCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 505);
            this.Controls.Add(this.CustomersNumber);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.deletecustomer);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(929, 544);
            this.Name = "ManageCustomersForm";
            this.Text = "Ouatelse : Gestion des clients";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.ColumnHeader Référence;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.Button deletecustomer;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button nouveau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader Prénom;
        private System.Windows.Forms.ColumnHeader CodePostal;
        private System.Windows.Forms.ColumnHeader Pays;
        private System.Windows.Forms.Label CustomersNumber;


    }
}