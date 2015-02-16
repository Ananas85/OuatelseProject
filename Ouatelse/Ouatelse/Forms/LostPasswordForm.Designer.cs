namespace Ouatelse
{
    partial class LostPasswordForm
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
            this.yesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.emailEntry = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yesBtn
            // 
            this.yesBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.yesBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.yesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesBtn.ForeColor = System.Drawing.Color.White;
            this.yesBtn.Location = new System.Drawing.Point(190, 65);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(75, 23);
            this.yesBtn.TabIndex = 0;
            this.yesBtn.Text = "Ok";
            this.yesBtn.UseVisualStyleBackColor = false;
            this.yesBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresse mail : ";
            // 
            // emailEntry
            // 
            this.emailEntry.Location = new System.Drawing.Point(121, 25);
            this.emailEntry.Name = "emailEntry";
            this.emailEntry.Size = new System.Drawing.Size(144, 20);
            this.emailEntry.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.IndianRed;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(88, 65);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Annuler";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // LostPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(283, 101);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.emailEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yesBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LostPasswordForm";
            this.Text = "Mot de passe oublié";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailEntry;
        private System.Windows.Forms.Button cancelBtn;
    }
}