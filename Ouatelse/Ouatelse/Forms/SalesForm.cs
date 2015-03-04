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
        public SalesForm()
        {
            InitializeComponent();
            Reload();
        }

        public void Reload()
        {
            Invoice[] items = InvoiceManager.Instance.All();

            foreach (Invoice invoice in items)
            {
                ListViewItem item = this.items.Items.Add(invoice.Id.ToString());
                item.SubItems.Add(invoice.Date.ToShortDateString());
                item.SubItems.Add(invoice.Customer.FullName);
                item.SubItems.Add(invoice.ProductsString);
                item.SubItems.Add(invoice.TotalHT.ToString("C"));
                item.SubItems.Add(invoice.TotalTTC.ToString("C"));
            }
        }
    }
}
