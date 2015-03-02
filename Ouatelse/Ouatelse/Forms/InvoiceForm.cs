using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace Ouatelse.Forms
{
    public partial class InvoiceForm : Form
    {
        private Invoice invoice;
        private bool newInvoice = false;

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

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            /*Invoice invoice = new Invoice()
            {
                Employee = EmployeeManager.Instance.First(""),
                Payment = PaymentManager.Instance.First(""),
                Customer = CustomerManager.Instance.First("")
            };
            InvoiceManager.Instance.Save(invoice);

            Utils.Info(Database.Instance.LastInsertId.ToString());*/

            List<Payment> methodes = new List<Payment>(PaymentManager.Instance.All());
            this.methodePaiement.ValueMember = "Id";
            this.methodePaiement.DisplayMember = "Type";
            this.methodePaiement.DataSource = methodes;

            this.code.Text = string.Format("{0}{1}", invoice.Id, (newInvoice ? " (Nouveau)" : ""));
            ReloadCustomer();
            ReloadProducts();
        }

        public void ReloadCustomer()
        {
            this.nomClient.Text = invoice.Customer == null ? "" : (invoice.Customer.Gender.Name + " " + invoice.Customer.FullName);
            this.adresseClient.Text = invoice.Customer == null ? "" : invoice.Customer.Address1;
            this.adresseClient2.Text = invoice.Customer == null ? "" : invoice.Customer.Address2;
            this.villeClient.Text = invoice.Customer == null
                ? ""
                : (invoice.Customer.City.PostalCode + " " + invoice.Customer.City.Name);
        }

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
                item.Tag = invoiceProduct;
            }

            ReloadTotals();
        }

        private void ReloadTotals()
        {
            CultureInfo fr = CultureInfo.GetCultureInfo("fr-FR");
            this.totalHT.Text = invoice.TotalHT.ToString("C", fr);
            this.totalTVA.Text = invoice.TotalTVA.ToString("C", fr);
            this.totalTTC.Text = invoice.TotalTTC.ToString("C", fr);
            this.aRegler.Text = invoice.TotalTTC.ToString("C", fr);
            ReloadArendre();
        }

        public void ReloadArendre()
        {
            double montant = (double)this.regle.Value;
            double reste = invoice.TotalTTC - montant;
            this.aRendreLabel.Text = reste > 0 ? "Reste" : "A rendre";
            this.aRendre.Text = Math.Abs(reste).ToString("C", CultureInfo.GetCultureInfo("fr-FR"));
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (newInvoice)
            {
                invoice.Products.DeleteAll();
                InvoiceManager.Instance.Delete(invoice);
            }
            this.DialogResult = DialogResult.Cancel;
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            if (invoice.Customer == null)
            {
                Utils.Warning("ATTENTION !\n\nAucun Client n'a été choisi !");
                DialogResult = DialogResult.None;
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerPickerForm form = new CustomerPickerForm();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            invoice.Customer = form.GetCustomer();
            ReloadCustomer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

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
            foreach (InvoiceProduct invoiceProduct in invoice.Products.Items)
            {
                if (product.EANCode == invoiceProduct.Product.EANCode)
                {
                    invoiceProduct.Quantity++;
                    InvoiceProductManager.Instance.Save(invoiceProduct);
                    ReloadProducts();
                    this.quickAdd.Text = "";
                    this.quickAdd.SelectAll();
                    return;
                }
            }

            invoice.AddProduct(product);
            ReloadProducts();
            this.quickAdd.Text = "";
            this.quickAdd.SelectAll();
        }

        private void reduction_ValueChanged(object sender, EventArgs e)
        {
            invoice.DiscountPercent = (float)this.reduction.Value;
            ReloadTotals();
        }

        private void regle_ValueChanged(object sender, EventArgs e)
        {
            ReloadArendre();
        }
    }
}
