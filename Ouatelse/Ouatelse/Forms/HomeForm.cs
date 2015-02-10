using Ouatelse.Forms;
using Ouatelse.Managers;
using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            if (!Utils.CheckServer())
            {
                Utils.Error("Impossible d'effectuer l'opération demandée. Aucune connexion Internet");
                Application.Exit();
            }

            //Set the time and the hour
            setTime();

            //Setup the login
            DoLogin();

            //Setup the User
            ReloadUser();

           }

        private static void DoLogin()
        {
            if (AuthManager.User == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                if (AuthManager.User == null)
                {
                    Application.Exit();
                }
            }
        }

        private void ReloadUser()
        {
            Employee employee = AuthManager.User;
            if (employee != null)
            {
                this.username.Text = employee.FirstName + " " + employee.LastName;
                this.roleLbl.Text = " (" + employee.Role.Name + ") ";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setTime();
        }

        private void setTime()
        {
            this.date.Text = DateTime.Now.ToShortDateString();
            this.hour.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void deconnexionBtn_Click(object sender, EventArgs e)
        {
            AuthManager.User = null;
            this.Hide();
            DoLogin();
            if (AuthManager.User != null)
            {
                this.Show();
                ReloadUser();
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {

        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            ManageCustomersForm customerForm = new ManageCustomersForm();
            customerForm.ShowDialog();
        }

        private void factureBtn_Click(object sender, EventArgs e)
        {
            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();
        }

        private void salarieBtn_Click(object sender, EventArgs e)
        {
            ManageEmployeesForm employeeForm = new ManageEmployeesForm();
            employeeForm.ShowDialog();
        }

        private void produitBtn_Click(object sender, EventArgs e)
        {
            ProductsForm productForm = new ProductsForm();
            productForm.ShowDialog();
        }

        private void venteBtn_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.ShowDialog();
        }

        private void assistanceBtn_Click(object sender, EventArgs e)
        {
            SupportForm supportForm = new SupportForm();
            supportForm.ShowDialog();
        }
    }
}
