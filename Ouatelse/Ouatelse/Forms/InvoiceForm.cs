using System;
using System.Windows.Forms;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace Ouatelse.Forms
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice()
            {
                Employee = EmployeeManager.Instance.First(""),
                Payment = PaymentManager.Instance.First(""),
                Customer = CustomerManager.Instance.First("")
            };
            InvoiceManager.Instance.Save(invoice);

            Utils.Info(Database.Instance.LastInsertId.ToString());
        }
    }
}
