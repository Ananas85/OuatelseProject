using Ouatelse.Managers;
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
    public partial class LockForm : Form
    {
        public LockForm()
        {
            InitializeComponent();
            this.username.Text = AuthManager.Instance.User.FirstName + " " + AuthManager.Instance.User.LastName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (AuthManager.Instance.User.Password == this.passwordEntry.Text)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                Utils.Warning("Mot de passe erroné");
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            AuthManager.Instance.User = null;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LostPasswordForm lostpass = new LostPasswordForm();
            lostpass.ShowDialog();
        }
    }
}
