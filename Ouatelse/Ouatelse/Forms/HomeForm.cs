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
    /// <summary>
    /// Classe qui gère le menu principale
    /// </summary>
    public partial class HomeForm : Form
    {
        #region Les attributs
        //Le service de gestion des licences
        private ActivationService als;

        //Le dossier où les données du logiciel sont stockés
        public static string AppData = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Ouatelse");
        #endregion

        #region Le constructeur
        public HomeForm()
        {
            //Création du dossier de données
            if (!Directory.Exists(AppData))
                Directory.CreateDirectory(AppData);
            //Le service d'activation du logiciel
            als = new ActivationService("h61v6b7f","ouatelse","Ouatelse",Path.Combine(AppData,"ouatelse-eaf"));
            InitializeComponent();
            Utils.SetNotifyIcon(this.notifyIcon1);
        }
        #endregion

        #region Pour vérifier la connexion lorsque la form se charge
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
                    this.Show();
                    ReloadUser();
                    return;
                }
                Application.Exit();   
            }
        }
        #endregion

        #region Charger les données de l'utilisateur
        /// <summary>
        /// Fonction qui permet de charger les données de l'utilisateur authentifié
        /// </summary>
        private void ReloadUser()
        {
            this.username.Text = AuthManager.Instance.User.FirstName + " " + AuthManager.Instance.User.LastName;
            this.roleLbl.Text = " (" + AuthManager.Instance.User.Role.Name + ") ";

            this.linkLabel2.Visible = (AuthManager.Instance.User.Role.Name == "Administrateur");
            this.linkLabel1.Visible = (AuthManager.Instance.User.Role.Name == "Administrateur");
        }
        #endregion

        #region Pour afficher l'horloge à la seconde près
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
        #endregion

        #region Gestion de la deconnexion
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
        #endregion

        #region Gestion du vérouillage
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
        #endregion

        #region Gestion des clients
        /// <summary>
        /// Action sur le bouton clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientsBtn_Click(object sender, EventArgs e)
        {
            new ManageCustomersForm().ShowDialog();
        }
        #endregion

        #region Gestion des nouvelles factures
        /// <summary>
        /// Action sur le bouton nouvelle facture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void factureBtn_Click(object sender, EventArgs e)
        {
            new InvoiceForm(new Invoice()).ShowDialog();
        }
        #endregion

        #region Gestion des salariés
        /// <summary>
        /// Action sur le bouton salarié
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salarieBtn_Click(object sender, EventArgs e)
        {
            new ManageEmployeesForm().ShowDialog();
        }
        #endregion

        #region Gestion des produits
        /// <summary>
        /// Action sur le bouton produit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void produitBtn_Click(object sender, EventArgs e)
        {
            new ManageProductsForm().ShowDialog();
        }
        #endregion

        #region Gestion des ventes
        /// <summary>
        /// Action sur le bouton ventes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void venteBtn_Click(object sender, EventArgs e)
        {
            new SalesForm().ShowDialog();
        }
        #endregion

        #region Gestion de l'assistance
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
        #endregion

        #region Gestion des congés
        private void holliday_Click(object sender, EventArgs e)
        {
            new ManageHolidaysForm().ShowDialog();
        }
        #endregion

        #region Au chargement de la forme
        private void HomeForm_Load(object sender, EventArgs e)
        {

            if (!als.CheckActivation())
            {
                Application.Exit();
                return;
            }

            // On vérifie si l'app est lié à un magasin

            if (Properties.Settings.Default.CurrentStore == null)
            {
                if (new StorePicker().ShowDialog() != DialogResult.OK)
                {
                    Application.Exit();
                    return;
                }
            }

            if (Properties.Settings.Default.CurrentStore == null)
            {
                Application.Exit();
                return;
            }
            
            this.magasin.Text = Properties.Settings.Default.CurrentStore.Name;

            //Gère la connexion
            DoLogin();
        }
        #endregion

        #region Click pour les information de la licence
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            als.ShowState();
            if(!als.CheckActivation())
                Application.Exit();
        }
        #endregion

        #region Pour pouvoir changer de magasin
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Utils.Prompt("Voulez-vous vraiment changer de magasin ?")) return;
            Properties.Settings.Default.CurrentStore = null;
            Properties.Settings.Default.Save();
            AuthManager.Instance.Logout();
            this.Hide();
            HomeForm_Load(null, null);
        }
        #endregion
    }
}
