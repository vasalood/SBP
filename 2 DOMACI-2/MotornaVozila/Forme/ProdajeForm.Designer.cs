namespace MotornaVozila.Forme
{
    partial class ProdajeForm
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
            this.listaProdaja = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiProdaju = new System.Windows.Forms.Button();
            this.btnProdaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaProdaja
            // 
            this.listaProdaja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listaProdaja.FullRowSelect = true;
            this.listaProdaja.HideSelection = false;
            this.listaProdaja.Location = new System.Drawing.Point(10, 12);
            this.listaProdaja.Name = "listaProdaja";
            this.listaProdaja.Size = new System.Drawing.Size(768, 391);
            this.listaProdaja.TabIndex = 0;
            this.listaProdaja.UseCompatibleStateImageBehavior = false;
            this.listaProdaja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Datum kupovine";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model vozila";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cena";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kupac";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lice";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Prodavac";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id prodaje";
            // 
            // btnObrisiProdaju
            // 
            this.btnObrisiProdaju.Location = new System.Drawing.Point(784, 304);
            this.btnObrisiProdaju.Name = "btnObrisiProdaju";
            this.btnObrisiProdaju.Size = new System.Drawing.Size(140, 59);
            this.btnObrisiProdaju.TabIndex = 1;
            this.btnObrisiProdaju.Text = "Obrisi prodaju";
            this.btnObrisiProdaju.UseVisualStyleBackColor = true;
            this.btnObrisiProdaju.Click += new System.EventHandler(this.btnObrisiProdaju_Click);
            // 
            // btnProdaja
            // 
            this.btnProdaja.Location = new System.Drawing.Point(786, 228);
            this.btnProdaja.Name = "btnProdaja";
            this.btnProdaja.Size = new System.Drawing.Size(137, 37);
            this.btnProdaja.TabIndex = 2;
            this.btnProdaja.Text = "Obavi prodaju";
            this.btnProdaja.UseVisualStyleBackColor = true;
            this.btnProdaja.Click += new System.EventHandler(this.btnProdaja_Click);
            // 
            // ProdajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 416);
            this.Controls.Add(this.btnProdaja);
            this.Controls.Add(this.btnObrisiProdaju);
            this.Controls.Add(this.listaProdaja);
            this.MaximumSize = new System.Drawing.Size(980, 455);
            this.MinimumSize = new System.Drawing.Size(980, 455);
            this.Name = "ProdajeForm";
            this.Text = "ProdajeForm";
            this.Load += new System.EventHandler(this.ProdajeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaProdaja;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnObrisiProdaju;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnProdaja;
    }
}