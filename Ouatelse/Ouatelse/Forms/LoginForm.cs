using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ouatelse.Managers;
using Ouatelse.Models;

namespace Ouatelse
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.label3.Text = Properties.Settings.Default.CurrentStore.NameTwoLines;
            
        }

        private void forgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LostPasswordForm lostpass = new LostPasswordForm();
            lostpass.ShowDialog();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (AuthManager.Instance.Login(this.usernameEntry.Text, this.passwordEntry.Text))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                return;
            }
            Utils.Warning("Ce compte n'existe pas ou identifiants invalides.");
            this.DialogResult = System.Windows.Forms.DialogResult.None;
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
