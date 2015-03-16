namespace Ouatelse.Forms
{
    partial class SalesForm
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
            this.counter = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.items = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code_postal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.villes_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // counter
            // 
            this.counter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.counter.Location = new System.Drawing.Point(869, 608);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(126, 22);
            this.counter.TabIndex = 131;
            this.counter.Text = "--";
            this.counter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Ouatelse.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(750, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 130;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteBtn.Location = new System.Drawing.Point(488, 134);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(232, 41);
            this.deleteBtn.TabIndex = 129;
            this.deleteBtn.Text = "Supprimer une Facture";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.editBtn.Location = new System.Drawing.Point(250, 134);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(232, 41);
            this.editBtn.TabIndex = 128;
            this.editBtn.Text = "Modifier une Facture";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addBtn.Location = new System.Drawing.Point(12, 134);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(232, 41);
            this.addBtn.TabIndex = 127;
            this.addBtn.Text = "Nouvelle Facture";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // items
            // 
            this.items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.adresse,
            this.prenom,
            this.code_postal,
            this.villes_id,
            this.pays,
            this.columnHeader1});
            this.items.FullRowSelect = true;
            this.items.GridLines = true;
            this.items.Location = new System.Drawing.Point(12, 181);
            this.items.MultiSelect = false;
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(983, 424);
            this.items.TabIndex = 126;
            this.items.UseCompatibleStateImageBehavior = false;
            this.items.View = System.Windows.Forms.View.Details;
            this.items.MouseClick += new System.Windows.Forms.MouseEventHandler(this.items_MouseClick);
            this.items.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.items_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Name = "id";
            this.id.Text = "Ref";
            this.id.Width = 50;
            // 
            // adresse
            // 
            this.adresse.Name = "adresse";
            this.adresse.Text = "Date";
            this.adresse.Width = 80;
            // 
            // prenom
            // 
            this.prenom.Name = "prenom";
            this.prenom.Text = "Client";
            this.prenom.Width = 140;
            // 
            // code_postal
            // 
            this.code_postal.Name = "code_postal";
            this.code_postal.Text = "Produits";
            this.code_postal.Width = 350;
            // 
            // villes_id
            // 
            this.villes_id.Name = "villes_id";
            this.villes_id.Text = "Prix HT";
            this.villes_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.villes_id.Width = 100;
            // 
            // pays
            // 
            this.pays.Name = "pays";
            this.pays.Text = "Prix TTC";
            this.pays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pays.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reglé";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader1.Width = 100;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(788, 143);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(207, 26);
            this.searchBox.TabIndex = 125;
            this.searchBox.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(658, -10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 127);
            this.label1.TabIndex = 132;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.BackColor = System.Drawing.Color.Transparent;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.Color.White;
            this.customerLabel.Location = new System.Drawing.Point(186, 36);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(129, 47);
            this.customerLabel.TabIndex = 133;
            this.customerLabel.Text = "Ventes";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ouatelse.Properties.Resources.Ouatelse_073;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1021, 639);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.items);
            this.Controls.Add(this.searchBox);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ListView items;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader client;
        private System.Windows.Forms.ColumnHeader produits;
        private System.Windows.Forms.ColumnHeader prixHT;
        private System.Windows.Forms.ColumnHeader prixTTC;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ColumnHeader adresse;
        private System.Windows.Forms.ColumnHeader prenom;
        private System.Windows.Forms.ColumnHeader code_postal;
        private System.Windows.Forms.ColumnHeader villes_id;
        private System.Windows.Forms.ColumnHeader pays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}