namespace Ouatelse.Forms
{
    partial class ProductsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newProductBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listView_products = new System.Windows.Forms.ListView();
            this.reference_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.designation_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buyprice_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sellprice_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tva_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ean_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Gestion du stock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 82);
            this.panel1.TabIndex = 33;
            // 
            // newProductBtn
            // 
            this.newProductBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newProductBtn.FlatAppearance.BorderSize = 0;
            this.newProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProductBtn.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProductBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newProductBtn.Location = new System.Drawing.Point(5, 88);
            this.newProductBtn.Name = "newProductBtn";
            this.newProductBtn.Size = new System.Drawing.Size(204, 41);
            this.newProductBtn.TabIndex = 38;
            this.newProductBtn.Text = "Nouveau produit";
            this.newProductBtn.UseVisualStyleBackColor = false;
            this.newProductBtn.Click += new System.EventHandler(this.newProductBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(5, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 41);
            this.button3.TabIndex = 41;
            this.button3.Text = "Réapprovisionner";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(425, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 41);
            this.button2.TabIndex = 40;
            this.button2.Text = "Supprimer un produit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(215, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "Modifier un produit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(215, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 41);
            this.button4.TabIndex = 42;
            this.button4.Text = "Déstocker";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // listView_products
            // 
            this.listView_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reference_column,
            this.name_column,
            this.designation_column,
            this.buyprice_column,
            this.sellprice_column,
            this.tva_column,
            this.ean_column});
            this.listView_products.Location = new System.Drawing.Point(5, 181);
            this.listView_products.Margin = new System.Windows.Forms.Padding(2);
            this.listView_products.Name = "listView_products";
            this.listView_products.Size = new System.Drawing.Size(672, 156);
            this.listView_products.TabIndex = 37;
            this.listView_products.UseCompatibleStateImageBehavior = false;
            this.listView_products.View = System.Windows.Forms.View.Details;
            // 
            // reference_column
            // 
            this.reference_column.Text = "Référence";
            this.reference_column.Width = 65;
            // 
            // name_column
            // 
            this.name_column.Text = "Nom";
            this.name_column.Width = 124;
            // 
            // designation_column
            // 
            this.designation_column.Text = "Désignation";
            this.designation_column.Width = 129;
            // 
            // buyprice_column
            // 
            this.buyprice_column.Text = "Prix d\'achat";
            this.buyprice_column.Width = 95;
            // 
            // sellprice_column
            // 
            this.sellprice_column.Text = "Prix de vente";
            this.sellprice_column.Width = 89;
            // 
            // tva_column
            // 
            this.tva_column.Text = "TVA";
            this.tva_column.Width = 74;
            // 
            // ean_column
            // 
            this.ean_column.Text = "Code EAN";
            this.ean_column.Width = 163;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 348);
            this.Controls.Add(this.newProductBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView_products);
            this.Controls.Add(this.panel1);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion du stock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newProductBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView listView_products;
        private System.Windows.Forms.ColumnHeader reference_column;
        private System.Windows.Forms.ColumnHeader name_column;
        private System.Windows.Forms.ColumnHeader designation_column;
        private System.Windows.Forms.ColumnHeader buyprice_column;
        private System.Windows.Forms.ColumnHeader sellprice_column;
        private System.Windows.Forms.ColumnHeader tva_column;
        private System.Windows.Forms.ColumnHeader ean_column;

    }
}