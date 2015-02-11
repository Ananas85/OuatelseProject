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
        public ManageEmployeesForm()
        {
            InitializeComponent();
            Reload(EmployeeManager.Instance.All());
        }

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

        private void Reload(Employee[] employeeArray)
        {
            this.listView_employees.Items.Clear();

            this.employeesNumber.Text = employeeArray.Length.ToString();

            if (employeeArray.Length > 1)
                this.employeesNumber.Text += " salariés.";
            else
                this.employeesNumber.Text += " salarié.";

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


        private void NewEmployee()
        {
            EmployeeForm ef = new EmployeeForm(new Employee());
            if (ef.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            Employee currentEmployee = ef.getEmployee();

            // Génération du compte utilisateur
            
            EmployeeManager.Instance.Save(ef.getEmployee());     
            Reload(EmployeeManager.Instance.All());
            Utils.Info("Salarié enregistré avec succès.");
            // MailSender.Instance.newEmployee(ef.getEmployee());
        }

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

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            NewEmployee();
        }


        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (currentEmployee != null)
            {
                if (Utils.Prompt("Voulez-vous vraiment supprimer " + currentEmployee.LastName + " " + currentEmployee.FirstName + " ? "))
                    if (EmployeeManager.Instance.Delete(currentEmployee))
                        Reload(EmployeeManager.Instance.All());

            }
        }

        private void ModifyEmployeeButton_Click(object sender, EventArgs e)
        {
            EditEmployee();
        }

        private void listView_employees_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditEmployee();
        }




    }
}
