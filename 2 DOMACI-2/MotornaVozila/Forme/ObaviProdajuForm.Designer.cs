namespace MotornaVozila.Forme
{
    partial class ObaviProdajuForm
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
            this.dtpProdaja = new System.Windows.Forms.DateTimePicker();
            this.lblDatumProdaje = new System.Windows.Forms.Label();
            this.listProdavci = new System.Windows.Forms.ListView();
            this.lblProdavci = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.lblMbr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listVozila = new System.Windows.Forms.ListView();
            this.lblVozila = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.btnObaviProdaju = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dtpProdaja
            // 
            this.dtpProdaja.Location = new System.Drawing.Point(126, 4);
            this.dtpProdaja.Name = "dtpProdaja";
            this.dtpProdaja.Size = new System.Drawing.Size(200, 20);
            this.dtpProdaja.TabIndex = 0;
            // 
            // lblDatumProdaje
            // 
            this.lblDatumProdaje.AutoSize = true;
            this.lblDatumProdaje.Location = new System.Drawing.Point(44, 10);
            this.lblDatumProdaje.Name = "lblDatumProdaje";
            this.lblDatumProdaje.Size = new System.Drawing.Size(76, 13);
            this.lblDatumProdaje.TabIndex = 1;
            this.lblDatumProdaje.Text = "Datum prodaje";
            // 
            // listProdavci
            // 
            this.listProdavci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listProdavci.FullRowSelect = true;
            this.listProdavci.HideSelection = false;
            this.listProdavci.Location = new System.Drawing.Point(47, 62);
            this.listProdavci.Name = "listProdavci";
            this.listProdavci.Size = new System.Drawing.Size(316, 187);
            this.listProdavci.TabIndex = 2;
            this.listProdavci.UseCompatibleStateImageBehavior = false;
            this.listProdavci.View = System.Windows.Forms.View.Details;
            // 
            // lblProdavci
            // 
            this.lblProdavci.AutoSize = true;
            this.lblProdavci.Location = new System.Drawing.Point(44, 46);
            this.lblProdavci.Name = "lblProdavci";
            this.lblProdavci.Size = new System.Drawing.Size(83, 13);
            this.lblProdavci.TabIndex = 3;
            this.lblProdavci.Text = "Lista prodavaca";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(177, 304);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(177, 330);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 5;
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(177, 275);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(100, 20);
            this.txtMat.TabIndex = 6;
            // 
            // lblMbr
            // 
            this.lblMbr.AutoSize = true;
            this.lblMbr.Location = new System.Drawing.Point(77, 278);
            this.lblMbr.Name = "lblMbr";
            this.lblMbr.Size = new System.Drawing.Size(94, 13);
            this.lblMbr.TabIndex = 7;
            this.lblMbr.Text = "Maticni broj kupca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ime kupca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prezime kupca";
            // 
            // listVozila
            // 
            this.listVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listVozila.FullRowSelect = true;
            this.listVozila.HideSelection = false;
            this.listVozila.Location = new System.Drawing.Point(431, 62);
            this.listVozila.Name = "listVozila";
            this.listVozila.Size = new System.Drawing.Size(338, 187);
            this.listVozila.TabIndex = 10;
            this.listVozila.UseCompatibleStateImageBehavior = false;
            this.listVozila.View = System.Windows.Forms.View.Details;
            // 
            // lblVozila
            // 
            this.lblVozila.AutoSize = true;
            this.lblVozila.Location = new System.Drawing.Point(428, 46);
            this.lblVozila.Name = "lblVozila";
            this.lblVozila.Size = new System.Drawing.Size(119, 13);
            this.lblVozila.TabIndex = 11;
            this.lblVozila.Text = "Vozila izlozena u salonu";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(584, 307);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 12;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(543, 311);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(32, 13);
            this.lblCena.TabIndex = 13;
            this.lblCena.Text = "Cena";
            // 
            // btnObaviProdaju
            // 
            this.btnObaviProdaju.Location = new System.Drawing.Point(558, 357);
            this.btnObaviProdaju.Name = "btnObaviProdaju";
            this.btnObaviProdaju.Size = new System.Drawing.Size(126, 32);
            this.btnObaviProdaju.TabIndex = 14;
            this.btnObaviProdaju.Text = "Obavi prodaju";
            this.btnObaviProdaju.UseVisualStyleBackColor = true;
            this.btnObaviProdaju.Click += new System.EventHandler(this.btnObaviProdaju_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Maticni broj";
            this.columnHeader1.Width = 119;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kubikaza";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Boja";
            this.columnHeader6.Width = 143;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            // 
            // ObaviProdajuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 418);
            this.Controls.Add(this.btnObaviProdaju);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.lblVozila);
            this.Controls.Add(this.listVozila);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMbr);
            this.Controls.Add(this.txtMat);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblProdavci);
            this.Controls.Add(this.listProdavci);
            this.Controls.Add(this.lblDatumProdaje);
            this.Controls.Add(this.dtpProdaja);
            this.MaximumSize = new System.Drawing.Size(828, 457);
            this.MinimumSize = new System.Drawing.Size(828, 457);
            this.Name = "ObaviProdajuForm";
            this.Text = "ObaviProdajuForm";
            this.Load += new System.EventHandler(this.ObaviProdajuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpProdaja;
        private System.Windows.Forms.Label lblDatumProdaje;
        private System.Windows.Forms.ListView listProdavci;
        private System.Windows.Forms.Label lblProdavci;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.Label lblMbr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listVozila;
        private System.Windows.Forms.Label lblVozila;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Button btnObaviProdaju;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}