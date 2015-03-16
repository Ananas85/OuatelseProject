using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ouatelse.Models;

namespace Ouatelse.Forms
{
    public partial class QuantityForm : Form
    {
        private readonly InvoiceProduct product;

        public QuantityForm(InvoiceProduct product)
        {
            this.product = product;
            InitializeComponent();
            this.numericUpDown1.Value = product.Quantity;
            this.label1.Text = product.Product.Designation;
        }

        private void QuantityForm_Load(object sender, EventArgs e)
        {

        }

        public decimal Quantity
        {
            get { return this.numericUpDown1.Value; }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
