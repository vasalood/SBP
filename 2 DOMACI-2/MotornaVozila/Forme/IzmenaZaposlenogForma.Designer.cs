namespace MotornaVozila.Forme
{
    partial class IzmenaZaposlenogForma
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
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtPlata = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblPlata = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(170, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(170, 38);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 1;
            // 
            // txtPlata
            // 
            this.txtPlata.Location = new System.Drawing.Point(170, 64);
            this.txtPlata.Name = "txtPlata";
            this.txtPlata.Size = new System.Drawing.Size(100, 20);
            this.txtPlata.TabIndex = 2;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(67, 15);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(67, 41);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(47, 13);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblPlata
            // 
            this.lblPlata.AutoSize = true;
            this.lblPlata.Location = new System.Drawing.Point(67, 67);
            this.lblPlata.Name = "lblPlata";
            this.lblPlata.Size = new System.Drawing.Size(34, 13);
            this.lblPlata.TabIndex = 5;
            this.lblPlata.Text = "Plata:";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(170, 91);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // IzmenaZaposlenogForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 126);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.lblPlata);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtPlata);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.MaximumSize = new System.Drawing.Size(298, 165);
            this.MinimumSize = new System.Drawing.Size(298, 165);
            this.Name = "IzmenaZaposlenogForma";
            this.Text = "IzmenaZaposlenogForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtPlata;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblPlata;
        private System.Windows.Forms.Button btnIzmeni;
    }
}