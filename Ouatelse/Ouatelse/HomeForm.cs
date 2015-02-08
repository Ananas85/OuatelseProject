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

namespace Ouatelse
{
    public partial class HomeForm : Form
    {
        public Employee employee { get; set; }
        public HomeForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            //Set the time and the hour
            setTime();


            this.username.Text = employee.FirstName + " " + employee.LastName;

            //Centre du text de connexion
            int center = this.connexionText.Right - this.connexionText.Width / 2;
            this.username.Location = new Point(center - this.username.Width / 2, this.username.Top);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setTime();
        }

        private void setTime()
        {
            this.date.Text = DateTime.Now.ToShortDateString();
            this.hour.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
