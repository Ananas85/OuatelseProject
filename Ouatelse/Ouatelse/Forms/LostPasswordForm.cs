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

namespace Ouatelse
{
    public partial class LostPasswordForm : Form
    {
        public LostPasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = EmployeeManager.Instance.First("WHERE mail='" + this.emailEntry.Text + "'");
            if (employee != null)
            {
                Utils.Info("Vous êtes dans la base, on va vous envoyé un mail avec votre mot de passe");
                MailSender.Instance.sendMail(employee.Email, "retrouve ton mot de passe", "Le voilà, gros bisous");
            }
            else
            {
                Utils.Warning("Vous n'êtes pas dans la base de données");
            }

        }
    }
}
