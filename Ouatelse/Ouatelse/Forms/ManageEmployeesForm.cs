using Ouatelse.Managers;
using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse.Forms
{
    public partial class ManageEmployeesForm : Form
    {
        #region Attributs de la classe
        Employee currentEmployee = null;
        string lastColumnClicked = string.Empty;
        string order = string.Empty;
        private static int PASSWORD_LENGTH = 5;
        #endregion

        #region Constructeur de la classe
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public ManageEmployeesForm()
        {
            InitializeComponent();

            // Chargement des salariés dans la liste
            Reload(EmployeeManager.Instance.All());
            ReloadStats();

        }
        #endregion

        #region Méthode pour le rechargement de la ListView
        /// <summary>
        /// Méthode pour le rechargement de la ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Reload(object sender, EventArgs e)
        {
            //Si c'est vide ça recharge tous les clients
            Reload(EmployeeManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%';"));
        }


        private void ReloadStats()
        {
            Employee[] currentStoreEmployee =
                EmployeeManager.Instance.Filter("WHERE magasin_id = " + Properties.Settings.Default.CurrentStore.Id);
            foreach (Employee e in currentStoreEmployee)
            {
                e.Invoices.Reload();
                foreach (Invoice i in e.Invoices.Items)
                {
                    i.Products.Reload();
                }
                
            }
            Employee bestEmployee = currentStoreEmployee[0];
            Employee bestEmployeeOfMonth = currentStoreEmployee[0];
            Employee bestEmployeeOfYear = currentStoreEmployee[0];
            foreach (Employee e in currentStoreEmployee)
            {
                if (e.NumberOfSellTotal() >= bestEmployee.NumberOfSellTotal())
                {
                    bestEmployee = e;
                }
                if (e.NumberOfSellInYear() >= bestEmployeeOfYear.NumberOfSellInYear())
                {
                    bestEmployeeOfYear = e;
                }
                if (e.NumberOfSellInMonth() >= bestEmployeeOfMonth.NumberOfSellInMonth())
                {
                    bestEmployeeOfMonth = e;
                }
            }
            this.bestEmployee.Text = bestEmployee.FullName;
            this.bestEmployeeMonth.Text = bestEmployeeOfMonth.FullName;
            this.bestEmployeeOfTheYear.Text = bestEmployeeOfYear.FullName;
        }
        #endregion

        #region Méthode pour le rechargement de la ListView (avec un tableau en paramètre)
        /// <summary>
        /// Méthode pour le rechargement de la ListView
        /// </summary>
        /// <param name="employeeArray">Liste d'employés à afficher</param>
        private void Reload(Employee[] employeeArray)
        {
            // Nettoyage de la liste
            this.listView_employees.Items.Clear();

            // Récupération du nombre de salariés
            this.employeesNumber.Text = employeeArray.Length.ToString();

            // Condition d'affichage en fonction du nombre de salarié
            if (employeeArray.Length > 1)
                this.employeesNumber.Text += " salariés";
            else
                this.employeesNumber.Text += " salarié";

            // Remplissage de la liste
            bool alternativeColor = false;
            foreach (Employee e in employeeArray)
            {
                ListViewItem employee = this.listView_employees.Items.Add(e.Id.ToString());
                employee.SubItems.Add(e.LastName.ToString());
                employee.SubItems.Add(e.FirstName.ToString());
                employee.SubItems.Add(e.Email.ToString());
                employee.SubItems.Add(e.Role.Name.ToString());
                employee.SubItems.Add(e.Store.Name);
                employee.Tag = e;

                // Alternance de couleur à chaque ligne
                if (alternativeColor)
                {
                    employee.BackColor = Color.WhiteSmoke;
                }
                alternativeColor = !alternativeColor;
            }
        }
        #endregion

        #region Méthode d'évenement du clic dans la ListView
        /// <summary>
        /// Méthode d'évenement du clic dans la ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_employees_MouseClick(object sender, MouseEventArgs e)
        {
            //On récupère le salarié correspondant à la ligne
            ListViewItem item = this.listView_employees.GetItemAt(e.X, e.Y);
            if (item == null)
            {
                currentEmployee = null;
                return;
            }

            // Attribution via son Tag
            currentEmployee = (Employee)item.Tag;
        }
        #endregion

        #region Création d'un salarié
        /// <summary>
        /// Méthode de création d'un nouveau salarié
        /// </summary>
        private void NewEmployee()
        {
            // Ouverture de la fenêtre de création d'un salarié
            EmployeeForm ef = new EmployeeForm(new Employee());
            if (ef.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            // Génération du compte utilisateur
            Employee currentEmployee = ef.getEmployee();
            currentEmployee.Password = Utils.GeneratePassword(PASSWORD_LENGTH); // 5 caractères

            // Sauvegarde en base
            EmployeeManager.Instance.Save(currentEmployee);
            Reload(EmployeeManager.Instance.All());
            Utils.Info("Salarié enregistré avec succès.");

            //Envoi du mail au nouveau salarié
            if (currentEmployee.Email != null)
                MailSender.Instance.newEmployee(currentEmployee);
        }
       
        /// <summary>
        /// Méthode d'évenement du clic sur le bouton de création d'un nouvel employé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            NewEmployee();
        }
        #endregion

        #region Modification d'un employé
        /// <summary>
        /// Méthode de modification d'un employé
        /// </summary>
        private void EditEmployee()
        {
            // Si l'on a bien sélectionné un salarié
            if (currentEmployee != null)
            {

                // Ouverture de la fenêtre d'édition
                EmployeeForm ef = new EmployeeForm(currentEmployee);
                if (ef.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                // Sauvegarde en base
                EmployeeManager.Instance.Modify(ef.getEmployee());
                Reload(EmployeeManager.Instance.All());
                Utils.Info("Salarié enregistré avec succès");
            }
            else
            {
                Utils.Warning("Vous n'avez pas sélectionné de salarié");
            }
        }
        
        /// <summary>
        ///  Méthode d'évenement du clic sur le bouton de modification d'un employé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyEmployeeButton_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        /// <summary>
        /// Méthode d'évenement du double-clic dans la ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_employees_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditEmployee();
        }
        #endregion

        #region Suppression d'un employé
        /// <summary>
        /// Méthode de suppression d'un employé
        /// </summary>
        private void DeleteEmployee()
        {
            // Si l'on a bien sélectionné un salarié
            if (currentEmployee != null)
            {
                // Vérification de la demande
                if (Utils.Prompt("Voulez-vous vraiment supprimer " + currentEmployee.LastName + " " + currentEmployee.FirstName + " ? "))
                {
                    // Suppression en base
                    if (EmployeeManager.Instance.Delete(currentEmployee))
                    {
                        // On recharge la liste avec la modification
                        Reload(EmployeeManager.Instance.All());
                        Utils.Info("Client supprimé avec succès");

                        // Envoi du mail de suppression à l'utilisateur
                        if (!String.IsNullOrWhiteSpace(currentEmployee.Email))
                            MailSender.Instance.deleteEmployee(currentEmployee);
                        currentEmployee = null;
                    }
                }
            }
        }

        /// <summary>
        /// Méthode d'évenement du clic sur le bouton de suppression d'un employé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }
        #endregion

        #region Méthode appellée lors de l'activation d'un item de la liste
        private void listView_employees_ItemActivate(object sender, EventArgs e)
        {
            // Récupération de l'item sélectionné
            ListViewItem item = ((ListView)sender).SelectedItems[0];
            if (item == null)
            {
                currentEmployee = null;
                return;
            }

            // Attribution via le Tag
            currentEmployee = (Employee)item.Tag;
        }
        #endregion

        #region Méthode de tri quand on clique sur une colonne
        private void listView_employees_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Récupération du nom de la colonne
            switch (this.listView_employees.Columns[e.Column].Name)
            {
                case "reference":
                    // Si elle a déja été cliqué
                    if (this.lastColumnClicked == "reference")
                    {
                        // Alors on inverse (ASC -> DESC OU DESC -> ASC)
                        if (this.order == "ASC")
                            this.order = "DESC";
                        else
                            this.order = "ASC";
                    }
                    else
                    {
                        this.order = "ASC";
                    }

                    // On effectue le tri
                    this.Reload(EmployeeManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY id " + this.order));
                    
                    // Attribution de la dernière colonne cliquée
                    this.lastColumnClicked = "id";
                    break;
                case "firstname":
                    if (this.lastColumnClicked == "firstname")
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
                    this.Reload(EmployeeManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY prenom " + this.order));
                    this.lastColumnClicked = "firstname";
                    break;
                case "lastname":
                    if (this.lastColumnClicked == "lastname")
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
                    this.Reload(EmployeeManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY nom " + this.order));
                    this.lastColumnClicked = "lastname";
                    break;
                case "mail":
                    if (this.lastColumnClicked == "mail")
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
                    this.Reload(EmployeeManager.Instance.Filter("WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY mail " + this.order));
                    this.lastColumnClicked = "mail";
                    break;
                case "role":
                    if (this.lastColumnClicked == "role")
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
                    this.Reload(EmployeeManager.Instance.Filter("INNER JOIN roles ON salaries.roles_id = roles.id WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY roles.libelle_role " + this.order));
                    this.lastColumnClicked = "role";
                    break;
                case "store":
                    if (this.lastColumnClicked == "store")
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
                    this.Reload(EmployeeManager.Instance.Filter("INNER JOIN magasin ON salaries.magasin_id = magasin.id WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%' ORDER BY magasin.adresse " + this.order));
                    this.lastColumnClicked = "store";
                    break;
            }
        }
        #endregion

        #region Méthodes du Clic droit (menu contextuel)
        private void editThisEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void deleteThisEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
        }
        #endregion
    }
}
