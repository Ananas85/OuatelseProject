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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.connexionText = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.factureBtn = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.deconnexionBtn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.clientsBtn = new System.Windows.Forms.Button();
            this.salarieBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.assistanceBtn = new System.Windows.Forms.Button();
            this.venteBtn = new System.Windows.Forms.Button();
            this.produitBtn = new System.Windows.Forms.Button();
            this.roleLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // factureBtn
            // 
            this.factureBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.factureBtn.FlatAppearance.BorderSize = 0;
            this.factureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factureBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factureBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.factureBtn.Location = new System.Drawing.Point(85, 121);
            this.factureBtn.Name = "factureBtn";
            this.factureBtn.Size = new System.Drawing.Size(184, 174);
            this.factureBtn.TabIndex = 2;
            this.factureBtn.Text = "Nouvelle\r\nFacture";
            this.factureBtn.UseVisualStyleBackColor = false;
            this.factureBtn.Click += new System.EventHandler(this.factureBtn_Click);
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.White;
            this.btnLock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.Location = new System.Drawing.Point(546, 64);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 3;
            this.btnLock.Text = "Verrouiller";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // deconnexionBtn
            // 
            this.deconnexionBtn.BackColor = System.Drawing.Color.White;
            this.deconnexionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(108, 16);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(226, 56);
            this.date.TabIndex = 7;
            this.date.Text = "DATE";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hour
            // 
            this.hour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.ForeColor = System.Drawing.Color.LightGray;
            this.hour.Location = new System.Drawing.Point(340, 16);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(187, 56);
            this.hour.TabIndex = 8;
            this.hour.Text = "HEURE";
            this.hour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.button9.Enabled = false;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(85, 301);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(184, 84);
            this.button9.TabIndex = 16;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // clientsBtn
            // 
            this.clientsBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.clientsBtn.FlatAppearance.BorderSize = 0;
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientsBtn.Location = new System.Drawing.Point(275, 121);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(184, 84);
            this.clientsBtn.TabIndex = 17;
            this.clientsBtn.Text = "Clients";
            this.clientsBtn.UseVisualStyleBackColor = false;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // salarieBtn
            // 
            this.salarieBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.salarieBtn.FlatAppearance.BorderSize = 0;
            this.salarieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salarieBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarieBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salarieBtn.Location = new System.Drawing.Point(274, 211);
            this.salarieBtn.Name = "salarieBtn";
            this.salarieBtn.Size = new System.Drawing.Size(184, 84);
            this.salarieBtn.TabIndex = 18;
            this.salarieBtn.Text = "Salariés";
            this.salarieBtn.UseVisualStyleBackColor = false;
            this.salarieBtn.Click += new System.EventHandler(this.salarieBtn_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(274, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 84);
            this.button5.TabIndex = 19;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // assistanceBtn
            // 
            this.assistanceBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.assistanceBtn.FlatAppearance.BorderSize = 0;
            this.assistanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assistanceBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistanceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.assistanceBtn.Location = new System.Drawing.Point(464, 301);
            this.assistanceBtn.Name = "assistanceBtn";
            this.assistanceBtn.Size = new System.Drawing.Size(184, 84);
            this.assistanceBtn.TabIndex = 20;
            this.assistanceBtn.Text = "Assistance";
            this.assistanceBtn.UseVisualStyleBackColor = false;
            this.assistanceBtn.Click += new System.EventHandler(this.assistanceBtn_Click);
            // 
            // venteBtn
            // 
            this.venteBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.venteBtn.FlatAppearance.BorderSize = 0;
            this.venteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.venteBtn.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.venteBtn.Location = new System.Drawing.Point(464, 211);
            this.venteBtn.Name = "venteBtn";
            this.venteBtn.Size = new System.Drawing.Size(184, 84);
            this.venteBtn.TabIndex = 21;
            this.venteBtn.Text = "Ventes";
            this.venteBtn.UseVisualStyleBackColor = false;
            this.venteBtn.Click += new System.EventHandler(this.venteBtn_Click);
            // 
            // produitBtn
            // 
            this.produitBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.produitBtn.FlatAppearance.BorderSize = 0;
            this.produitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.produitBtn.Location = new System.Drawing.Point(464, 121);
            this.produitBtn.Name = "produitBtn";
            this.produitBtn.Size = new System.Drawing.Size(184, 84);
            this.produitBtn.TabIndex = 22;
            this.produitBtn.Text = "Produits / Stock";
            this.produitBtn.UseVisualStyleBackColor = false;
            this.produitBtn.Click += new System.EventHandler(this.produitBtn_Click);
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-26, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(782, 121);
            this.label1.TabIndex = 24;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 415);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.produitBtn);
            this.Controls.Add(this.venteBtn);
            this.Controls.Add(this.assistanceBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.salarieBtn);
            this.Controls.Add(this.clientsBtn);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.date);
            this.Controls.Add(this.deconnexionBtn);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.factureBtn);
            this.Controls.Add(this.username);
            this.Controls.Add(this.connexionText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouatelse - Accueil";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label connexionText;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button factureBtn;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button deconnexionBtn;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button salarieBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button assistanceBtn;
        private System.Windows.Forms.Button venteBtn;
        private System.Windows.Forms.Button produitBtn;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.Label label1;
    }
}