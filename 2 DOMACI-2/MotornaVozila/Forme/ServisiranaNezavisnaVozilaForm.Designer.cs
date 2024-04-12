namespace MotornaVozila.Forme
{
    partial class ServisiranaNezavisnaVozilaForm
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
            this.listNezavisnaVozila = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiNezavisnoVozilo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listNezavisnaVozila
            // 
            this.listNezavisnaVozila.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listNezavisnaVozila.FullRowSelect = true;
            this.listNezavisnaVozila.HideSelection = false;
            this.listNezavisnaVozila.Location = new System.Drawing.Point(12, 12);
            this.listNezavisnaVozila.Name = "listNezavisnaVozila";
            this.listNezavisnaVozila.Size = new System.Drawing.Size(601, 293);
            this.listNezavisnaVozila.TabIndex = 1;
            this.listNezavisnaVozila.UseCompatibleStateImageBehavior = false;
            this.listNezavisnaVozila.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ime kupca";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prezime kupca";
            this.columnHeader2.Width = 144;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Broj telefona";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            this.columnHeader4.Width = 92;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vin";
            // 
            // btnObrisiNezavisnoVozilo
            // 
            this.btnObrisiNezavisnoVozilo.Location = new System.Drawing.Point(645, 181);
            this.btnObrisiNezavisnoVozilo.Name = "btnObrisiNezavisnoVozilo";
            this.btnObrisiNezavisnoVozilo.Size = new System.Drawing.Size(104, 61);
            this.btnObrisiNezavisnoVozilo.TabIndex = 2;
            this.btnObrisiNezavisnoVozilo.Text = "Obrisi nezavisno vozilo";
            this.btnObrisiNezavisnoVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiNezavisnoVozilo.Click += new System.EventHandler(this.btnObrisiNezavisnoVozilo_Click);
            // 
            // ServisiranaNezavisnaVozilaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 320);
            this.Controls.Add(this.btnObrisiNezavisnoVozilo);
            this.Controls.Add(this.listNezavisnaVozila);
            this.MaximumSize = new System.Drawing.Size(791, 359);
            this.MinimumSize = new System.Drawing.Size(791, 359);
            this.Name = "ServisiranaNezavisnaVozilaForm";
            this.Text = "ServisiranaNezavisnaVozilaForm";
            this.Load += new System.EventHandler(this.ServisiranaNezavisnaVozilaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listNezavisnaVozila;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnObrisiNezavisnoVozilo;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}