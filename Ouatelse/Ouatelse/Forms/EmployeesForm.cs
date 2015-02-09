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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
                
            //Reload items
            Reload(EmployeeManager.Instance.All());
        }

        public void Reload(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(searchBoxEmployee.Text))
            {
                Reload(EmployeeManager.Instance.All());
            }
            else
            {
                string Search = "WHERE nom LIKE '" + searchBoxEmployee.Text + "%' OR prenom LIKE '" + searchBoxEmployee.Text + "%';";
                Reload(EmployeeManager.Instance.Filter(Search));
            }
        }

        private void Reload(Employee[] employeeArray)
        {
            this.listView_employees.Items.Clear();
            foreach (Employee e in employeeArray)
            {
                ListViewItem employee = this.listView_employees.Items.Add(e.Id.ToString());
                employee.SubItems.Add(e.LastName.ToString());
                employee.SubItems.Add(e.FirstName.ToString());
                employee.SubItems.Add(e.Email.ToString());
                employee.SubItems.Add(e.Role.Name.ToString());
                employee.SubItems.Add(e.Store.City.Name.ToString());
                employee.Tag = e;
            }
            if (employeeArray.Length <= 1)
                labelSearch.Text = employeeArray.Length + " résultat";
            else
                labelSearch.Text = employeeArray.Length + " résultats";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm(EmployeeManager.Instance.Find(listView_employees.SelectedItems[0].Text));
            ef.ShowDialog();
        }
    }
}
