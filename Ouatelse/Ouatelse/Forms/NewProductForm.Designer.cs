namespace Ouatelse.Forms
{
    partial class NewProductForm
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
            this.nameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.designationTextBox = new System.Windows.Forms.MaskedTextBox();
            this.purchasePriceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sellPriceTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tvaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.eanCodeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(90, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(156, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // designationTextBox
            // 
            this.designationTextBox.Location = new System.Drawing.Point(90, 38);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(156, 20);
            this.designationTextBox.TabIndex = 1;
            // 
            // purchasePriceTextBox
            // 
            this.purchasePriceTextBox.Location = new System.Drawing.Point(90, 64);
            this.purchasePriceTextBox.Name = "purchasePriceTextBox";
            this.purchasePriceTextBox.Size = new System.Drawing.Size(156, 20);
            this.purchasePriceTextBox.TabIndex = 2;
            // 
            // sellPriceTextBox
            // 
            this.sellPriceTextBox.Location = new System.Drawing.Point(90, 90);
            this.sellPriceTextBox.Name = "sellPriceTextBox";
            this.sellPriceTextBox.Size = new System.Drawing.Size(156, 20);
            this.sellPriceTextBox.TabIndex = 3;
            // 
            // tvaTextBox
            // 
            this.tvaTextBox.Location = new System.Drawing.Point(90, 116);
            this.tvaTextBox.Name = "tvaTextBox";
            this.tvaTextBox.Size = new System.Drawing.Size(156, 20);
            this.tvaTextBox.TabIndex = 4;
            // 
            // eanCodeTextBox
            // 
            this.eanCodeTextBox.Location = new System.Drawing.Point(90, 142);
            this.eanCodeTextBox.Name = "eanCodeTextBox";
            this.eanCodeTextBox.Size = new System.Drawing.Size(156, 20);
            this.eanCodeTextBox.TabIndex = 5;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmButton.Location = new System.Drawing.Point(28, 181);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(106, 38);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Valider";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(140, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 38);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Désignation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Prix d\'achat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Prix de vente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "TVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Code EAN";
            // 
            // NewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 232);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.eanCodeTextBox);
            this.Controls.Add(this.tvaTextBox);
            this.Controls.Add(this.sellPriceTextBox);
            this.Controls.Add(this.purchasePriceTextBox);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "NewProductForm";
            this.Text = "Nouveau produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox nameTextBox;
        private System.Windows.Forms.MaskedTextBox designationTextBox;
        private System.Windows.Forms.MaskedTextBox purchasePriceTextBox;
        private System.Windows.Forms.MaskedTextBox sellPriceTextBox;
        private System.Windows.Forms.MaskedTextBox tvaTextBox;
        private System.Windows.Forms.MaskedTextBox eanCodeTextBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}