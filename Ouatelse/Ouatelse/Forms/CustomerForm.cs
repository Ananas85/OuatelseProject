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
        Customer obj = null;
        Binding b = new Binding();
        List<City> citiesList = null;
        
        public CustomerForm(Customer obj)
        {
            InitializeComponent();
            this.Text = this.label1.Text = obj.Exists ? "Détail d'un client " : " Nouveau client"; 
            this.obj = obj;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            loadGenders(GenderManager.Instance.All());

            this.Id.Text = obj.StringId;
            b.Bind(this.FirstName, "Text", obj, "LastName");
            b.Bind(this.LastName, "Text", obj, "FirstName");
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

            b.Populate();
        }

        private void validateButton_Click_1(object sender, EventArgs e)
        {
            b.Hydrate();
            obj.Gender = (Gender)this.GenderName.SelectedItem;
            obj.City = (City)this.CityName.SelectedItem;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
            this.citiesList = new List<City>(cities);
            this.CityName.DataSource = citiesList;
            this.CityName.ValueMember = "Id";
            this.CityName.DisplayMember = "Name";
        }

        private void CityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CityName != null)
                this.Country.Text = ((City)this.CityName.SelectedItem).Country.Name;
            else
                this.Country.Text = String.Empty;
        }

        private void CityPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (this.CityPostalCode.TextLength == 5)
            {
                loadCities(CityManager.Instance.Filter("WHERE code_postal LIKE '" + this.CityPostalCode.Text + "%';"));
            }
        }

        private bool verifyData()
        {
            return true;
        }

        public Customer getCustomer()
        {
            return obj;
        }

    }
}
