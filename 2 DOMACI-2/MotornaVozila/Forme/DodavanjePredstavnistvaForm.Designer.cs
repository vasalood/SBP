namespace MotornaVozila.Forme
{
    partial class DodavanjePredstavnistvaForm
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
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(70, 30);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(100, 20);
            this.txtGrad.TabIndex = 0;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(70, 68);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 1;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(82, 107);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(20, 30);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(33, 13);
            this.lblGrad.TabIndex = 3;
            this.lblGrad.Text = "Grad:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(20, 71);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(43, 13);
            this.lblIme.TabIndex = 4;
            this.lblIme.Text = "Adresa:";
            // 
            // DodavanjePredstavnistvaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 142);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtGrad);
            this.Name = "DodavanjePredstavnistvaForm";
            this.Text = "DodavanjePredstavnistvaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblIme;
    }
}