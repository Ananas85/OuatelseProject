using Ouatelse.Managers;
using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            Reload(CustomerManager.Instance.All());
        }

        public void Reload(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(searchBox.Text))
            {
                Reload(CustomerManager.Instance.All());
            }
            else
            {
                Reload(CustomerManager.Instance.Filter("WHERE nom='" + searchBox.Text + "' OR prenom='" + searchBox.Text + "'"));
            }
        }

        private void Reload(Customer[] customerArray)
        {
            this.customerListView.Items.Clear();
            foreach (Customer cs in customerArray)
            {
                ListViewItem customer = this.customerListView.Items.Add(cs.Id.ToString());
                customer.SubItems.Add(cs.FirstName.ToString());
                customer.SubItems.Add(cs.Address1.ToString());
                customer.SubItems.Add(cs.City.Name.ToString());
                customer.Tag = cs;
            }
        }
    }
}
