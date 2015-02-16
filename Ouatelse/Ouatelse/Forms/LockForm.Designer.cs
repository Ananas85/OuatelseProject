namespace Ouatelse.Forms
{
    partial class LockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.quitBtn = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.forgotPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(31, 194);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(306, 21);
            this.username.TabIndex = 1;
            this.username.Text = "USERNAME";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connecté en tant que";
            // 
            // passwordEntry
            // 
            this.passwordEntry.Location = new System.Drawing.Point(88, 218);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.Size = new System.Drawing.Size(193, 20);
            this.passwordEntry.TabIndex = 3;
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.IndianRed;
            this.quitBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.quitBtn.FlatAppearance.BorderSize = 0;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.Color.White;
            this.quitBtn.Location = new System.Drawing.Point(31, 264);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(118, 33);
            this.quitBtn.TabIndex = 10;
            this.quitBtn.TabStop = false;
            this.quitBtn.Text = "Déconnexion";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(219, 264);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(118, 33);
            this.btnOk.TabIndex = 9;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "Connexion";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Location = new System.Drawing.Point(129, 239);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(111, 13);
            this.forgotPassword.TabIndex = 11;
            this.forgotPassword.TabStop = true;
            this.forgotPassword.Text = "Mot de passe oublié ?";
            this.forgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotPassword_LinkClicked);
            // 
            // LockForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ouatelse.Properties.Resources.Ouatelse_04;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(369, 318);
            this.ControlBox = false;
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LockForm";
            this.Text = "Session verrouillée";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.LinkLabel forgotPassword;
    }
}