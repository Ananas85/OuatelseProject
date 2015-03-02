using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Ouatelse.Models;
using Ouatelse.Managers;
using System.Web;

namespace Ouatelse.Forms
{
    public partial class SupportForm : Form
    {
        private string os;
        private string version;
        private string store;
        private Employee user;
        private DateTime date;
        private string message;
        private string category;

        public string Os
        {
            get { return os; }
            set { os = value; }
        }

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public string Store
        {
            get { return store; }
            set { store = value; }
        }

        public Employee User
        {
            get { return user; }
            set { user = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public SupportForm(Employee e)
        {
            InitializeComponent();

            loadInformation(e);

            populatingCategoryList();
        }

        private void populatingCategoryList()
        {
            List<string> categories = new List<string>();
            categories.Add("Authentification");
            categories.Add("Factures");
            categories.Add("Clients");
            categories.Add("Salariés");
            categories.Add("Congés");
            categories.Add("Produits");
            categories.Add("Ventes");
            categories.Add("Hors catégorie");


            foreach (string c in categories)
                categoryCB.Items.Add(c);
        }

        public void loadInformation(Employee e)
        {
            // OS Information
            this.os = GetOSFriendlyName();

            // Ouatelse Application Version Information
            this.version = Application.ProductVersion;

            // Store information
            this.store = e.Store.Name;
            // User Information
            this.user = e;

            // Date Information
            this.date = DateTime.Now;

            // Load information in form
            osTB.Text = this.os;
            versionTB.Text = this.version;
            storeTB.Text = this.store;
            userTB.Text = this.user.FirstName + " " + this.user.LastName;
            dateTB.Text = this.date.ToString();
        }

        public static string GetOSFriendlyName()
        {
            string thisOS = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                thisOS = os["Caption"].ToString();
                break;
            }
            // Remove the word "Microsoft"
            return thisOS.Substring(10);
        }

        private void supportMessageTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (supportMessageTB.Text == "Formulez votre message d'assistance en étant le plus précis possible !")
                supportMessageTB.Clear();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            string badValidation = "";
            // Validation
            if (categoryCB.SelectedItem == null)
                badValidation += "Veuillez choisir une catégorie" + "\n";

            if (supportMessageTB.Text == "" || supportMessageTB.Text == "Formulez votre message d'assistance en étant le plus précis possible !")
                badValidation += "Veuillez entrer un message" + "\n";
            
            if(badValidation != "")
            {
                Utils.Warning(badValidation);
                return;
            }
            else
            {
                // prevent html tags and support multiline
                this.message = HttpUtility.HtmlEncode(supportMessageTB.Text).Replace("\n", "<br/>");

                this.category = categoryCB.SelectedItem.ToString();
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }      
    }
}
