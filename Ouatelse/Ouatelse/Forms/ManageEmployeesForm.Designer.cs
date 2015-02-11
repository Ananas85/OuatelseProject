namespace Ouatelse.Forms
{
    partial class ManageEmployeesForm
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
            this.listView_employees = new System.Windows.Forms.ListView();
            this.reference_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstname_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.role_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.store_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.ModifyEmployeeButton = new System.Windows.Forms.Button();
            this.NewEmployeeButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_employees
            // 
            this.listView_employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reference_column,
            this.lastname_column,
            this.firstname_column,
            this.mail_column,
            this.role_column,
            this.store_column});
            this.listView_employees.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_employees.FullRowSelect = true;
            this.listView_employees.GridLines = true;
            this.listView_employees.Location = new System.Drawing.Point(12, 202);
            this.listView_employees.Margin = new System.Windows.Forms.Padding(2);
            this.listView_employees.MultiSelect = false;
            this.listView_employees.Name = "listView_employees";
            this.listView_employees.Size = new System.Drawing.Size(887, 277);
            this.listView_employees.TabIndex = 23;
            this.listView_employees.UseCompatibleStateImageBehavior = false;
            this.listView_employees.View = System.Windows.Forms.View.Details;
            this.listView_employees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_employees_MouseClick);
            this.listView_employees.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_employees_MouseDoubleClick);
            // 
            // reference_column
            // 
            this.reference_column.Text = "Référence";
            this.reference_column.Width = 118;
            // 
            // lastname_column
            // 
            this.lastname_column.Text = "Nom";
            this.lastname_column.Width = 117;
            // 
            // firstname_column
            // 
            this.firstname_column.Text = "Prénom";
            this.firstname_column.Width = 156;
            // 
            // mail_column
            // 
            this.mail_column.Text = "Adresse mail";
            this.mail_column.Width = 150;
            // 
            // role_column
            // 
            this.role_column.Text = "Rôle";
            this.role_column.Width = 127;
            // 
            // store_column
            // 
            this.store_column.Text = "Magasin";
            this.store_column.Width = 232;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Ouatelse.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(630, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.BackColor = System.Drawing.Color.IndianRed;
            this.DeleteEmployeeButton.FlatAppearance.BorderSize = 0;
            this.DeleteEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(392, 143);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(195, 41);
            this.DeleteEmployeeButton.TabIndex = 31;
            this.DeleteEmployeeButton.Text = "Supprimer un salarié";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = false;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // ModifyEmployeeButton
            // 
            this.ModifyEmployeeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ModifyEmployeeButton.FlatAppearance.BorderSize = 0;
            this.ModifyEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ModifyEmployeeButton.Location = new System.Drawing.Point(202, 143);
            this.ModifyEmployeeButton.Name = "ModifyEmployeeButton";
            this.ModifyEmployeeButton.Size = new System.Drawing.Size(184, 41);
            this.ModifyEmployeeButton.TabIndex = 30;
            this.ModifyEmployeeButton.Text = "Modifier un salarié";
            this.ModifyEmployeeButton.UseVisualStyleBackColor = false;
            this.ModifyEmployeeButton.Click += new System.EventHandler(this.ModifyEmployeeButton_Click);
            // 
            // NewEmployeeButton
            // 
            this.NewEmployeeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NewEmployeeButton.FlatAppearance.BorderSize = 0;
            this.NewEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEmployeeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewEmployeeButton.Location = new System.Drawing.Point(12, 143);
            this.NewEmployeeButton.Name = "NewEmployeeButton";
            this.NewEmployeeButton.Size = new System.Drawing.Size(184, 41);
            this.NewEmployeeButton.TabIndex = 29;
            this.NewEmployeeButton.Text = "Nouveau salarié";
            this.NewEmployeeButton.UseVisualStyleBackColor = false;
            this.NewEmployeeButton.Click += new System.EventHandler(this.NewEmployeeButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(668, 152);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(231, 26);
            this.searchBox.TabIndex = 28;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(151, 44);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(342, 47);
            this.customerLabel.TabIndex = 27;
            this.customerLabel.Text = "Gestion des salariés";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(-27, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(942, 142);
            this.label1.TabIndex = 26;
            // 
            // employeesNumber
            // 
            this.employeesNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesNumber.Location = new System.Drawing.Point(773, 486);
            this.employeesNumber.Name = "employeesNumber";
            this.employeesNumber.Size = new System.Drawing.Size(126, 22);
            this.employeesNumber.TabIndex = 33;
            this.employeesNumber.Text = "--";
            this.employeesNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 505);
            this.Controls.Add(this.employeesNumber);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.ModifyEmployeeButton);
            this.Controls.Add(this.NewEmployeeButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_employees);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageEmployeesForm";
            this.Text = "Ouatelse - Gestion des salariés";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_employees;
        private System.Windows.Forms.ColumnHeader reference_column;
        private System.Windows.Forms.ColumnHeader lastname_column;
        private System.Windows.Forms.ColumnHeader firstname_column;
        private System.Windows.Forms.ColumnHeader mail_column;
        private System.Windows.Forms.ColumnHeader role_column;
        private System.Windows.Forms.ColumnHeader store_column;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button ModifyEmployeeButton;
        private System.Windows.Forms.Button NewEmployeeButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label employeesNumber;
    }
}
