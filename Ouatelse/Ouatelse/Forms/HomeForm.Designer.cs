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
            this.clientsBtn = new System.Windows.Forms.Button();
            this.salarieBtn = new System.Windows.Forms.Button();
            this.holliday = new System.Windows.Forms.Button();
            this.assistanceBtn = new System.Windows.Forms.Button();
            this.venteBtn = new System.Windows.Forms.Button();
            this.produitBtn = new System.Windows.Forms.Button();
            this.roleLbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // connexionText
            // 
            this.connexionText.BackColor = System.Drawing.Color.Transparent;
            this.connexionText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexionText.Location = new System.Drawing.Point(551, 20);
            this.connexionText.Name = "connexionText";
            this.connexionText.Size = new System.Drawing.Size(171, 20);
            this.connexionText.TabIndex = 0;
            this.connexionText.Text = "Connecté en tant que";
            this.connexionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(548, 40);
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
            this.factureBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factureBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.factureBtn.Image = global::Ouatelse.Properties.Resources.page_add;
            this.factureBtn.Location = new System.Drawing.Point(91, 133);
            this.factureBtn.Name = "factureBtn";
            this.factureBtn.Size = new System.Drawing.Size(184, 264);
            this.factureBtn.TabIndex = 2;
            this.factureBtn.Text = "Nouvelle\r\nFacture";
            this.factureBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.factureBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.factureBtn.UseVisualStyleBackColor = false;
            this.factureBtn.Click += new System.EventHandler(this.factureBtn_Click);
            // 
            // btnLock
            // 
            this.btnLock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLock.Location = new System.Drawing.Point(548, 75);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 3;
            this.btnLock.Text = "Verrouiller";
            this.btnLock.UseVisualStyleBackColor = false;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // deconnexionBtn
            // 
            this.deconnexionBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deconnexionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.deconnexionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deconnexionBtn.Location = new System.Drawing.Point(629, 75);
            this.deconnexionBtn.Name = "deconnexionBtn";
            this.deconnexionBtn.Size = new System.Drawing.Size(93, 23);
            this.deconnexionBtn.TabIndex = 4;
            this.deconnexionBtn.Text = "Se déconnecter";
            this.deconnexionBtn.UseVisualStyleBackColor = false;
            this.deconnexionBtn.Click += new System.EventHandler(this.deconnexionBtn_Click);
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(307, 28);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(226, 31);
            this.date.TabIndex = 7;
            this.date.Text = "DATE";
            this.date.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // hour
            // 
            this.hour.BackColor = System.Drawing.Color.Transparent;
            this.hour.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(105)))), ((int)(((byte)(54)))));
            this.hour.Location = new System.Drawing.Point(335, 56);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(192, 40);
            this.hour.TabIndex = 8;
            this.hour.Text = "HEURE";
            this.hour.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clientsBtn
            // 
            this.clientsBtn.BackColor = System.Drawing.Color.Orange;
            this.clientsBtn.FlatAppearance.BorderSize = 0;
            this.clientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientsBtn.Image = global::Ouatelse.Properties.Resources.users_4;
            this.clientsBtn.Location = new System.Drawing.Point(281, 133);
            this.clientsBtn.Name = "clientsBtn";
            this.clientsBtn.Size = new System.Drawing.Size(184, 84);
            this.clientsBtn.TabIndex = 17;
            this.clientsBtn.Text = "Clients";
            this.clientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientsBtn.UseVisualStyleBackColor = false;
            this.clientsBtn.Click += new System.EventHandler(this.clientsBtn_Click);
            // 
            // salarieBtn
            // 
            this.salarieBtn.BackColor = System.Drawing.Color.DeepPink;
            this.salarieBtn.FlatAppearance.BorderSize = 0;
            this.salarieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salarieBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarieBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.salarieBtn.Image = global::Ouatelse.Properties.Resources.user_suit;
            this.salarieBtn.Location = new System.Drawing.Point(280, 223);
            this.salarieBtn.Name = "salarieBtn";
            this.salarieBtn.Size = new System.Drawing.Size(184, 84);
            this.salarieBtn.TabIndex = 18;
            this.salarieBtn.Text = "Salariés";
            this.salarieBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salarieBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salarieBtn.UseVisualStyleBackColor = false;
            this.salarieBtn.Click += new System.EventHandler(this.salarieBtn_Click);
            // 
            // holliday
            // 
            this.holliday.BackColor = System.Drawing.Color.RoyalBlue;
            this.holliday.FlatAppearance.BorderSize = 0;
            this.holliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.holliday.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holliday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.holliday.Image = global::Ouatelse.Properties.Resources.plane;
            this.holliday.Location = new System.Drawing.Point(280, 313);
            this.holliday.Name = "holliday";
            this.holliday.Size = new System.Drawing.Size(184, 84);
            this.holliday.TabIndex = 19;
            this.holliday.Text = "Congés";
            this.holliday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.holliday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.holliday.UseVisualStyleBackColor = false;
            this.holliday.Click += new System.EventHandler(this.holliday_Click);
            // 
            // assistanceBtn
            // 
            this.assistanceBtn.BackColor = System.Drawing.Color.IndianRed;
            this.assistanceBtn.FlatAppearance.BorderSize = 0;
            this.assistanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assistanceBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assistanceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.assistanceBtn.Image = global::Ouatelse.Properties.Resources.life_vest;
            this.assistanceBtn.Location = new System.Drawing.Point(470, 313);
            this.assistanceBtn.Name = "assistanceBtn";
            this.assistanceBtn.Size = new System.Drawing.Size(184, 84);
            this.assistanceBtn.TabIndex = 20;
            this.assistanceBtn.Text = "Assistance";
            this.assistanceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.assistanceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.assistanceBtn.UseVisualStyleBackColor = false;
            this.assistanceBtn.Click += new System.EventHandler(this.assistanceBtn_Click);
            // 
            // venteBtn
            // 
            this.venteBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.venteBtn.FlatAppearance.BorderSize = 0;
            this.venteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.venteBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.venteBtn.Image = global::Ouatelse.Properties.Resources.package_go;
            this.venteBtn.Location = new System.Drawing.Point(470, 223);
            this.venteBtn.Name = "venteBtn";
            this.venteBtn.Size = new System.Drawing.Size(184, 84);
            this.venteBtn.TabIndex = 21;
            this.venteBtn.Text = "Ventes";
            this.venteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.venteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.venteBtn.UseVisualStyleBackColor = false;
            this.venteBtn.Click += new System.EventHandler(this.venteBtn_Click);
            // 
            // produitBtn
            // 
            this.produitBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.produitBtn.FlatAppearance.BorderSize = 0;
            this.produitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.produitBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.produitBtn.Image = global::Ouatelse.Properties.Resources.street_stall;
            this.produitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.produitBtn.Location = new System.Drawing.Point(470, 133);
            this.produitBtn.Name = "produitBtn";
            this.produitBtn.Size = new System.Drawing.Size(184, 84);
            this.produitBtn.TabIndex = 22;
            this.produitBtn.Text = "Produits\r\nStock";
            this.produitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.produitBtn.UseVisualStyleBackColor = false;
            this.produitBtn.Click += new System.EventHandler(this.produitBtn_Click);
            // 
            // roleLbl
            // 
            this.roleLbl.BackColor = System.Drawing.Color.Transparent;
            this.roleLbl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLbl.Location = new System.Drawing.Point(548, 53);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(174, 19);
            this.roleLbl.TabIndex = 23;
            this.roleLbl.Text = "ROLE";
            this.roleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(598, 400);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Information sur la licence";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ouatelse.Properties.Resources.Ouatelse_073;
            this.ClientSize = new System.Drawing.Size(732, 417);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.produitBtn);
            this.Controls.Add(this.venteBtn);
            this.Controls.Add(this.assistanceBtn);
            this.Controls.Add(this.holliday);
            this.Controls.Add(this.salarieBtn);
            this.Controls.Add(this.clientsBtn);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.date);
            this.Controls.Add(this.deconnexionBtn);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.factureBtn);
            this.Controls.Add(this.username);
            this.Controls.Add(this.connexionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouatelse - Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button clientsBtn;
        private System.Windows.Forms.Button salarieBtn;
        private System.Windows.Forms.Button holliday;
        private System.Windows.Forms.Button assistanceBtn;
        private System.Windows.Forms.Button venteBtn;
        private System.Windows.Forms.Button produitBtn;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}