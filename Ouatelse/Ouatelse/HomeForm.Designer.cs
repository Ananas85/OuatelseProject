namespace Ouatelse
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            this.connexionText = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.deconnexionBtn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.roleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connexionText
            // 
            this.connexionText.Location = new System.Drawing.Point(549, 9);
            this.connexionText.Name = "connexionText";
            this.connexionText.Size = new System.Drawing.Size(171, 20);
            this.connexionText.TabIndex = 0;
            this.connexionText.Text = "Connecté en tant que";
            this.connexionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(546, 29);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(174, 13);
            this.username.TabIndex = 1;
            this.username.Text = "USERNAME";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(83, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 174);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nouvelle\r\nFacture";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.Transparent;
            this.btnLock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLock.Location = new System.Drawing.Point(546, 64);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 3;
            this.btnLock.Text = "Vérrouiller";
            this.btnLock.UseVisualStyleBackColor = false;
            // 
            // deconnexionBtn
            // 
            this.deconnexionBtn.BackColor = System.Drawing.Color.Transparent;
            this.deconnexionBtn.Location = new System.Drawing.Point(627, 64);
            this.deconnexionBtn.Name = "deconnexionBtn";
            this.deconnexionBtn.Size = new System.Drawing.Size(93, 23);
            this.deconnexionBtn.TabIndex = 4;
            this.deconnexionBtn.Text = "Se déconnecter";
            this.deconnexionBtn.UseVisualStyleBackColor = false;
            this.deconnexionBtn.Click += new System.EventHandler(this.deconnexionBtn_Click);
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(108, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(432, 33);
            this.date.TabIndex = 7;
            this.date.Text = "DATE";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hour
            // 
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.Location = new System.Drawing.Point(108, 42);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(432, 26);
            this.hour.TabIndex = 8;
            this.hour.Text = "HEURE";
            this.hour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(83, 289);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(184, 84);
            this.button9.TabIndex = 16;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(273, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 84);
            this.button3.TabIndex = 17;
            this.button3.Text = "Clients";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(272, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 84);
            this.button4.TabIndex = 18;
            this.button4.Text = "Salariés";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(272, 289);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 84);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(462, 289);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 84);
            this.button6.TabIndex = 20;
            this.button6.Text = "Assistance";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(462, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 84);
            this.button7.TabIndex = 21;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(462, 109);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(184, 84);
            this.button8.TabIndex = 22;
            this.button8.Text = "Produits / Stock";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // roleLbl
            // 
            this.roleLbl.Location = new System.Drawing.Point(546, 42);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(174, 19);
            this.roleLbl.TabIndex = 23;
            this.roleLbl.Text = "ROLE";
            this.roleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 415);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.date);
            this.Controls.Add(this.deconnexionBtn);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.connexionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouatelse - Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label connexionText;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button deconnexionBtn;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label roleLbl;
    }
}