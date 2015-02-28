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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ReloadData()
        {
            this.listView_products.Items.Clear();
            foreach (Product e in ProductManager.Instance.All())
            {
                ListViewItem products = this.listView_products.Items.Add(e.Id.ToString());
                products.SubItems.Add(e.Name.ToString());
                products.SubItems.Add(e.Designation.ToString());
                products.SubItems.Add(e.PurchasePrice.ToString());
                products.SubItems.Add(e.SellPrice.ToString());
                products.SubItems.Add(e.TVA.ToString());
                products.SubItems.Add(e.EANCode.ToString());
                products.Tag = e;
            }
        }

        private void newProductBtn_Click(object sender, EventArgs e)
        {
            NewProductForm newProductForm = new NewProductForm();
            newProductForm.ShowDialog();  
        }
    }
}
