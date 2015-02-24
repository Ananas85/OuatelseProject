using Ouatelse.Managers;
using Ouatelse.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ouatelse.Forms
{
    public partial class EmployeeForm : Form
    {
        #region Attributs
        Employee obj = null;
        Binding b = new Binding();
        List<City> cities = null;
        List<Role> roles = null;
        List<Store> stores = null;
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="obj"></param>
        public EmployeeForm(Employee obj)
        {
            InitializeComponent();
            this.Text = this.label1.Text = obj.Exists ? "Détail d'un salarié " : " Nouveau salarié"; 
            this.obj = obj;
        }
        #endregion

        #region Chargement de la fenêtre
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            loadGenders(GenderManager.Instance.All());
            loadRoles(RoleManager.Instance.All());
            loadStores(StoreManager.Instance.All());

            this.Id.Text = obj.StringId;
       
            b.Bind(this.FirstName, "Text", obj, "FirstName");
            b.Bind(this.LastName, "Text", obj, "LastName");
            b.Bind(this.Username, "Text", obj, "Username");
            b.Bind(this.Address1, "Text", obj, "Address1");
            b.Bind(this.Address2, "Text", obj, "Address2");
            b.Bind(this.PhoneNumber, "Text", obj, "PhoneNumber");
            b.Bind(this.MobilePhoneNumber, "Text", obj, "MobilePhoneNumber");
            b.Bind(this.Email, "Text", obj, "Email");
            b.Bind(this.Comments, "Text", obj, "Comments");
            b.Bind(this.DateBirthPicker, "Value", obj, "DateOfBirth");
            if (obj.Store != null)
                this.Store.SelectedValue = obj.Store.Id;

            if (obj.City != null)
            {
                this.CityPostalCode.Text = obj.City.PostalCode;
                this.CityName.SelectedValue = obj.City.Id;
            }

             if (obj.Role != null)
                this.Role.SelectedValue = obj.Role.Id;

            b.Bind(this.EmailOnUpdate, "Checked", obj, "EmailOnUpdate");
            b.Populate();
        }
        #endregion

        #region Méthode d'évenement du clic sur le bouton de validation
        /// <summary>
        /// Méthode d'évenement du clic sur le bouton de validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void validateButton_Click(object sender, EventArgs e)
        {
            b.Hydrate();
            obj.Gender = (Gender)this.GenderName.SelectedItem;
            obj.City = (City)this.CityName.SelectedItem;
            obj.Store = (Store)this.Store.SelectedItem;
            obj.Role = (Role)this.Role.SelectedItem; 
            if (obj.validate().Count != 0)
            {
                string error = String.Empty;
                foreach (Employee.ValidationResult warning in obj.validate())
                {
                    switch (warning)
                    {
                        case Employee.ValidationResult.WRONG_LASTNAME:
                            error += "Erreur dans la saisie du nom ( il doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_FIRSTNAME:
                            error += "Erreur dans la saisie du prénom ( il doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_USERNAME:
                            error += "Erreur dans la saisie de l'identifiant ( il doit être obligatoirement rempli et ne doit pas contenir de caractères spéciaux )" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_ADRESS:
                            error += "Erreur dans la saisie de l'adresse ( elle doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_CITY:

                            error += "Erreur dans la saisie de la ville ( elle doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_STORE:

                            error += "Erreur dans la saisie du magasin ( elle doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_ROLE:

                            error += "Erreur dans la saisie du rôle ( elle doit obligatoirement être rempli )" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_EMAIL:
                            error += "Erreur dans la saisie du mail ( elle doit respecter le format mail )" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_PHONENUMBER:
                            error += "Erreur dans la saisie du numéro de téléphone ( 10 caractères )" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_MOBILEPHONENUMBER:
                            error += "Erreur dans la saisie du numéro de téléphone portable ( 10 caractères )" + Environment.NewLine;
                            break;
                    }
                }
                Utils.Warning(error);
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
           
        }
        #endregion

        #region Chargement des attributs étrangers
        /// <summary>
        /// Chargement des civilités
        /// </summary>
        /// <param name="genders">Tableau des civilités</param>
        private void loadGenders(Gender[] genders)
        {
            List<Gender> genderList = new List<Gender>(genders);
            this.GenderName.DataSource = genderList;
            this.GenderName.ValueMember = "Id";
            this.GenderName.DisplayMember = "Name";
        }

        /// <summary>
        /// Chargement des villes
        /// </summary>
        /// <param name="cities">Tableau des villes</param>
        private void loadCities(City[] cities)
        {
            this.cities = new List<City>(cities);
            this.CityName.DataSource = cities;
            this.CityName.ValueMember = "Id";
            this.CityName.DisplayMember = "Name";
        }

        /// <summary>
        /// Chargement des rôles
        /// </summary>
        /// <param name="roles">Tableau des rôles</param>
        private void loadRoles(Role[] roles)
        {
            this.roles = new List<Role>(roles);
            this.Role.DataSource = roles;
            this.Role.ValueMember = "Id";
            this.Role.DisplayMember = "Name";
        }

        /// <summary>
        /// Chargement des magasins
        /// </summary>
        /// <param name="stores">Tableau des magasins</param>
        private void loadStores(Store[] stores)
        {
            this.stores = new List<Store>(stores);
            this.Store.DataSource = stores;
            this.Store.ValueMember = "Id";
            this.Store.DisplayMember = "Name";
        }
        #endregion

        #region Affichage dynamiques (ville et pays)
        /// <summary>
        /// Affichage du pays en fonction de la ville
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CityName != null)
                this.Country.Text = ((City)this.CityName.SelectedItem).Country.Name;
            else
                this.Country.Text = String.Empty;
        }

        /// <summary>
        /// Affichage de la ville en fonction du code postal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (this.CityPostalCode.TextLength == 5)
            {
                loadCities(CityManager.Instance.Filter("WHERE code_postal LIKE '" + this.CityPostalCode.Text + "%';"));
            }
        }
        #endregion

        #region Verificateurs dynamiques de saisie
        /// <summary>
        /// Vérificateur de numéro de téléphone fixe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                Utils.Info("Uniquement les chiffres sont autorisés");
                e.Handled = true;
            }
        }

        /// <summary>
        /// Vérificateur de numéro de téléphone mobile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MobilePhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                Utils.Info("Uniquement les chiffres sont autorisés");
                e.Handled = true;
            }
        }

        /// <summary>
        /// Vérificateur d'identifiant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                Utils.Info("Uniquement les lettres et chiffres sont autorisés");
                e.Handled = true;
            }
        }

        #endregion

        #region Autres
        private bool verifyData()
        {
            return true;
        }

        public Employee getEmployee()
        {
            return obj;
        }
        #endregion

    }
}
