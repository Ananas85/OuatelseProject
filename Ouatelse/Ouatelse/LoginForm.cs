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

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Employee employee = EmployeeManager.Instance.First("WHERE identifiant='" + this.usernameEntry.Text + "' AND mot_de_passe='" + this.passwordEntry.Text+"'");
            //Utils.Info(employee.FirstName);
            Utils.Info(EmployeeManager.Instance.Count().ToString());
            
        }
    }
}
