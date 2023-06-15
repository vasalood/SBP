namespace MotornaVozila.Forme
{
    partial class SviZaposleniForma
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
            this.listSviZaposleni = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSviZaposleni = new System.Windows.Forms.Label();
            this.lblBrojZaposlenih = new System.Windows.Forms.Label();
            this.txtBrojZaposlenih = new System.Windows.Forms.TextBox();
            this.btnIzmeniZaposlenog = new System.Windows.Forms.Button();
            this.btnDodajPodr = new System.Windows.Forms.Button();
            this.btnDodajNadredjenog = new System.Windows.Forms.Button();
            this.btnObrisiZaposlenog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSviZaposleni
            // 
            this.listSviZaposleni.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listSviZaposleni.FullRowSelect = true;
            this.listSviZaposleni.HideSelection = false;
            this.listSviZaposleni.Location = new System.Drawing.Point(12, 29);
            this.listSviZaposleni.Name = "listSviZaposleni";
            this.listSviZaposleni.Size = new System.Drawing.Size(691, 491);
            this.listSviZaposleni.TabIndex = 0;
            this.listSviZaposleni.UseCompatibleStateImageBehavior = false;
            this.listSviZaposleni.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Maticni broj";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum rodjenja";
            this.columnHeader4.Width = 109;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum zaposlenja";
            this.columnHeader5.Width = 128;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Plata";
            this.columnHeader6.Width = 89;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sef";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Rukovodilac";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Direktor";
            // 
            // lblSviZaposleni
            // 
            this.lblSviZaposleni.AutoSize = true;
            this.lblSviZaposleni.Location = new System.Drawing.Point(12, 9);
            this.lblSviZaposleni.Name = "lblSviZaposleni";
            this.lblSviZaposleni.Size = new System.Drawing.Size(103, 13);
            this.lblSviZaposleni.TabIndex = 1;
            this.lblSviZaposleni.Text = "Svi zaposleni radnici";
            // 
            // lblBrojZaposlenih
            // 
            this.lblBrojZaposlenih.AutoSize = true;
            this.lblBrojZaposlenih.Location = new System.Drawing.Point(738, 420);
            this.lblBrojZaposlenih.Name = "lblBrojZaposlenih";
            this.lblBrojZaposlenih.Size = new System.Drawing.Size(156, 13);
            this.lblBrojZaposlenih.TabIndex = 2;
            this.lblBrojZaposlenih.Text = "Ukupan broj zaposlenih radnika";
            // 
            // txtBrojZaposlenih
            // 
            this.txtBrojZaposlenih.Location = new System.Drawing.Point(741, 449);
            this.txtBrojZaposlenih.Name = "txtBrojZaposlenih";
            this.txtBrojZaposlenih.ReadOnly = true;
            this.txtBrojZaposlenih.Size = new System.Drawing.Size(153, 20);
            this.txtBrojZaposlenih.TabIndex = 3;
            // 
            // btnIzmeniZaposlenog
            // 
            this.btnIzmeniZaposlenog.Location = new System.Drawing.Point(730, 324);
            this.btnIzmeniZaposlenog.Name = "btnIzmeniZaposlenog";
            this.btnIzmeniZaposlenog.Size = new System.Drawing.Size(163, 37);
            this.btnIzmeniZaposlenog.TabIndex = 4;
            this.btnIzmeniZaposlenog.Text = "Izmeni zaposlenog";
            this.btnIzmeniZaposlenog.UseVisualStyleBackColor = true;
            this.btnIzmeniZaposlenog.Click += new System.EventHandler(this.btnIzmeniZaposlenog_Click);
            // 
            // btnDodajPodr
            // 
            this.btnDodajPodr.Location = new System.Drawing.Point(730, 241);
            this.btnDodajPodr.Name = "btnDodajPodr";
            this.btnDodajPodr.Size = new System.Drawing.Size(159, 52);
            this.btnDodajPodr.TabIndex = 7;
            this.btnDodajPodr.Text = "Dodaj podredjenog";
            this.btnDodajPodr.UseVisualStyleBackColor = true;
            this.btnDodajPodr.Click += new System.EventHandler(this.btnDodajPodr_Click);
            // 
            // btnDodajNadredjenog
            // 
            this.btnDodajNadredjenog.Location = new System.Drawing.Point(730, 169);
            this.btnDodajNadredjenog.Name = "btnDodajNadredjenog";
            this.btnDodajNadredjenog.Size = new System.Drawing.Size(164, 42);
            this.btnDodajNadredjenog.TabIndex = 8;
            this.btnDodajNadredjenog.Text = "Dodaj Nadredjenog";
            this.btnDodajNadredjenog.UseVisualStyleBackColor = true;
            this.btnDodajNadredjenog.Click += new System.EventHandler(this.btnDodajNadredjenog_Click);
            // 
            // btnObrisiZaposlenog
            // 
            this.btnObrisiZaposlenog.Location = new System.Drawing.Point(730, 100);
            this.btnObrisiZaposlenog.Name = "btnObrisiZaposlenog";
            this.btnObrisiZaposlenog.Size = new System.Drawing.Size(164, 42);
            this.btnObrisiZaposlenog.TabIndex = 9;
            this.btnObrisiZaposlenog.Text = "Obrisi zaposlenog";
            this.btnObrisiZaposlenog.UseVisualStyleBackColor = true;
            this.btnObrisiZaposlenog.Click += new System.EventHandler(this.btnObrisiZaposlenog_Click);
            // 
            // SviZaposleniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 531);
            this.Controls.Add(this.btnObrisiZaposlenog);
            this.Controls.Add(this.btnDodajNadredjenog);
            this.Controls.Add(this.btnDodajPodr);
            this.Controls.Add(this.btnIzmeniZaposlenog);
            this.Controls.Add(this.txtBrojZaposlenih);
            this.Controls.Add(this.lblBrojZaposlenih);
            this.Controls.Add(this.lblSviZaposleni);
            this.Controls.Add(this.listSviZaposleni);
            this.MaximumSize = new System.Drawing.Size(931, 570);
            this.MinimumSize = new System.Drawing.Size(931, 570);
            this.Name = "SviZaposleniForma";
            this.Text = "SviZaposleniForma";
            this.Load += new System.EventHandler(this.SviZaposleniForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listSviZaposleni;
        private System.Windows.Forms.Label lblSviZaposleni;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblBrojZaposlenih;
        private System.Windows.Forms.TextBox txtBrojZaposlenih;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnIzmeniZaposlenog;
        private System.Windows.Forms.Button btnDodajPodr;
        private System.Windows.Forms.Button btnDodajNadredjenog;
        private System.Windows.Forms.Button btnObrisiZaposlenog;
    }
}