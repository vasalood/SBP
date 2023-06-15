namespace MotornaVozila.Forme
{
    partial class NoviSalonForma
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.btnDodajSalon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(110, 27);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(110, 59);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(100, 20);
            this.txtLokacija.TabIndex = 1;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(45, 30);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(61, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime salona:";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Location = new System.Drawing.Point(20, 62);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(84, 13);
            this.lblLokacija.TabIndex = 3;
            this.lblLokacija.Text = "Lokacija salona:";
            // 
            // btnDodajSalon
            // 
            this.btnDodajSalon.Location = new System.Drawing.Point(90, 104);
            this.btnDodajSalon.Name = "btnDodajSalon";
            this.btnDodajSalon.Size = new System.Drawing.Size(75, 23);
            this.btnDodajSalon.TabIndex = 4;
            this.btnDodajSalon.Text = "Dodaj salon";
            this.btnDodajSalon.UseVisualStyleBackColor = true;
            this.btnDodajSalon.Click += new System.EventHandler(this.btnDodajSalon_Click);
            // 
            // NoviSalonForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 159);
            this.Controls.Add(this.btnDodajSalon);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtIme);
            this.MaximumSize = new System.Drawing.Size(287, 198);
            this.MinimumSize = new System.Drawing.Size(287, 198);
            this.Name = "NoviSalonForma";
            this.Text = "NoviSalonForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Button btnDodajSalon;
    }
}