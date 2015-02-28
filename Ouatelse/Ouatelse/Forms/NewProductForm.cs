using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ouatelse.Managers;
using Ouatelse.Models;

namespace Ouatelse.Forms
{
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Nom du produit invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (designationTextBox.Text == "")
            {
                MessageBox.Show("Désignation du produit invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (purchasePriceTextBox.MaskFull != true)
            {
                MessageBox.Show("Prix d'achat invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sellPriceTextBox.MaskFull != true)
            {
                MessageBox.Show("Prix de vente invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tvaTextBox.MaskFull != true)
            {
                MessageBox.Show("TVA invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (eanCodeTextBox.MaskFull != true)
            {
                MessageBox.Show("Code EAN invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = new Product();
            product.Name = nameTextBox.Text;
            product.Designation = designationTextBox.Text;
            product.PurchasePrice = float.Parse(purchasePriceTextBox.Text);
            product.SellPrice = float.Parse(sellPriceTextBox.Text);
            product.TVA = float.Parse(tvaTextBox.Text);
            product.EANCode = eanCodeTextBox.Text;

            ProductManager.Instance.Save(product);

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
