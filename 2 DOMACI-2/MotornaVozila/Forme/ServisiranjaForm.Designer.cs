namespace MotornaVozila.Forme
{
    partial class ServisiranjaForm
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
            this.listServisiranja = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblServisiranja = new System.Windows.Forms.Label();
            this.btnNezavisnaVozila = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listServisiranja
            // 
            this.listServisiranja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listServisiranja.FullRowSelect = true;
            this.listServisiranja.HideSelection = false;
            this.listServisiranja.Location = new System.Drawing.Point(15, 45);
            this.listServisiranja.Name = "listServisiranja";
            this.listServisiranja.Size = new System.Drawing.Size(779, 388);
            this.listServisiranja.TabIndex = 0;
            this.listServisiranja.UseCompatibleStateImageBehavior = false;
            this.listServisiranja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "PFR";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Datum prijema";
            this.columnHeader8.Width = 130;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Datum zavrsetka";
            this.columnHeader9.Width = 130;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Opis problema";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Registracija vozila";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Izvrsio prijem";
            this.columnHeader3.Width = 190;
            // 
            // lblServisiranja
            // 
            this.lblServisiranja.AutoSize = true;
            this.lblServisiranja.Location = new System.Drawing.Point(12, 29);
            this.lblServisiranja.Name = "lblServisiranja";
            this.lblServisiranja.Size = new System.Drawing.Size(202, 13);
            this.lblServisiranja.TabIndex = 1;
            this.lblServisiranja.Text = "Lista svih servisiranja u izabranom servisu";
            // 
            // btnNezavisnaVozila
            // 
            this.btnNezavisnaVozila.Location = new System.Drawing.Point(800, 114);
            this.btnNezavisnaVozila.Name = "btnNezavisnaVozila";
            this.btnNezavisnaVozila.Size = new System.Drawing.Size(123, 72);
            this.btnNezavisnaVozila.TabIndex = 2;
            this.btnNezavisnaVozila.Text = "Prikazi vozila kupljena nezavisno";
            this.btnNezavisnaVozila.UseVisualStyleBackColor = true;
            this.btnNezavisnaVozila.Click += new System.EventHandler(this.btnNezavisnaVozila_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.Location = new System.Drawing.Point(800, 229);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(123, 80);
            this.btnVozila.TabIndex = 3;
            this.btnVozila.Text = "Prikazi servisirana vozila kupljena od kompanije";
            this.btnVozila.UseVisualStyleBackColor = true;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // ServisiranjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 440);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.btnNezavisnaVozila);
            this.Controls.Add(this.lblServisiranja);
            this.Controls.Add(this.listServisiranja);
            this.MaximumSize = new System.Drawing.Size(951, 479);
            this.MinimumSize = new System.Drawing.Size(951, 479);
            this.Name = "ServisiranjaForm";
            this.Text = "ServisiranjaForm";
            this.Load += new System.EventHandler(this.ServisiranjaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listServisiranja;
        private System.Windows.Forms.Label lblServisiranja;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnNezavisnaVozila;
        private System.Windows.Forms.Button btnVozila;
    }
}