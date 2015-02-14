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
    public partial class CustomerForm : Form
    {
        #region Les attributs de la classe
        /// <summary>
        /// Le client courant du formulaire
        /// </summary>
        Customer obj = null;

        /// <summary>
        /// La cohérence entre le formulaire et notre client
        /// </summary>
        Binding b = new Binding();

        /// <summary>
        /// La liste des villes à afficher
        /// </summary>
        List<City> citiesList = null;
        #endregion

        #region Le constructeur de la classe
        /// <summary>
        /// Le constructeur de la classe
        /// </summary>
        /// <param name="obj"></param>
        public CustomerForm(Customer obj)
        {
            InitializeComponent();
            //Cohérence pour l'affichage des titres
            this.Text = this.label1.Text = obj.Exists ? "Détail d'un client " : " Nouveau client"; 
            this.obj = obj;
        }
        #endregion

        #region Gestion du chargement de l'affichage du formulaire
        /// <summary>
        /// Chargement de l'affichage du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //On charge les différentes civilités
            loadGenders(GenderManager.Instance.All());

            //On lie notre objet à notre binding
            this.Id.Text = obj.StringId;
            b.Bind(this.FirstName, "Text", obj, "FirstName");
            b.Bind(this.LastName, "Text", obj, "LastName");
            b.Bind(this.Address1, "Text", obj, "Address1");
            b.Bind(this.Address2, "Text", obj, "Address2");
            b.Bind(this.PhoneNumber, "Text", obj, "PhoneNumber");
            b.Bind(this.MobilePhoneNumber, "Text", obj, "MobilePhoneNumber");
            b.Bind(this.Email, "Text", obj, "Email");
            b.Bind(this.Comments, "Text", obj, "Comments");
            b.Bind(this.DateBirthPicker, "Value", obj, "DateOfBirth");

            if (obj.City != null)
            {
                this.CityPostalCode.Text = obj.City.PostalCode;
                this.CityName.SelectedValue = obj.City.Id;
            }
            b.Bind(this.EmailOnUpdate, "Checked", obj, "EmailOnUpdate");
            b.Populate();
        }
        #endregion

        #region Gestion de la validation du formulaire
        /// <summary>
        /// Gestion de la validation du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validateButton_Click_1(object sender, EventArgs e)
        {
            //On hydrate notre binding
            b.Hydrate();
            obj.Gender = (Gender)this.GenderName.SelectedItem;
            obj.City = (City)this.CityName.SelectedItem;
            //On regarde si notre entité peut être validé en base
            if (obj.validate().Count != 0)
            {
                string error = String.Empty;
                foreach (Customer.ValidationResult warning in obj.validate())
                {
                    switch (warning)
                    {
                        case Customer.ValidationResult.WRONG_LASTNAME:
                            error += "Erreur dans la saisie du nom ( il doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Customer.ValidationResult.WRONG_FIRSTNAME:
                            error += "Erreur dans la saisie du prénom ( il doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Customer.ValidationResult.WRONG_ADRESS:
                            error += "Erreur dans la saisie de l'adresse ( elle doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Customer.ValidationResult.WRONG_CITY:

                            error += "Erreur dans la saisie de la ville ( elle doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Customer.ValidationResult.WRONG_EMAIL:
                            error += "Erreur dans la saisie du mail ( elle doit respecter le format mail )" + Environment.NewLine;
                            break;
                    }
                }
                Utils.Warning(error);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        #endregion

        #region Chargement des genres dans la comboBox
        /// <summary>
        /// Chargement des genres dans la comboBox
        /// </summary>
        /// <param name="genders">Les genres à charger</param>
        private void loadGenders(Gender[] genders)
        {
            List<Gender> genderList = new List<Gender>(genders);
            this.GenderName.DataSource = genderList;
            this.GenderName.ValueMember = "Id";
            this.GenderName.DisplayMember = "Name";
        }
        #endregion

        #region Chargement des villes dans la combobox
        /// <summary>
        /// Chargmeent des villes dans la comboBox
        /// </summary>
        /// <param name="cities"></param>
        private void loadCities(City[] cities)
        {
            this.citiesList = new List<City>(cities);
            this.CityName.DataSource = citiesList;
            this.CityName.ValueMember = "Id";
            this.CityName.DisplayMember = "Name";
        }
        #endregion

        #region Affichage du pays selon la ville
        private void CityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CityName != null){
                this.Country.Text = ((City)this.CityName.SelectedItem).Country.Name;
                return;
            }
            this.Country.Text = String.Empty;
        }
        #endregion

        #region Contrôle de l'affichage des villes selon le code postal
        private void CityPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (this.CityPostalCode.TextLength == 5)
            {
                loadCities(CityManager.Instance.Filter("WHERE code_postal LIKE '" + this.CityPostalCode.Text + "%';"));
            }
        }
        #endregion

        #region Getter du client en cours
        public Customer getCustomer()
        {
            return obj;
        }
        #endregion

    }
}
