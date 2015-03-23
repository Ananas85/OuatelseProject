namespace Ouatelse
{
    partial class ManageProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProductsForm));
            this.newProductButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.modifyProductButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.productListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.designation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pixAchat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prixVente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tva = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ean = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClickProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierCeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lessProduct = new System.Windows.Forms.Label();
            this.bestProduct = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.rightClickProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // newProductButton
            // 
            this.newProductButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newProductButton.FlatAppearance.BorderSize = 0;
            this.newProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProductButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newProductButton.Location = new System.Drawing.Point(5, 143);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(204, 41);
            this.newProductButton.TabIndex = 38;
            this.newProductButton.Text = "Nouveau produit";
            this.newProductButton.UseVisualStyleBackColor = false;
            this.newProductButton.Click += new System.EventHandler(this.NewProduct_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(5, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 41);
            this.button3.TabIndex = 41;
            this.button3.Text = "Réapprovisionner";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.RestockProduct_Click);
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.Color.IndianRed;
            this.deleteProductButton.FlatAppearance.BorderSize = 0;
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProductButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteProductButton.Location = new System.Drawing.Point(425, 143);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(204, 41);
            this.deleteProductButton.TabIndex = 40;
            this.deleteProductButton.Text = "Supprimer un produit";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Visible = false;
            this.deleteProductButton.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // modifyProductButton
            // 
            this.modifyProductButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.modifyProductButton.FlatAppearance.BorderSize = 0;
            this.modifyProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyProductButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modifyProductButton.Location = new System.Drawing.Point(215, 143);
            this.modifyProductButton.Name = "modifyProductButton";
            this.modifyProductButton.Size = new System.Drawing.Size(204, 41);
            this.modifyProductButton.TabIndex = 39;
            this.modifyProductButton.Text = "Modifier un produit";
            this.modifyProductButton.UseVisualStyleBackColor = false;
            this.modifyProductButton.Click += new System.EventHandler(this.ModifyProduct_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(215, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 41);
            this.button4.TabIndex = 42;
            this.button4.Text = "Déstocker";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DestockProduct_Click);
            // 
            // productListView
            // 
            this.productListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.nom,
            this.designation,
            this.pixAchat,
            this.prixVente,
            this.tva,
            this.ean,
            this.stock});
            this.productListView.ContextMenuStrip = this.rightClickProduct;
            this.productListView.FullRowSelect = true;
            this.productListView.GridLines = true;
            this.productListView.Location = new System.Drawing.Point(5, 244);
            this.productListView.Margin = new System.Windows.Forms.Padding(2);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(897, 254);
            this.productListView.TabIndex = 37;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.Details;
            this.productListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ProductListView_ColumnClick);
            this.productListView.ItemActivate += new System.EventHandler(this.ProductListView_ItemActivate);
            this.productListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productListView_MouseClick);
            this.productListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productListView_MouseDoubleClick);
            // 
            // id
            // 
            this.id.Text = "Référence";
            this.id.Width = 65;
            // 
            // nom
            // 
            this.nom.Text = "Nom";
            this.nom.Width = 143;
            // 
            // designation
            // 
            this.designation.Text = "Désignation";
            this.designation.Width = 129;
            // 
            // pixAchat
            // 
            this.pixAchat.Text = "Prix d\'achat";
            this.pixAchat.Width = 95;
            // 
            // prixVente
            // 
            this.prixVente.Text = "Prix de vente";
            this.prixVente.Width = 106;
            // 
            // tva
            // 
            this.tva.Text = "TVA";
            this.tva.Width = 63;
            // 
            // ean
            // 
            this.ean.Text = "Code EAN";
            this.ean.Width = 136;
            // 
            // stock
            // 
            this.stock.Text = "Stock";
            this.stock.Width = 74;
            // 
            // rightClickProduct
            // 
            this.rightClickProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierCeProduitToolStripMenuItem,
            this.supprimerCeProduitToolStripMenuItem});
            this.rightClickProduct.Name = "rightClickCustomer";
            this.rightClickProduct.Size = new System.Drawing.Size(187, 70);
            // 
            // modifierCeProduitToolStripMenuItem
            // 
            this.modifierCeProduitToolStripMenuItem.Name = "modifierCeProduitToolStripMenuItem";
            this.modifierCeProduitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.modifierCeProduitToolStripMenuItem.Text = "Modifier ce produit";
            // 
            // supprimerCeProduitToolStripMenuItem
            // 
            this.supprimerCeProduitToolStripMenuItem.Name = "supprimerCeProduitToolStripMenuItem";
            this.supprimerCeProduitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.supprimerCeProduitToolStripMenuItem.Text = "Supprimer ce produit";
            this.supprimerCeProduitToolStripMenuItem.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Ouatelse.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(632, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(671, 200);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(231, 26);
            this.searchBox.TabIndex = 43;
            this.searchBox.TextChanged += new System.EventHandler(this.Reload);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.BackColor = System.Drawing.Color.Transparent;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.Color.White;
            this.customerLabel.Location = new System.Drawing.Point(165, 35);
            this.customerLabel.MinimumSize = new System.Drawing.Size(360, 47);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(360, 47);
            this.customerLabel.TabIndex = 47;
            this.customerLabel.Text = "Gestion des produits";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(567, -25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 142);
            this.label1.TabIndex = 46;
            // 
            // ProductsNumber
            // 
            this.ProductsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsNumber.Location = new System.Drawing.Point(776, 500);
            this.ProductsNumber.Name = "ProductsNumber";
            this.ProductsNumber.Size = new System.Drawing.Size(126, 22);
            this.ProductsNumber.TabIndex = 48;
            this.ProductsNumber.Text = "--";
            this.ProductsNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(580, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 25);
            this.label7.TabIndex = 55;
            this.label7.Text = "Statistiques ensemble des magasin";
            // 
            // lessProduct
            // 
            this.lessProduct.AutoSize = true;
            this.lessProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.lessProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessProduct.Location = new System.Drawing.Point(745, 88);
            this.lessProduct.Name = "lessProduct";
            this.lessProduct.Size = new System.Drawing.Size(50, 20);
            this.lessProduct.TabIndex = 53;
            this.lessProduct.Text = "label5";
            // 
            // bestProduct
            // 
            this.bestProduct.AutoSize = true;
            this.bestProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.bestProduct.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestProduct.Location = new System.Drawing.Point(745, 57);
            this.bestProduct.Name = "bestProduct";
            this.bestProduct.Size = new System.Drawing.Size(50, 20);
            this.bestProduct.TabIndex = 52;
            this.bestProduct.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Produit le moins vendu : ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(553, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(159, 20);
            this.label.TabIndex = 49;
            this.label.Text = "Produit le plus vendu : ";
            // 
            // ManageProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ouatelse.Properties.Resources.Ouatelse_073;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 516);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lessProduct);
            this.Controls.Add(this.bestProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ProductsNumber);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.newProductButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.modifyProductButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.productListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(855, 555);
            this.Name = "ManageProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion des produits / stock";
            this.rightClickProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newProductButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Button modifyProductButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader nom;
        private System.Windows.Forms.ColumnHeader designation;
        private System.Windows.Forms.ColumnHeader pixAchat;
        private System.Windows.Forms.ColumnHeader prixVente;
        private System.Windows.Forms.ColumnHeader tva;
        private System.Windows.Forms.ColumnHeader ean;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductsNumber;
        private System.Windows.Forms.ContextMenuStrip rightClickProduct;
        private System.Windows.Forms.ToolStripMenuItem modifierCeProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerCeProduitToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lessProduct;
        private System.Windows.Forms.Label bestProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;

    }
}