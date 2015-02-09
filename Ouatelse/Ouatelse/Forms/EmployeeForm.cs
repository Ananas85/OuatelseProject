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
            b.Bind(this.lastnameTB, "Text", obj, "LastName");
            b.Bind(this.lastnameTB, "Text", obj, "LastName");
            // TODO: FINISH TO POPULATE...







            b.Populate();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            b.Hydrate();
            EmployeeManager.Instance.Save(obj);
        }
    }
}
