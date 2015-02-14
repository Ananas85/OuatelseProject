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
        Employee obj = null;
        Binding b = new Binding();
        List<City> cities = null;
        List<Role> roles = null;
        List<Store> stores = null;

        public EmployeeForm(Employee obj)
        {
            InitializeComponent();
            this.Text = this.label1.Text = obj.Exists ? "Détail d'un salarié " : " Nouveau salarié"; 
            this.obj = obj;
        }


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
                            error += "Erreur dans la saisie du numéro de téléphone" + Environment.NewLine;
                            break;
                        case Employee.ValidationResult.WRONG_MOBILEPHONENUMBER:
                            error += "Erreur dans la saisie du numéro de téléphone portable" + Environment.NewLine;
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

        private void loadGenders(Gender[] genders)
        {
            List<Gender> genderList = new List<Gender>(genders);
            this.GenderName.DataSource = genderList;
            this.GenderName.ValueMember = "Id";
            this.GenderName.DisplayMember = "Name";
        }

        private void loadCities(City[] cities)
        {
            this.cities = new List<City>(cities);
            this.CityName.DataSource = cities;
            this.CityName.ValueMember = "Id";
            this.CityName.DisplayMember = "Name";
        }

        private void loadRoles(Role[] roles)
        {
            this.roles = new List<Role>(roles);
            this.Role.DataSource = roles;
            this.Role.ValueMember = "Id";
            this.Role.DisplayMember = "Name";
        }

        private void loadStores(Store[] stores)
        {
            this.stores = new List<Store>(stores);
            this.Store.DataSource = stores;
            this.Store.ValueMember = "Id";
            this.Store.DisplayMember = "Name";
        }

        private void CityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CityName != null)
                this.Country.Text = ((City)this.CityName.SelectedItem).Country.Name;
            else
                this.Country.Text = String.Empty;
        }


        private bool verifyData()
        {
            return true;
        }

        public Employee getEmployee()
        {
            return obj;
        }

        private void CityPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (this.CityPostalCode.TextLength == 5)
            {
                loadCities(CityManager.Instance.Filter("WHERE code_postal LIKE '" + this.CityPostalCode.Text + "%';"));
            }
        }



    }
}
