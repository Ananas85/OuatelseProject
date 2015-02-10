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
        
        public EmployeeForm(Employee obj)
        {
            InitializeComponent();
            this.obj = obj;
        }


        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            List<Store> stores = new List<Store>(StoreManager.Instance.All());

            this.storeBox.DataSource = stores;
            this.storeBox.ValueMember = "Id";
            this.storeBox.DisplayMember = "Address";

           /*
            * CANNOT POPULATE DUE TO ERRORS TYPES IN BINDING.
            * 
            b.Bind(this.idTB, "Text", obj, "Id.ToString()");
            */
            b.Bind(this.firstnameTB, "Text", obj, "FirstName");
            b.Bind(this.lastnameTB, "Text", obj, "LastName");
            
            //b.Bind(this.roleTB, "Text", obj, "Role.Name");
            if (obj.Store != null)
                this.storeBox.SelectedValue = obj.Store.Id;
            b.Bind(this.adress1TB, "Text", obj, "Address1");
            b.Bind(this.adress2TB, "Text", obj, "Address2");
            /*b.Bind(this.zipCodeTB, "Text", obj, "City.PostalCode.ToString()");
            b.Bind(this.cityTB, "Text", obj, "City.Name");
            b.Bind(this.countryBox, "Value", obj, "Country.Name");
            b.Bind(this.mobilePhoneTB, "Text", obj, "MobilePhoneNumber");
            b.Bind(this.phoneTB, "Text", obj, "PhoneNumber");
            b.Bind(this.mailTB, "Text", obj, "Email");
            b.Bind(this.commentsTB, "Text", obj, "Comments")
            */
            b.Populate();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            b.Hydrate();
            obj.Store = (Store)this.storeBox.SelectedItem;
            EmployeeManager.Instance.Save(obj);
        }
    }
}
