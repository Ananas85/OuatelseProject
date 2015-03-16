namespace Ouatelse.Forms
{
    partial class NewHolidaysForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.startingDate = new System.Windows.Forms.Label();
            this.endingDate = new System.Windows.Forms.Label();
            this.nbDay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.amplitude = new System.Windows.Forms.Label();
            this.rest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.cancelButton.TabIndex = 102;
            this.cancelButton.Text = "Annuler";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // validateButton
            // 
            this.validateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.validateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.validateButton.FlatAppearance.BorderSize = 0;
            this.validateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validateButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.validateButton.Location = new System.Drawing.Point(559, 24);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(89, 40);
            this.validateButton.TabIndex = 101;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = false;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.title.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(132, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(218, 40);
            this.title.TabIndex = 100;
            this.title.Text = "Nouveau congé";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Ouatelse.Properties.Resources.Ouatelse_full_05;
            this.pictureBox1.Location = new System.Drawing.Point(-8, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 99;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(111, -2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(607, 90);
            this.label13.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 104;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 105;
            this.label3.Text = "Durée du congé :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Nombre de jours ouvrés concernés : ";
            // 
            // startingDate
            // 
            this.startingDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingDate.ForeColor = System.Drawing.Color.LimeGreen;
            this.startingDate.Location = new System.Drawing.Point(95, 124);
            this.startingDate.Name = "startingDate";
            this.startingDate.Size = new System.Drawing.Size(235, 32);
            this.startingDate.TabIndex = 109;
            this.startingDate.Text = "-";
            this.startingDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endingDate
            // 
            this.endingDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endingDate.ForeColor = System.Drawing.Color.Firebrick;
            this.endingDate.Location = new System.Drawing.Point(388, 124);
            this.endingDate.Name = "endingDate";
            this.endingDate.Size = new System.Drawing.Size(235, 32);
            this.endingDate.TabIndex = 110;
            this.endingDate.Text = "-";
            this.endingDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nbDay
            // 
            this.nbDay.AutoSize = true;
            this.nbDay.Location = new System.Drawing.Point(369, 188);
            this.nbDay.Name = "nbDay";
            this.nbDay.Size = new System.Drawing.Size(10, 13);
            this.nbDay.TabIndex = 111;
            this.nbDay.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 112;
            this.label7.Text = "Amplitude ( en jours ) : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(200, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Nombre de jours restants après :";
            // 
            // amplitude
            // 
            this.amplitude.AutoSize = true;
            this.amplitude.Location = new System.Drawing.Point(369, 165);
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(10, 13);
            this.amplitude.TabIndex = 114;
            this.amplitude.Text = "-";
            // 
            // rest
            // 
            this.rest.AutoSize = true;
            this.rest.Location = new System.Drawing.Point(369, 211);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(10, 13);
            this.rest.TabIndex = 115;
            this.rest.Text = "-";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Wingdings", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(336, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 32);
            this.label4.TabIndex = 109;
            this.label4.Text = "►";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(142, 131);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(200, 20);
            this.start.TabIndex = 116;
            this.start.ValueChanged += new System.EventHandler(this.start_ValueChanged);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(372, 131);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(200, 20);
            this.end.TabIndex = 117;
            this.end.ValueChanged += new System.EventHandler(this.end_ValueChanged);
            // 
            // NewHolidaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 235);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.amplitude);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nbDay);
            this.Controls.Add(this.endingDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startingDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewHolidaysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ouatelse - Demande de congé";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label startingDate;
        private System.Windows.Forms.Label endingDate;
        private System.Windows.Forms.Label nbDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label amplitude;
        private System.Windows.Forms.Label rest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.DateTimePicker end;
    }
}