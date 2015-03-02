using Ouatelse.Forms;
using Ouatelse.Managers;
using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrisALS;

namespace Ouatelse
{
    public partial class HomeForm : Form
    {
        private ActivationService als;

        public static string AppData = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Ouatelse");
        public HomeForm()
        {
            if (!Directory.Exists(AppData))
                Directory.CreateDirectory(AppData);
            als = new ActivationService("h61v6b7f","ouatelse","Ouatelse",Path.Combine(AppData,"ouatelse-eaf"));
            if(!als.CheckActivation())
                Application.Exit();
            InitializeComponent();
            Utils.SetNotifyIcon(this.notifyIcon1);
            //Gère la connexion
            DoLogin();

           }

        /// <summary>
        /// Fonction qui permet de vérifier si l'utilisateur est connecté
        /// </summary>
        private void DoLogin()
        {
            if (AuthManager.Instance.User == null)
            {
                new LoginForm().ShowDialog();
                if (AuthManager.Instance.User != null)
                {
                    ReloadUser();
                    return;
                }
                Application.Exit();
                
            }
        }

        /// <summary>
        /// Fonction qui permet de charger les données de l'utilisateur authentifié
        /// </summary>
        private void ReloadUser()
        {
            this.username.Text = AuthManager.Instance.User.FirstName + " " + AuthManager.Instance.User.LastName;
            this.roleLbl.Text = " (" + AuthManager.Instance.User.Role.Name + ") ";
        }

        /// <summary>
        /// Fonction qui permet de gérer les tick d'horloge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.date.Text = DateTime.Now.ToLongDateString();
            this.hour.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Action sur le bouton déconnexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deconnexionBtn_Click(object sender, EventArgs e)
        {
            AuthManager.Instance.User = null;
            this.Hide();
            DoLogin();
            if (AuthManager.Instance.User == null)
            {
                Application.Exit();
                return;
            }
            this.Show();
        }

        /// <summary>
        /// Action sur le bouton Vérouiller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLock_Click(object sender, EventArgs e)
        {
            LockForm lockForm = new LockForm();
            this.Hide();
            lockForm.ShowDialog();
            DoLogin();
            if (AuthManager.Instance.User == null)
            {
                Application.Exit();
                return;
            }
            this.Show();
        }

        /// <summary>
        /// Action sur le bouton clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientsBtn_Click(object sender, EventArgs e)
        {
            new ManageCustomersForm().ShowDialog();
        }

        /// <summary>
        /// Action sur le bouton nouvelle facture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void factureBtn_Click(object sender, EventArgs e)
        {
            new InvoiceForm(new Invoice()).ShowDialog();
        }

        /// <summary>
        /// Action sur le bouton salarié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salarieBtn_Click(object sender, EventArgs e)
        {
            new ManageEmployeesForm().ShowDialog();
        }

        /// <summary>
        /// Action sur le bouton produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void produitBtn_Click(object sender, EventArgs e)
        {
            new ProductsForm().ShowDialog();
        }

        /// <summary>
        /// Action sur le bouton ventes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void venteBtn_Click(object sender, EventArgs e)
        {
            new SalesForm().ShowDialog();
        }

        /// <summary>
        /// Action sur le bouton assistance.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void assistanceBtn_Click(object sender, EventArgs e)
        {
            SupportForm sf = new SupportForm(AuthManager.Instance.User);
            if( sf.ShowDialog() != DialogResult.OK)
                return;
            else
                MailSender.Instance.supportRequest(sf.Os, sf.Version, sf.User, sf.Date, sf.Category, sf.Message);
        }

        private void holliday_Click(object sender, EventArgs e)
        {
            new HolidayForm().ShowDialog();
        }

private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            als.ShowState();
            if(!als.CheckActivation())
                Application.Exit();
        }
    }
}
