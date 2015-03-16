namespace Ouatelse.Forms
{
    partial class SelectHolidayForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.validateButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.holidaysListView = new System.Windows.Forms.DataGridView();
            this.employeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidaysListView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Location = new System.Drawing.Point(451, 24);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(89, 40);
            this.cancelButton.TabIndex = 121;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // validateButton
            // 
            this.validateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.validateButton.FlatAppearance.BorderSize = 0;
            this.validateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validateButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.validateButton.Location = new System.Drawing.Point(559, 24);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(89, 40);
            this.validateButton.TabIndex = 120;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = false;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.title.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(144, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(282, 40);
            this.title.TabIndex = 119;
            this.title.Text = "Sélection d\'un congé";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.Ouatelse_full_05;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 118;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(111, -2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(607, 90);
            this.label13.TabIndex = 122;
            // 
            // holidaysListView
            // 
            this.holidaysListView.AllowUserToAddRows = false;
            this.holidaysListView.AllowUserToDeleteRows = false;
            this.holidaysListView.AllowUserToResizeColumns = false;
            this.holidaysListView.AllowUserToResizeRows = false;
            this.holidaysListView.BackgroundColor = System.Drawing.Color.White;
            this.holidaysListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.holidaysListView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.holidaysListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holidaysListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeColumn,
            this.startingDateColumn,
            this.endingDateColumn});
            this.holidaysListView.GridColor = System.Drawing.Color.White;
            this.holidaysListView.Location = new System.Drawing.Point(114, 115);
            this.holidaysListView.MultiSelect = false;
            this.holidaysListView.Name = "holidaysListView";
            this.holidaysListView.ReadOnly = true;
            this.holidaysListView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.holidaysListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.holidaysListView.Size = new System.Drawing.Size(443, 131);
            this.holidaysListView.TabIndex = 123;
            // 
            // employeeColumn
            // 
            this.employeeColumn.HeaderText = "Salarié";
            this.employeeColumn.Name = "employeeColumn";
            this.employeeColumn.ReadOnly = true;
            this.employeeColumn.Width = 200;
            // 
            // startingDateColumn
            // 
            this.startingDateColumn.HeaderText = "Date de début";
            this.startingDateColumn.Name = "startingDateColumn";
            this.startingDateColumn.ReadOnly = true;
            // 
            // endingDateColumn
            // 
            this.endingDateColumn.HeaderText = "Date de fin";
            this.endingDateColumn.Name = "endingDateColumn";
            this.endingDateColumn.ReadOnly = true;
            // 
            // SelectHolidayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 289);
            this.Controls.Add(this.holidaysListView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectHolidayForm";
            this.Text = "Ouatelse - Sélection d\'un congé";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidaysListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView holidaysListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingDateColumn;

    }
}