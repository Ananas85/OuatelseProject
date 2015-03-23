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
    public partial class CustomerPickerForm : Form 
    {
        #region Les attributs
        private Customer currentCustomer = null;
        #endregion

        #region Le constructeur
        public CustomerPickerForm()
        {
            InitializeComponent();
            //Appelle de la méthode pour remplir les données dans le listView
            Reload(CustomerManager.Instance.All());
        }
        #endregion

        #region Pour pouvoir créer un nouveau client
        private void nouveau_Click(object sender, EventArgs e)
        {
            //Création d'une nouvelle instance de classe
            CustomerForm cs = new CustomerForm(new Customer());

            //Examination du retour de la boite de dialogue
            if (cs.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            CustomerManager.Instance.Create(cs.getCustomer());
            currentCustomer = cs.getCustomer();
            this.DialogResult = DialogResult.OK;
        }
        #endregion

        #region Permet de gérer le rechargement du listView
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            //Si c'est vide ça recharge tous les clients
            Reload(CustomerManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%';"));
        }
        #endregion

        #region Liaison des données au listView
        /// <summary>
        /// Méthode pour gérer le chargement des données de la base
        /// </summary>
        /// <param name="customerArray">La liste des clients à afficher</param>
        private void Reload(Customer[] customerArray)
        {
            //Nettoyage de la listView
            this.customerListView.Items.Clear();

            //Affichage du nombre de client
            this.CustomersNumber.Text = customerArray.Length.ToString();

            //Orthographe correcte selon le nombre
            if (customerArray.Length > 1)
                this.CustomersNumber.Text += " clients";
            else
                this.CustomersNumber.Text += " client";

            //Recherche du nombre total de client
            //this.CustomersNumber.Text += " " + CustomerManager.Instance.Count().ToString();


            //Gestion de la couleur alternée entre les lignes
            bool alternativeColor = false;

            //On parcourt les clients
            foreach (Customer cs in customerArray)
            {
                //Création d'un nouvelle ligne commencant par l'identifiant puis ajout des autres colonnes
                ListViewItem customer = this.customerListView.Items.Add(cs.Id.ToString());
                customer.SubItems.Add(cs.FirstName);
                customer.SubItems.Add(cs.LastName);
                customer.SubItems.Add(cs.Address1 + " " + cs.Address2);
                customer.SubItems.Add(cs.City.PostalCode);
                customer.SubItems.Add(cs.City.Name);
                customer.SubItems.Add(cs.City.Country.Name);

                //Liaison de la ligne à l'objet
                customer.Tag = cs;

                //Gestion des couleurs
                if (alternativeColor)
                {
                    customer.BackColor = Color.WhiteSmoke;
                }
                alternativeColor = !alternativeColor;
            }
        }
        #endregion

        #region Permet de repérer un client selon le clic
        private void customerListView_MouseClick(object sender, MouseEventArgs e)
        {
            //On récupère le client correspondant à la ligne
            ListViewItem item = this.customerListView.GetItemAt(e.X, e.Y);
            if (item == null)
            {
                currentCustomer = null;
                return;
            }
            currentCustomer = (Customer)item.Tag;
        }
        #endregion

        #region Permet de sélectionner par le double clic
        private void customerListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (currentCustomer != null)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        #endregion

        #region Le getter du client
        public Customer GetCustomer()
        {
            return this.currentCustomer;
        }
        #endregion
    }
}
