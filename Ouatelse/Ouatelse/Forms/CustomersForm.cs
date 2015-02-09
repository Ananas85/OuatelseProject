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
                string Search = "WHERE nom='" + searchBox.Text + "%' OR prenom='" + searchBox.Text + "%';";
                Utils.Info(Search);
                Reload(CustomerManager.Instance.Filter(Search));
            }
        }

        private void Reload(Customer[] customerArray)
        {
            this.customerListView.Items.Clear();
            foreach (Customer cs in customerArray)
            {
                ListViewItem customer = this.customerListView.Items.Add(cs.Id.ToString());
                customer.SubItems.Add(cs.FirstName + " " +  cs.LastName);
                customer.SubItems.Add(cs.Address1 + " " + cs.Address2);
                customer.SubItems.Add(cs.City.Name + " (" + cs.City.Country.Name + ")" );
                customer.Tag = cs;
            }
        }
    }
}
