namespace MotornaVozila.Forme
{
    partial class FormaSalon
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
            this.lblImeSalona = new System.Windows.Forms.Label();
            this.lblSef = new System.Windows.Forms.Label();
            this.btnIzlozenaVozila = new System.Windows.Forms.Button();
            this.btnProdataVozila = new System.Windows.Forms.Button();
            this.listSviZaposleniSalona = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtImeSalona = new System.Windows.Forms.TextBox();
            this.txtImeSefaSalona = new System.Windows.Forms.TextBox();
            this.lblSviZaposleniSalon = new System.Windows.Forms.Label();
            this.lblLokacijaSalona = new System.Windows.Forms.Label();
            this.txtLokacijaSalona = new System.Windows.Forms.TextBox();
            this.btnIzmenaSalona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImeSalona
            // 
            this.lblImeSalona.AutoSize = true;
            this.lblImeSalona.Location = new System.Drawing.Point(546, 38);
            this.lblImeSalona.Name = "lblImeSalona";
            this.lblImeSalona.Size = new System.Drawing.Size(61, 13);
            this.lblImeSalona.TabIndex = 0;
            this.lblImeSalona.Text = "Ime salona:";
            // 
            // lblSef
            // 
            this.lblSef.AutoSize = true;
            this.lblSef.Location = new System.Drawing.Point(546, 123);
            this.lblSef.Name = "lblSef";
            this.lblSef.Size = new System.Drawing.Size(91, 13);
            this.lblSef.TabIndex = 1;
            this.lblSef.Text = "Ime i prezime sefa";
            // 
            // btnIzlozenaVozila
            // 
            this.btnIzlozenaVozila.Location = new System.Drawing.Point(575, 255);
            this.btnIzlozenaVozila.Name = "btnIzlozenaVozila";
            this.btnIzlozenaVozila.Size = new System.Drawing.Size(192, 23);
            this.btnIzlozenaVozila.TabIndex = 2;
            this.btnIzlozenaVozila.Text = "Prikazi vozila izlozena u salonu";
            this.btnIzlozenaVozila.UseVisualStyleBackColor = true;
            this.btnIzlozenaVozila.Click += new System.EventHandler(this.btnIzlozenaVozila_Click);
            // 
            // btnProdataVozila
            // 
            this.btnProdataVozila.Location = new System.Drawing.Point(575, 303);
            this.btnProdataVozila.Name = "btnProdataVozila";
            this.btnProdataVozila.Size = new System.Drawing.Size(192, 23);
            this.btnProdataVozila.TabIndex = 3;
            this.btnProdataVozila.Text = "Prikazi prodaje izvrsene u salonu";
            this.btnProdataVozila.UseVisualStyleBackColor = true;
            this.btnProdataVozila.Click += new System.EventHandler(this.btnProdataVozila_Click);
            // 
            // listSviZaposleniSalona
            // 
            this.listSviZaposleniSalona.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listSviZaposleniSalona.HideSelection = false;
            this.listSviZaposleniSalona.Location = new System.Drawing.Point(12, 35);
            this.listSviZaposleniSalona.Name = "listSviZaposleniSalona";
            this.listSviZaposleniSalona.Size = new System.Drawing.Size(528, 413);
            this.listSviZaposleniSalona.TabIndex = 4;
            this.listSviZaposleniSalona.UseCompatibleStateImageBehavior = false;
            this.listSviZaposleniSalona.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Maticni broj";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Struka";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Plata";
            this.columnHeader5.Width = 106;
            // 
            // txtImeSalona
            // 
            this.txtImeSalona.Location = new System.Drawing.Point(643, 35);
            this.txtImeSalona.Name = "txtImeSalona";
            this.txtImeSalona.ReadOnly = true;
            this.txtImeSalona.Size = new System.Drawing.Size(139, 20);
            this.txtImeSalona.TabIndex = 5;
            // 
            // txtImeSefaSalona
            // 
            this.txtImeSefaSalona.Location = new System.Drawing.Point(643, 120);
            this.txtImeSefaSalona.Name = "txtImeSefaSalona";
            this.txtImeSefaSalona.ReadOnly = true;
            this.txtImeSefaSalona.Size = new System.Drawing.Size(139, 20);
            this.txtImeSefaSalona.TabIndex = 6;
            // 
            // lblSviZaposleniSalon
            // 
            this.lblSviZaposleniSalon.AutoSize = true;
            this.lblSviZaposleniSalon.Location = new System.Drawing.Point(12, 19);
            this.lblSviZaposleniSalon.Name = "lblSviZaposleniSalon";
            this.lblSviZaposleniSalon.Size = new System.Drawing.Size(147, 13);
            this.lblSviZaposleniSalon.TabIndex = 7;
            this.lblSviZaposleniSalon.Text = "Lista svih zaposlenih u salonu";
            // 
            // lblLokacijaSalona
            // 
            this.lblLokacijaSalona.AutoSize = true;
            this.lblLokacijaSalona.Location = new System.Drawing.Point(546, 71);
            this.lblLokacijaSalona.Name = "lblLokacijaSalona";
            this.lblLokacijaSalona.Size = new System.Drawing.Size(50, 13);
            this.lblLokacijaSalona.TabIndex = 8;
            this.lblLokacijaSalona.Text = "Lokacija:";
            // 
            // txtLokacijaSalona
            // 
            this.txtLokacijaSalona.Location = new System.Drawing.Point(643, 68);
            this.txtLokacijaSalona.Name = "txtLokacijaSalona";
            this.txtLokacijaSalona.ReadOnly = true;
            this.txtLokacijaSalona.Size = new System.Drawing.Size(139, 20);
            this.txtLokacijaSalona.TabIndex = 9;
            // 
            // btnIzmenaSalona
            // 
            this.btnIzmenaSalona.Location = new System.Drawing.Point(578, 348);
            this.btnIzmenaSalona.Name = "btnIzmenaSalona";
            this.btnIzmenaSalona.Size = new System.Drawing.Size(188, 27);
            this.btnIzmenaSalona.TabIndex = 10;
            this.btnIzmenaSalona.Text = "Izmeni salon";
            this.btnIzmenaSalona.UseVisualStyleBackColor = true;
            this.btnIzmenaSalona.Click += new System.EventHandler(this.btnIzmenaSalona_Click);
            // 
            // FormaSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 460);
            this.Controls.Add(this.btnIzmenaSalona);
            this.Controls.Add(this.txtLokacijaSalona);
            this.Controls.Add(this.lblLokacijaSalona);
            this.Controls.Add(this.lblSviZaposleniSalon);
            this.Controls.Add(this.txtImeSefaSalona);
            this.Controls.Add(this.txtImeSalona);
            this.Controls.Add(this.listSviZaposleniSalona);
            this.Controls.Add(this.btnProdataVozila);
            this.Controls.Add(this.btnIzlozenaVozila);
            this.Controls.Add(this.lblSef);
            this.Controls.Add(this.lblImeSalona);
            this.MaximumSize = new System.Drawing.Size(822, 499);
            this.MinimumSize = new System.Drawing.Size(822, 499);
            this.Name = "FormaSalon";
            this.Text = "FormaSalon";
            this.Load += new System.EventHandler(this.FormaSalon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeSalona;
        private System.Windows.Forms.Label lblSef;
        private System.Windows.Forms.Button btnIzlozenaVozila;
        private System.Windows.Forms.Button btnProdataVozila;
        private System.Windows.Forms.ListView listSviZaposleniSalona;
        private System.Windows.Forms.TextBox txtImeSalona;
        private System.Windows.Forms.TextBox txtImeSefaSalona;
        private System.Windows.Forms.Label lblSviZaposleniSalon;
        private System.Windows.Forms.Label lblLokacijaSalona;
        private System.Windows.Forms.TextBox txtLokacijaSalona;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnIzmenaSalona;
    }
}