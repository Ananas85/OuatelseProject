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
    public partial class SalesForm : Form
    {
        private Invoice selectedInvoice;

        public SalesForm()
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            Invoice[] items = InvoiceManager.Instance.All();

            this.items.Items.Clear();
            foreach (Invoice invoice in items.Where(invoice => invoice.Customer != null))
            {
                ListViewItem item = this.items.Items.Add(invoice.Id.ToString());
                item.UseItemStyleForSubItems = false;
                item.SubItems.Add(invoice.Date.ToShortDateString());
                item.SubItems.Add(invoice.Customer.FullName);
                item.SubItems.Add(invoice.ProductsString);
                item.SubItems.Add(invoice.TotalHT.ToString("C"));
                item.SubItems.Add(invoice.TotalTTC.ToString("C"));
                item.SubItems.Add(invoice.PaidAmount.ToString("C"));
                item.SubItems[0].BackColor = invoice.IsPaid ? Color.LimeGreen : Color.Orange;
                item.SubItems[0].ForeColor = invoice.IsPaid ? Color.White : Color.Black;
                item.Tag = invoice;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            new InvoiceForm(new Invoice()).ShowDialog();
            Reload();
        }

        public void EditSelected()
        {
            if (selectedInvoice == null)
                return;
            new InvoiceForm(selectedInvoice).ShowDialog();
            Reload();
        }

        private void items_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.items.GetItemAt(e.X, e.Y);
            if (item == null)
                return;

            selectedInvoice = (Invoice) item.Tag;
        }

        private void items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditSelected();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditSelected();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedInvoice == null)
                return;

            if (!Utils.Prompt("Voulez-vous vraiment supprimer cette facture ?"))
                return;

            selectedInvoice.Products.Reload();
            selectedInvoice.Products.DeleteAll();
            InvoiceManager.Instance.Delete(selectedInvoice);
            Reload();
        }
    }
}
