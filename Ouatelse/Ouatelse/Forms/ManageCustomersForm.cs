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
    /// <summary>
    /// Classe qui permet de gérer l'ensemble des clients de la base de données
    /// </summary>
    public partial class ManageCustomersForm : Form
    {
        Customer currentCustomer = null;

        #region Constructeur de la classe
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public ManageCustomersForm()
        {
            InitializeComponent();
            //Appelle de la méthode pour remplir les données dans le listView
            Reload(CustomerManager.Instance.All());
        }
        #endregion

        #region Méthode pour le rechargement du listView
        /// <summary>
        /// Méthode qui gère le rechargement du listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Reload(object sender, EventArgs e)
        {
            //Si la recherche n'a pas de contenu on met l'intégralité des clients
            if (String.IsNullOrWhiteSpace(searchBox.Text))
            {
                Reload(CustomerManager.Instance.All());
                return;
            }
            //Sinon la barre est rempli on recharge la listView selon le filtre
            string Search = "WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%';";
            Reload(CustomerManager.Instance.Filter(Search));
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

        #region Édition d'un nouveau client
        /// <summary>
        /// Edition d'un client
        /// </summary>
        private void nouveau_Click(object sender, EventArgs e)
        {
            //Création d'une nouvelle instance de classe
            CustomerForm cs = new CustomerForm(new Customer());

            //Examination du retour de la boite de dialogue
            if (cs.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            currentCustomer = cs.getCustomer();
            //Enregistrement dans la base de données
            CustomerManager.Instance.Save(currentCustomer);

            //Rechargement du listView
            Reload(CustomerManager.Instance.All());

            //Message d'information
            Utils.Info("Client enregistré avec succès");

            //Envoi du mail au nouveau client
            if (currentCustomer.Email != null)
                MailSender.Instance.newCustomer(currentCustomer);
        }
        #endregion

        #region Gestion du click qui permet de sélectionner un client
        /// <summary>
        /// Gestion du click qui permet de sélectionner un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #region Gestion du click sur le bouton modifier
        /// <summary>
        /// Gestion du click sur le bouton modifier pour le client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modify_Click(object sender, EventArgs e)
        {
            if (currentCustomer != null)
            {
                EditCustomer();
                return;
            }
            Utils.Warning("Vous n'avez pas sélectionné de client");
        }
        #endregion

        #region  Gestion du double click pour modifier un client
        /// <summary>
        /// Gestion du double click pour modifier un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (currentCustomer != null)
            {
                EditCustomer();
                return;
            }
            Utils.Warning("Vous n'avez pas sélectionné de client");
        }
        #endregion

        #region Gestion de la modification d'un client
        /// <summary>
        /// Edition d'un client
        /// </summary>
        private void EditCustomer()
        {
            CustomerForm cs = new CustomerForm(currentCustomer);
            if (cs.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            if (currentCustomer != cs.getCustomer())
            {
                currentCustomer = cs.getCustomer();
                CustomerManager.Instance.Save(currentCustomer);
                Reload(CustomerManager.Instance.All());
                Utils.Info("Client modifié avec succès");
                if (currentCustomer.EmailOnUpdate)
                {
                    MailSender.Instance.modifyCustomer(currentCustomer);
                }
                return;
            }
            Utils.Info("Aucune modification apporté au client");
            return;

        }
        #endregion

        #region Gestion de la suppression d'un client
        /// <summary>
        /// Gestion de la suppression d'un client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deletecustomer_Click(object sender, EventArgs e)
        {
            if (currentCustomer != null)
            {
                if (Utils.Prompt("Voulez-vous vraiment supprimer " + currentCustomer.LastName + " " + currentCustomer.FirstName + " ? "))
                    if (CustomerManager.Instance.Delete(currentCustomer))
                    {
                        Reload(CustomerManager.Instance.All());
                        Utils.Info("Client supprimé avec succès");
                        MailSender.Instance.deleteCustomer(currentCustomer);
                        currentCustomer = null;
                    }
            }
        }
        #endregion
    }
}