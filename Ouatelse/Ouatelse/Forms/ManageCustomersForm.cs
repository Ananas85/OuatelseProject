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
        string lastColumnClicked = string.Empty;
        string order = string.Empty;
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

            CustomerManager.Instance.Create(cs.getCustomer());

            //Rechargement du listView
            Reload(CustomerManager.Instance.All());

            
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
            //Passage d'un objet par copie
            CustomerForm cs = new CustomerForm((Customer)currentCustomer.Clone());
            if (cs.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;
            if (currentCustomer != cs.getCustomer())
            {
                CustomerManager.Instance.Modify(cs.getCustomer());
                Reload(CustomerManager.Instance.All());
                currentCustomer = cs.getCustomer();
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

        #region Gestion des tris sur les colonnes
        private void customerListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (this.customerListView.Columns[e.Column].Name)
            {
                case "id":
                    if ( this.lastColumnClicked == "id"){
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }   
                    this.Reload(CustomerManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY id "+ this.order));
                    this.lastColumnClicked = "id";
                    break;
                case "prenom":
                    if (this.lastColumnClicked == "prenom")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }   
                    this.Reload(CustomerManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY prenom "+ this.order));
                    this.lastColumnClicked = "prenom";
                    break;
                case "nom":
                    if (this.lastColumnClicked == "nom")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }
                    this.Reload(CustomerManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY nom " + this.order));
                    this.lastColumnClicked = "nom";
                    break;
                case "adresse":
                    if (this.lastColumnClicked == "adresse")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }   
                    this.Reload(CustomerManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY adresse1 " + this.order));
                    this.lastColumnClicked = "adresse";
                    break;
                case "code_postal":
                    if (this.lastColumnClicked == "code_postal")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }  
                    this.Reload(CustomerManager.Instance.Filter("INNER JOIN villes ON clients.villes_id = villes.id WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY villes.code_postal " + this.order));
                    this.lastColumnClicked = "code_postal";
                    break;
                case "villes_id":
                    if (this.lastColumnClicked == "villes_id")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    } 
                    this.Reload(CustomerManager.Instance.Filter("INNER JOIN villes ON clients.villes_id = villes.id WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY villes.libelle " + this.order));
                    this.lastColumnClicked = "villes_id";
                    break;
                case "pays":
                    if (this.lastColumnClicked == "pays_id")
                    {
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }
                    this.Reload(CustomerManager.Instance.Filter("INNER JOIN villes ON clients.villes_id = villes.id INNER JOIN pays ON villes.pays_id = pays.id WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY pays.libelle " + this.order));
                    this.lastColumnClicked = "pays_id";
                    break;
            }
        }
        #endregion
    }
}