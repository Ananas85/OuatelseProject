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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEmployeesForm));
            this.listView_employees = new System.Windows.Forms.ListView();
            this.reference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.store = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rightClickEmployees = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editThisEmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.ModifyEmployeeButton = new System.Windows.Forms.Button();
            this.NewEmployeeButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.employeeLabel = new System.Windows.Forms.Label();
            this.employeesNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rightClickEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_employees
            // 
            this.listView_employees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.reference,
            this.lastname,
            this.firstname,
            this.mail,
            this.role,
            this.store});
            this.listView_employees.ContextMenuStrip = this.rightClickEmployees;
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
            this.listView_employees.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_employees_ColumnClick);
            this.listView_employees.ItemActivate += new System.EventHandler(this.listView_employees_ItemActivate);
            this.listView_employees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_employees_MouseClick);
            this.listView_employees.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_employees_MouseDoubleClick);
            // 
            // reference
            // 
            this.reference.Name = "reference";
            this.reference.Text = "Référence";
            this.reference.Width = 118;
            // 
            // lastname
            // 
            this.lastname.Name = "lastname";
            this.lastname.Text = "Nom";
            this.lastname.Width = 117;
            // 
            // firstname
            // 
            this.firstname.Name = "firstname";
            this.firstname.Text = "Prénom";
            this.firstname.Width = 156;
            // 
            // mail
            // 
            this.mail.Name = "mail";
            this.mail.Text = "Adresse mail";
            this.mail.Width = 150;
            // 
            // role
            // 
            this.role.Name = "role";
            this.role.Text = "Rôle";
            this.role.Width = 127;
            // 
            // store
            // 
            this.store.Name = "store";
            this.store.Text = "Magasin";
            this.store.Width = 232;
            // 
            // rightClickEmployees
            // 
            this.rightClickEmployees.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editThisEmployeeMenuItem,
            this.deleteThisEmployee});
            this.rightClickEmployees.Name = "rightClickListView";
            this.rightClickEmployees.Size = new System.Drawing.Size(181, 48);
            // 
            // editThisEmployeeMenuItem
            // 
            this.editThisEmployeeMenuItem.Name = "editThisEmployeeMenuItem";
            this.editThisEmployeeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editThisEmployeeMenuItem.Text = "Modifier ce salarié";
            this.editThisEmployeeMenuItem.Click += new System.EventHandler(this.editThisEmployeeMenuItem_Click);
            // 
            // deleteThisEmployee
            // 
            this.deleteThisEmployee.Name = "deleteThisEmployee";
            this.deleteThisEmployee.Size = new System.Drawing.Size(180, 22);
            this.deleteThisEmployee.Text = "Supprimer ce salarié";
            this.deleteThisEmployee.Click += new System.EventHandler(this.deleteThisEmployeeMenuItem_Click);
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
            this.searchBox.TextChanged += new System.EventHandler(this.Reload);
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeLabel.ForeColor = System.Drawing.Color.White;
            this.employeeLabel.Location = new System.Drawing.Point(191, 32);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(342, 47);
            this.employeeLabel.TabIndex = 27;
            this.employeeLabel.Text = "Gestion des salariés";
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(597, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 119);
            this.label1.TabIndex = 34;
            // 
            // ManageEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Ouatelse.Properties.Resources.Ouatelse_073;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(913, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeesNumber);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.ModifyEmployeeButton);
            this.Controls.Add(this.NewEmployeeButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.employeeLabel);
            this.Controls.Add(this.listView_employees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(929, 544);
            this.Name = "ManageEmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ouatelse - Gestion des salariés";
            this.rightClickEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_employees;
        private System.Windows.Forms.ColumnHeader lastname;
        private System.Windows.Forms.ColumnHeader firstname;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.ColumnHeader role;
        private System.Windows.Forms.ColumnHeader store;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button ModifyEmployeeButton;
        private System.Windows.Forms.Button NewEmployeeButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label employeesNumber;
        private System.Windows.Forms.ContextMenuStrip rightClickEmployees;
        private System.Windows.Forms.ToolStripMenuItem editThisEmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisEmployee;
        private System.Windows.Forms.ColumnHeader reference;
        private System.Windows.Forms.Label label1;
    }
}
