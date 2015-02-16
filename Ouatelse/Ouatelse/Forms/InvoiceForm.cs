using System;
using System.Collections.Generic;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (newInvoice)
                InvoiceManager.Instance.Delete(invoice);
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
