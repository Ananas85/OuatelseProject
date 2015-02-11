using Ouatelse.Forms;
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
    public partial class ManageCustomersForm : Form
    {
        Customer currentCustomer = null;
        public ManageCustomersForm()
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
                string Search = "WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%';";
                Reload(CustomerManager.Instance.Filter(Search));
            }
        }

        private void Reload(Customer[] customerArray)
        {
            this.customerListView.Items.Clear();

            this.CustomersNumber.Text = customerArray.Length.ToString();

            if (customerArray.Length > 1)
                this.CustomersNumber.Text += " clients.";
            else
                this.CustomersNumber.Text += " client.";

            bool alternativeColor = false;
            foreach (Customer cs in customerArray)
            {
                ListViewItem customer = this.customerListView.Items.Add(cs.Id.ToString());
                customer.SubItems.Add(cs.FirstName);
                customer.SubItems.Add(cs.LastName);
                customer.SubItems.Add(cs.Address1 + " " + cs.Address2);
                customer.SubItems.Add(cs.City.PostalCode);
                customer.SubItems.Add(cs.City.Name);
                customer.SubItems.Add(cs.City.Country.Name);
                customer.Tag = cs;
                if (alternativeColor)
                {
                    customer.BackColor = Color.WhiteSmoke;
                }
                alternativeColor = !alternativeColor;
            }
        }

        private void customerListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.customerListView.GetItemAt(e.X, e.Y);
            if (item == null)
            {
                currentCustomer = null;
                return;
            }
            currentCustomer = (Customer)item.Tag;
        }

        private void NewCustomer()
        {
            CustomerForm cs = new CustomerForm(new Customer());
            if (cs.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            CustomerManager.Instance.Save(cs.getCustomer());
            Reload(CustomerManager.Instance.All());
            Utils.Info("Client enregistré avec succès");
            MailSender.Instance.newCustomer(cs.getCustomer());
        }

        private void EditCustomer()
        {
            if (currentCustomer != null)
            {
                CustomerForm cs = new CustomerForm(currentCustomer);
                if (cs.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                CustomerManager.Instance.Save(cs.getCustomer());
                Reload(CustomerManager.Instance.All());
                Utils.Info("Client modifié avec succès");

            }
            else
            {
                Utils.Warning("Vous n'avez pas sélectionné de client");
            }
        }

        private void deletecustomer_Click(object sender, EventArgs e)
        {
            if (currentCustomer != null)
            {
                if (Utils.Prompt("Voulez-vous vraiment supprimer " + currentCustomer.LastName + " " + currentCustomer.FirstName + " ? "))
                    if (CustomerManager.Instance.Delete(currentCustomer))
                        Reload(CustomerManager.Instance.All());

            }
        }

        private void customerListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditCustomer();
        }

        private void modify_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void nouveau_Click(object sender, EventArgs e)
        {
            NewCustomer();
        }
    }
}
