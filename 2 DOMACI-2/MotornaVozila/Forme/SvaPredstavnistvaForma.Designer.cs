namespace MotornaVozila.Forme
{
    partial class SvaPredstavnistvaForma
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
            this.lblSvaPredstavnistva = new System.Windows.Forms.Label();
            this.listSvaPredstavnistva = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajPredstavnistvo = new System.Windows.Forms.Button();
            this.btnIzmeniPredstavnistvo = new System.Windows.Forms.Button();
            this.btnPrikaziSalon = new System.Windows.Forms.Button();
            this.btnPrikaziServis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajSalon = new System.Windows.Forms.Button();
            this.btnDodajServis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSvaPredstavnistva
            // 
            this.lblSvaPredstavnistva.AutoSize = true;
            this.lblSvaPredstavnistva.Location = new System.Drawing.Point(12, 9);
            this.lblSvaPredstavnistva.Name = "lblSvaPredstavnistva";
            this.lblSvaPredstavnistva.Size = new System.Drawing.Size(98, 13);
            this.lblSvaPredstavnistva.TabIndex = 3;
            this.lblSvaPredstavnistva.Text = "Sva predstavnistva";
            // 
            // listSvaPredstavnistva
            // 
            this.listSvaPredstavnistva.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listSvaPredstavnistva.FullRowSelect = true;
            this.listSvaPredstavnistva.HideSelection = false;
            this.listSvaPredstavnistva.Location = new System.Drawing.Point(15, 25);
            this.listSvaPredstavnistva.Name = "listSvaPredstavnistva";
            this.listSvaPredstavnistva.Size = new System.Drawing.Size(557, 424);
            this.listSvaPredstavnistva.TabIndex = 4;
            this.listSvaPredstavnistva.UseCompatibleStateImageBehavior = false;
            this.listSvaPredstavnistva.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grad";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adresa";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Direktor";
            this.columnHeader4.Width = 177;
            // 
            // btnDodajPredstavnistvo
            // 
            this.btnDodajPredstavnistvo.Location = new System.Drawing.Point(621, 34);
            this.btnDodajPredstavnistvo.Name = "btnDodajPredstavnistvo";
            this.btnDodajPredstavnistvo.Size = new System.Drawing.Size(170, 23);
            this.btnDodajPredstavnistvo.TabIndex = 5;
            this.btnDodajPredstavnistvo.Text = "Dodaj predstavnistvo";
            this.btnDodajPredstavnistvo.UseVisualStyleBackColor = true;
            this.btnDodajPredstavnistvo.Click += new System.EventHandler(this.btnDodajPredstavnistvo_Click);
            // 
            // btnIzmeniPredstavnistvo
            // 
            this.btnIzmeniPredstavnistvo.Location = new System.Drawing.Point(621, 63);
            this.btnIzmeniPredstavnistvo.Name = "btnIzmeniPredstavnistvo";
            this.btnIzmeniPredstavnistvo.Size = new System.Drawing.Size(170, 23);
            this.btnIzmeniPredstavnistvo.TabIndex = 6;
            this.btnIzmeniPredstavnistvo.Text = "Izmeni predstavnistvo";
            this.btnIzmeniPredstavnistvo.UseVisualStyleBackColor = true;
            this.btnIzmeniPredstavnistvo.Click += new System.EventHandler(this.btnIzmeniPredstavnistvo_Click);
            // 
            // btnPrikaziSalon
            // 
            this.btnPrikaziSalon.Location = new System.Drawing.Point(621, 232);
            this.btnPrikaziSalon.Name = "btnPrikaziSalon";
            this.btnPrikaziSalon.Size = new System.Drawing.Size(170, 23);
            this.btnPrikaziSalon.TabIndex = 7;
            this.btnPrikaziSalon.Text = "Prikazi salon";
            this.btnPrikaziSalon.UseVisualStyleBackColor = true;
            this.btnPrikaziSalon.Click += new System.EventHandler(this.btnPrikaziSalon_Click);
            // 
            // btnPrikaziServis
            // 
            this.btnPrikaziServis.Location = new System.Drawing.Point(621, 261);
            this.btnPrikaziServis.Name = "btnPrikaziServis";
            this.btnPrikaziServis.Size = new System.Drawing.Size(170, 23);
            this.btnPrikaziServis.TabIndex = 8;
            this.btnPrikaziServis.Text = "Prikazi servis";
            this.btnPrikaziServis.UseVisualStyleBackColor = true;
            this.btnPrikaziServis.Click += new System.EventHandler(this.btnPrikaziServis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(609, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Prikazace se salon ili servis odgovarajuceg \r\npredstavnistva koje ste selektovali" +
    "";
            // 
            // btnDodajSalon
            // 
            this.btnDodajSalon.Location = new System.Drawing.Point(621, 338);
            this.btnDodajSalon.Name = "btnDodajSalon";
            this.btnDodajSalon.Size = new System.Drawing.Size(170, 25);
            this.btnDodajSalon.TabIndex = 10;
            this.btnDodajSalon.Text = "Dodaj salon";
            this.btnDodajSalon.UseVisualStyleBackColor = true;
            this.btnDodajSalon.Click += new System.EventHandler(this.btnDodajSalon_Click);
            // 
            // btnDodajServis
            // 
            this.btnDodajServis.Location = new System.Drawing.Point(621, 369);
            this.btnDodajServis.Name = "btnDodajServis";
            this.btnDodajServis.Size = new System.Drawing.Size(170, 25);
            this.btnDodajServis.TabIndex = 11;
            this.btnDodajServis.Text = "Dodaj servis";
            this.btnDodajServis.UseVisualStyleBackColor = true;
            this.btnDodajServis.Click += new System.EventHandler(this.btnDodajServis_Click);
            // 
            // SvaPredstavnistvaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 459);
            this.Controls.Add(this.btnDodajServis);
            this.Controls.Add(this.btnDodajSalon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikaziServis);
            this.Controls.Add(this.btnPrikaziSalon);
            this.Controls.Add(this.btnIzmeniPredstavnistvo);
            this.Controls.Add(this.btnDodajPredstavnistvo);
            this.Controls.Add(this.listSvaPredstavnistva);
            this.Controls.Add(this.lblSvaPredstavnistva);
            this.MaximumSize = new System.Drawing.Size(849, 498);
            this.MinimumSize = new System.Drawing.Size(849, 498);
            this.Name = "SvaPredstavnistvaForma";
            this.Text = "SvaPredstavnistvaForma";
            this.Load += new System.EventHandler(this.SvaPredstavnistvaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSvaPredstavnistva;
        private System.Windows.Forms.ListView listSvaPredstavnistva;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnDodajPredstavnistvo;
        private System.Windows.Forms.Button btnIzmeniPredstavnistvo;
        private System.Windows.Forms.Button btnPrikaziSalon;
        private System.Windows.Forms.Button btnPrikaziServis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajSalon;
        private System.Windows.Forms.Button btnDodajServis;
    }
}