using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace Ouatelse.Forms
{
    /// <summary>
    /// Classe pour gérer les nouvelles factures
    /// </summary>
    public partial class InvoiceForm : Form
    {
        #region Les attributs de la classe
        private Invoice invoice;
        private bool newInvoice = false;
        private Product preferedProduct = null;
        #endregion

        #region Le constructeur de la classe
        public InvoiceForm(Invoice invoice)
        {
            this.invoice = invoice;
            newInvoice = !invoice.Exists;
            if (newInvoice)
            {
                invoice.Employee = AuthManager.Instance.User;
                invoice.Payment = PaymentManager.Instance.First("");
                InvoiceManager.Instance.Save(invoice);
            }
            InitializeComponent();
        }
        #endregion

        #region La réaction au chargement de la forme
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            List<Payment> methods = new List<Payment>(PaymentManager.Instance.All());
            this.PaymentMethods.ValueMember = "Id";
            this.PaymentMethods.DisplayMember = "Type";
            this.PaymentMethods.DataSource = methods;

            this.reduct.Value = (decimal) invoice.DiscountPercent;
            this.PaymentMethods.SelectedItem = invoice.Payment;
            this.date.Value = invoice.Date;

            this.code.Text = string.Format("{0}{1}", invoice.Id, (newInvoice ? " (Nouveau)" : ""));
            ReloadCustomer();
            ReloadProducts();
            ReloadLock();
        }
        #endregion

        #region Le chargement des données clients
        public void ReloadCustomer()
        {
            this.customerName.Text = invoice.Customer == null ? "" : (invoice.Customer.Gender.Name + " " + invoice.Customer.FullName);
            this.customerAdress.Text = invoice.Customer == null ? "" : invoice.Customer.Address1;
            this.customerAdress2.Text = invoice.Customer == null ? "" : invoice.Customer.Address2;
            this.customerCity.Text = invoice.Customer == null
                ? ""
                : (invoice.Customer.City.PostalCode + " " + invoice.Customer.City.Name);

            if (invoice.Customer != null)
            {
                Dictionary<Product, int> preferedProdcuts = invoice.Customer.PreferedProdcuts;
                if (preferedProdcuts.Count > 0)
                {
                    int qty = preferedProdcuts.First().Value;
                    if (qty > 0)
                        preferedProduct = preferedProdcuts.First().Key;
                }
            }
        }
        #endregion

        #region Le chargement des produits
        public void ReloadProducts()
        {
            this.items.Items.Clear();
            foreach (InvoiceProduct invoiceProduct in invoice.Products.Items)
            {
                Product product = invoiceProduct.Product;
                ListViewItem item = this.items.Items.Add(product.Name);
                item.SubItems.Add(product.Designation);
                item.SubItems.Add(invoiceProduct.Quantity.ToString());
                item.SubItems.Add(product.SellPrice.ToString("0.00", CultureInfo.InvariantCulture));
                item.SubItems.Add(invoiceProduct.Price.ToString("0.00", CultureInfo.InvariantCulture));
                if (product.Id == preferedProduct.Id)
                    item.BackColor = Color.AntiqueWhite;
                item.Tag = invoiceProduct;
            }

            ReloadTotals();
        }
        #endregion

        #region Le chargement du total
        private void ReloadTotals()
        {
            CultureInfo fr = CultureInfo.GetCultureInfo("fr-FR");
            this.totalHT.Text = invoice.TotalHT.ToString("C", fr);
            this.totalTVA.Text = invoice.TotalTVA.ToString("C", fr);
            this.totalTTC.Text = invoice.TotalTTC.ToString("C", fr);
            this.toPay.Text = invoice.TotalTTC.ToString("C", fr);
            this.rule.Value = this.rule.Enabled ? (decimal) invoice.PaidAmount : (decimal) invoice.TotalTTC;
            ReloadToPay();
        }
        #endregion

        #region Le chargement du reste à payer
        public void ReloadToPay()
        {
            double amount = (double)this.rule.Value;
            double rest = invoice.TotalTTC - amount;
            this.toPayLabel.Text = rest > 0 ? "Reste" : "A rendre";
            this.toPayText.Text = Math.Abs(rest).ToString("C", CultureInfo.GetCultureInfo("fr-FR"));
        }
        #endregion

        #region Pout gérer les interdits
        public void ReloadLock()
        {
            this.button1.Enabled = !invoice.IsPaid;
            this.button2.Enabled = !invoice.IsPaid;
            this.quickAdd.Enabled = !invoice.IsPaid;
            this.rule.Enabled = !invoice.IsPaid;
            this.items.Enabled = !invoice.IsPaid;
            this.date.Enabled = !invoice.IsPaid;
            this.reduct.Enabled = !invoice.IsPaid;
        }
        #endregion

        #region Gestion du bouton annuler
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (newInvoice)
            {
                invoice.Products.DeleteAll();
                InvoiceManager.Instance.Delete(invoice);
            }
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region Gestion du bouton valider
        private void validateButton_Click(object sender, EventArgs e)
        {
            if (invoice.Customer == null)
            {
                Utils.Warning("ATTENTION !\n\nAucun Client n'a été choisi !");
                DialogResult = DialogResult.None;
                return;
            }

            invoice.Date = this.date.Value;
            invoice.DiscountPercent = (float) this.reduct.Value;
            invoice.PaidAmount = (float) this.rule.Value;
            invoice.Payment = (Payment) this.PaymentMethods.SelectedItem;

            InvoiceManager.Instance.Save(invoice);
            DialogResult = DialogResult.OK;
        }
        #endregion

        #region Gestion de la sélection de client
        private void button2_Click(object sender, EventArgs e)
        {
            CustomerPickerForm form = new CustomerPickerForm();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            invoice.Customer = form.GetCustomer();
            ReloadCustomer();
        }
        #endregion

        #region Gestion des entrées 
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Return) return;

            Product product = ProductManager.Instance.First(string.Format("WHERE code_ean = '{0}'", this.quickAdd.Text));
            if (product == null)
            {
                Utils.Warning("Aucun produit n'existe avec le code EAN \"" + this.quickAdd.Text + "\" !");
                this.quickAdd.SelectAll();
                return;
            }

            // On regarde si il n'existe pas déjà un produit
            foreach (InvoiceProduct invoiceProduct in invoice.Products.Items.Where(invoiceProduct => product.EANCode == invoiceProduct.Product.EANCode))
            {
                invoiceProduct.Quantity++;
                InvoiceProductManager.Instance.Save(invoiceProduct);
                ReloadProducts();
                this.quickAdd.Text = "";
                this.quickAdd.SelectAll();
                return;
            }

            invoice.AddProduct(product);
            ReloadProducts();
            this.quickAdd.Text = "";
            this.quickAdd.SelectAll();
        }
        #endregion

        #region Si la valeur de la réduction change
        private void reduction_ValueChanged(object sender, EventArgs e)
        {
            invoice.DiscountPercent = (float)this.reduct.Value;
            ReloadTotals();
        }
        #endregion

        #region Si la valeur de la règle change
        private void regle_ValueChanged(object sender, EventArgs e)
        {
            ReloadToPay();
        }
        #endregion

        #region Si l'on clique sur le bouton valider
        private void button1_Click(object sender, EventArgs e)
        {
            if (invoice.Customer == null)
            {
                Utils.Warning("Veuillez sélectionner un client d'abord !");
                return;
            }
            invoice.PaidAmount = (float) this.rule.Value;
            if (invoice.PaidAmount < (float) invoice.TotalTTC)
            {
                Utils.Warning(
                    string.Format(
                        "Attention !\n\nLa facture n'a pas été réglé dans son intégralité !\nIl reste {0} à régler",
                        invoice.Reste.ToString("C", CultureInfo.GetCultureInfo("fr"))));
            }
            else if (invoice.PaidAmount > (float) invoice.TotalTTC)
            {
                Utils.Warning(
                    string.Format(
                        "Attention !\n\nIl faut rendre {0} !",
                        invoice.Arendre.ToString("C", CultureInfo.GetCultureInfo("fr"))));
                invoice.PaidAmount = (float) invoice.TotalTTC;
            }

            if (invoice.PaidAmount == (float)invoice.TotalTTC)
            {
                invoice.IsPaid = true;
                InvoiceManager.Instance.Save(invoice);
                Utils.Notify("Facture réglée");
                ReloadTotals();
                ReloadLock();
            }
        }
        #endregion

        #region Si la méthode de paiement change
        private void methodePaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.PaymentMethods.Text == @"CB" || this.PaymentMethods.Text == @"Chèque")
            {
                this.rule.Value = (decimal) invoice.TotalTTC;
                this.rule.Enabled = false;
            }
            else
            {
                this.rule.Value = (decimal)invoice.PaidAmount;
                this.rule.Enabled = true;
            }
        }
        #endregion

        #region Si La l'on double clique sur un produit
        private void items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.items.GetItemAt(e.X, e.Y);
            if (item == null)
                return;
            InvoiceProduct product = (InvoiceProduct) item.Tag;

            QuantityForm form = new QuantityForm(product);
            if (form.ShowDialog() != DialogResult.OK)
                return;
            product.Quantity = (int) form.Quantity;
            ReloadProducts();
        }
        #endregion
    }
}
