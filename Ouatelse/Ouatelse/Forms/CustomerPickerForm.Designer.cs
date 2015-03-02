namespace Ouatelse.Forms
{
    partial class CustomerPickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPickerForm));
            this.customerListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code_postal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.villes_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nouveau = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerListView
            // 
            this.customerListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.prenom,
            this.nom,
            this.adresse,
            this.code_postal,
            this.villes_id,
            this.pays});
            this.customerListView.FullRowSelect = true;
            this.customerListView.GridLines = true;
            this.customerListView.Location = new System.Drawing.Point(12, 149);
            this.customerListView.Name = "customerListView";
            this.customerListView.Size = new System.Drawing.Size(882, 240);
            this.customerListView.TabIndex = 9;
            this.customerListView.UseCompatibleStateImageBehavior = false;
            this.customerListView.View = System.Windows.Forms.View.Details;
            this.customerListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customerListView_MouseClick);
            this.customerListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.customerListView_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Name = "id";
            this.id.Text = "Référence";
            this.id.Width = 74;
            // 
            // prenom
            // 
            this.prenom.Name = "prenom";
            this.prenom.Text = "Prénom";
            this.prenom.Width = 108;
            // 
            // nom
            // 
            this.nom.Name = "nom";
            this.nom.Text = "Nom";
            this.nom.Width = 133;
            // 
            // adresse
            // 
            this.adresse.Name = "adresse";
            this.adresse.Text = "Adresse";
            this.adresse.Width = 190;
            // 
            // code_postal
            // 
            this.code_postal.Name = "code_postal";
            this.code_postal.Text = "Code Postal";
            this.code_postal.Width = 113;
            // 
            // villes_id
            // 
            this.villes_id.Name = "villes_id";
            this.villes_id.Text = "Ville";
            this.villes_id.Width = 150;
            // 
            // pays
            // 
            this.pays.Name = "pays";
            this.pays.Text = "Pays";
            this.pays.Width = 89;
            // 
            // nouveau
            // 
            this.nouveau.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.nouveau.FlatAppearance.BorderSize = 0;
            this.nouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveau.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nouveau.Location = new System.Drawing.Point(12, 102);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(184, 41);
            this.nouveau.TabIndex = 22;
            this.nouveau.Text = "Nouveau client";
            this.nouveau.UseVisualStyleBackColor = false;
            this.nouveau.Click += new System.EventHandler(this.nouveau_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ouatelse.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(204, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(242, 111);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(652, 26);
            this.searchBox.TabIndex = 25;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(147, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 47);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sélection d\'un client";
            // 
            // CustomersNumber
            // 
            this.CustomersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersNumber.Location = new System.Drawing.Point(768, 399);
            this.CustomersNumber.Name = "CustomersNumber";
            this.CustomersNumber.Size = new System.Drawing.Size(126, 22);
            this.CustomersNumber.TabIndex = 28;
            this.CustomersNumber.Text = "--";
            this.CustomersNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.Ouatelse_full_05;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(113, -7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(899, 90);
            this.label13.TabIndex = 100;
            // 
            // CustomerPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 423);
            this.Controls.Add(this.CustomersNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.nouveau);
            this.Controls.Add(this.customerListView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(922, 462);
            this.Name = "CustomerPickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sélection d\'un client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView customerListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader code_postal;
        private System.Windows.Forms.ColumnHeader villes_id;
        private System.Windows.Forms.ColumnHeader pays;
        private System.Windows.Forms.Button nouveau;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CustomersNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
    }
}