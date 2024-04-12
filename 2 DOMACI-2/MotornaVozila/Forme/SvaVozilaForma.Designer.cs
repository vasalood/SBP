namespace MotornaVozila.Forme
{
    partial class SvaVozilaForma
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
            this.listSvaVozila = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSvaVozila = new System.Windows.Forms.Label();
            this.lblBrojZaposlenih = new System.Windows.Forms.Label();
            this.txtBrojVozila = new System.Windows.Forms.TextBox();
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSvaVozila
            // 
            this.listSvaVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listSvaVozila.FullRowSelect = true;
            this.listSvaVozila.HideSelection = false;
            this.listSvaVozila.Location = new System.Drawing.Point(12, 25);
            this.listSvaVozila.Name = "listSvaVozila";
            this.listSvaVozila.Size = new System.Drawing.Size(752, 448);
            this.listSvaVozila.TabIndex = 1;
            this.listSvaVozila.UseCompatibleStateImageBehavior = false;
            this.listSvaVozila.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Broj sasije";
            this.columnHeader10.Width = 162;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Broj motora";
            this.columnHeader11.Width = 136;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Model";
            this.columnHeader12.Width = 106;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Kubikaza";
            this.columnHeader13.Width = 118;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tip vozila";
            this.columnHeader14.Width = 119;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Boja";
            this.columnHeader15.Width = 106;
            // 
            // lblSvaVozila
            // 
            this.lblSvaVozila.AutoSize = true;
            this.lblSvaVozila.Location = new System.Drawing.Point(26, 9);
            this.lblSvaVozila.Name = "lblSvaVozila";
            this.lblSvaVozila.Size = new System.Drawing.Size(56, 13);
            this.lblSvaVozila.TabIndex = 2;
            this.lblSvaVozila.Text = "Sva vozila";
            // 
            // lblBrojZaposlenih
            // 
            this.lblBrojZaposlenih.AutoSize = true;
            this.lblBrojZaposlenih.Location = new System.Drawing.Point(783, 437);
            this.lblBrojZaposlenih.Name = "lblBrojZaposlenih";
            this.lblBrojZaposlenih.Size = new System.Drawing.Size(95, 13);
            this.lblBrojZaposlenih.TabIndex = 3;
            this.lblBrojZaposlenih.Text = "Ukupan broj vozila";
            // 
            // txtBrojVozila
            // 
            this.txtBrojVozila.Location = new System.Drawing.Point(786, 453);
            this.txtBrojVozila.Name = "txtBrojVozila";
            this.txtBrojVozila.ReadOnly = true;
            this.txtBrojVozila.Size = new System.Drawing.Size(153, 20);
            this.txtBrojVozila.TabIndex = 4;
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(791, 372);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(148, 34);
            this.btnObrisiVozilo.TabIndex = 5;
            this.btnObrisiVozilo.Text = "Obrisi vozilo";
            this.btnObrisiVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // SvaVozilaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 523);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.txtBrojVozila);
            this.Controls.Add(this.lblBrojZaposlenih);
            this.Controls.Add(this.lblSvaVozila);
            this.Controls.Add(this.listSvaVozila);
            this.MaximumSize = new System.Drawing.Size(967, 562);
            this.MinimumSize = new System.Drawing.Size(967, 562);
            this.Name = "SvaVozilaForma";
            this.Text = "SvaVozilaForma";
            this.Load += new System.EventHandler(this.SvaVozilaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listSvaVozila;
        private System.Windows.Forms.Label lblSvaVozila;
        private System.Windows.Forms.Label lblBrojZaposlenih;
        private System.Windows.Forms.TextBox txtBrojVozila;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button btnObrisiVozilo;
    }
}