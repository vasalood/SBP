namespace MotornaVozila.Forme
{
    partial class IzmenaSalonaForma
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
            this.listSefovi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(176, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(139, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(176, 38);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(139, 20);
            this.txtLokacija.TabIndex = 1;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(97, 15);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(61, 13);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime salona:";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Location = new System.Drawing.Point(77, 38);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(84, 13);
            this.lblLokacija.TabIndex = 3;
            this.lblLokacija.Text = "Lokacija salona:";
            // 
            // listSefovi
            // 
            this.listSefovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listSefovi.FullRowSelect = true;
            this.listSefovi.HideSelection = false;
            this.listSefovi.Location = new System.Drawing.Point(80, 64);
            this.listSefovi.Name = "listSefovi";
            this.listSefovi.Size = new System.Drawing.Size(312, 217);
            this.listSefovi.TabIndex = 4;
            this.listSefovi.UseCompatibleStateImageBehavior = false;
            this.listSefovi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Maticni broj";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ime";
            this.columnHeader5.Width = 121;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Prezime";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(178, 290);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(119, 27);
            this.btnIzmeni.TabIndex = 5;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // IzmenaSalonaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 326);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.listSefovi);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtIme);
            this.MaximumSize = new System.Drawing.Size(456, 365);
            this.MinimumSize = new System.Drawing.Size(456, 365);
            this.Name = "IzmenaSalonaForma";
            this.Text = "IzmenaSalonaForma";
            this.Load += new System.EventHandler(this.IzmenaSalonaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.ListView listSefovi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}