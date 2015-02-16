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

namespace Ouatelse.Forms
{
    public partial class ManageEmployeesForm : Form
    {
        Employee currentEmployee = null;

        #region Constructeur de la classe
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        public ManageEmployeesForm()
        {
            InitializeComponent();
            Reload(EmployeeManager.Instance.All());
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
            if (String.IsNullOrWhiteSpace(searchBox.Text))
            {
                Reload(EmployeeManager.Instance.All());
            }
            else
            {
                string Search = "WHERE nom LIKE '" + searchBox.Text + "%' OR prenom LIKE '" + searchBox.Text + "%';";
                Reload(EmployeeManager.Instance.Filter(Search));
            }
        }
        #endregion

        #region Méthode pour le rechargement de la ListView (avec un tableau en paramètre)
        /// <summary>
        /// Méthode pour le rechargement de la ListView
        /// </summary>
        /// <param name="employeeArray">Liste d'employés à afficher</param>
        private void Reload(Employee[] employeeArray)
        {
            this.listView_employees.Items.Clear();

            this.employeesNumber.Text = employeeArray.Length.ToString();

            if (employeeArray.Length > 1)
                this.employeesNumber.Text += " salariés";
            else
                this.employeesNumber.Text += " salarié";

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
            }
            if (alternativeColor)
            {
                listView_employees.BackColor = Color.WhiteSmoke;
            }
            alternativeColor = !alternativeColor;
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
            ListViewItem item = this.listView_employees.GetItemAt(e.X, e.Y);
            if (item == null)
            {
                currentEmployee = null;
                return;
            }
            currentEmployee = (Employee)item.Tag;
        }
        #endregion

        #region Création d'un employé
        /// <summary>
        /// Méthode de création d'un nouvel employé
        /// </summary>
        private void NewEmployee()
        {
            EmployeeForm ef = new EmployeeForm(new Employee());
            if (ef.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            // Génération du compte utilisateur
            Employee currentEmployee = ef.getEmployee();
            currentEmployee.Password = Utils.generatePassword(5);


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
            if (currentEmployee != null)
            {
                EmployeeForm ef = new EmployeeForm(currentEmployee);
                if (ef.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                EmployeeManager.Instance.Save(ef.getEmployee());
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
            if (currentEmployee != null)
            {
                if (Utils.Prompt("Voulez-vous vraiment supprimer " + currentEmployee.LastName + " " + currentEmployee.FirstName + " ? "))
                    if (EmployeeManager.Instance.Delete(currentEmployee))
                        Reload(EmployeeManager.Instance.All());

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
    }
}
