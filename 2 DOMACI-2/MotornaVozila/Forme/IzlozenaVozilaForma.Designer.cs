namespace MotornaVozila.Forme
{
    partial class IzlozenaVozilaForma
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
            this.listIzlozenaVozila = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listIzlozenaVozila
            // 
            this.listIzlozenaVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listIzlozenaVozila.HideSelection = false;
            this.listIzlozenaVozila.Location = new System.Drawing.Point(12, 12);
            this.listIzlozenaVozila.Name = "listIzlozenaVozila";
            this.listIzlozenaVozila.Size = new System.Drawing.Size(602, 279);
            this.listIzlozenaVozila.TabIndex = 2;
            this.listIzlozenaVozila.UseCompatibleStateImageBehavior = false;
            this.listIzlozenaVozila.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Broj motora";
            this.columnHeader5.Width = 134;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Broj sasije";
            this.columnHeader6.Width = 128;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Model";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kubikaza";
            this.columnHeader2.Width = 63;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip vozila";
            this.columnHeader3.Width = 122;
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(420, 304);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(193, 28);
            this.btnDodajVozilo.TabIndex = 3;
            this.btnDodajVozilo.Text = "Dodaj vozilo";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // IzlozenaVozilaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 349);
            this.Controls.Add(this.btnDodajVozilo);
            this.Controls.Add(this.listIzlozenaVozila);
            this.MaximumSize = new System.Drawing.Size(642, 388);
            this.MinimumSize = new System.Drawing.Size(642, 388);
            this.Name = "IzlozenaVozilaForma";
            this.Text = "IzlozenaVozilaForma";
            this.Load += new System.EventHandler(this.IzlozenaVozilaForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listIzlozenaVozila;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDodajVozilo;
    }
}