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

namespace Ouatelse
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void forgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LostPasswordForm lostpass = new LostPasswordForm();
            lostpass.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Employee employee = EmployeeManager.Instance.First("WHERE identifiant='" + this.usernameEntry.Text + "' AND mot_de_passe='" + this.passwordEntry.Text + "'");
            if (employee != null)
            {
                Utils.Info("Bonjour " + employee.FirstName + " " + employee.LastName);
                HomeForm homeForm = new HomeForm(employee);
                homeForm.Show();
                this.Hide();
            }
            else
            {
                Utils.Warning("Vos identifiants ne sont pas dans la base de données, réessayez.");
            }
        }
    }
}
