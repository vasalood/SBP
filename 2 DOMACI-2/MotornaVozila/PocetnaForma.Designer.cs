namespace MotornaVozila
{
    partial class PocetnaForma
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
            this.lblProdajaMotornihVozila = new System.Windows.Forms.Label();
            this.btnPredstavnistva = new System.Windows.Forms.Button();
            this.btnZaposleni = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProdajaMotornihVozila
            // 
            this.lblProdajaMotornihVozila.AutoSize = true;
            this.lblProdajaMotornihVozila.Location = new System.Drawing.Point(147, 42);
            this.lblProdajaMotornihVozila.Name = "lblProdajaMotornihVozila";
            this.lblProdajaMotornihVozila.Size = new System.Drawing.Size(160, 13);
            this.lblProdajaMotornihVozila.TabIndex = 0;
            this.lblProdajaMotornihVozila.Text = "PRODAJA MOTORNIH VOZILA";
            // 
            // btnPredstavnistva
            // 
            this.btnPredstavnistva.Location = new System.Drawing.Point(145, 99);
            this.btnPredstavnistva.Name = "btnPredstavnistva";
            this.btnPredstavnistva.Size = new System.Drawing.Size(162, 23);
            this.btnPredstavnistva.TabIndex = 1;
            this.btnPredstavnistva.Text = "PREDSTAVNISTVA";
            this.btnPredstavnistva.UseVisualStyleBackColor = true;
            this.btnPredstavnistva.Click += new System.EventHandler(this.btnPredstavnistva_Click);
            // 
            // btnZaposleni
            // 
            this.btnZaposleni.Location = new System.Drawing.Point(145, 164);
            this.btnZaposleni.Name = "btnZaposleni";
            this.btnZaposleni.Size = new System.Drawing.Size(162, 23);
            this.btnZaposleni.TabIndex = 2;
            this.btnZaposleni.Text = "ZAPOSLENI";
            this.btnZaposleni.UseVisualStyleBackColor = true;
            this.btnZaposleni.Click += new System.EventHandler(this.btnZaposleni_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.Location = new System.Drawing.Point(145, 242);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(162, 23);
            this.btnVozila.TabIndex = 3;
            this.btnVozila.Text = "VOZILA";
            this.btnVozila.UseVisualStyleBackColor = true;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 317);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.btnZaposleni);
            this.Controls.Add(this.btnPredstavnistva);
            this.Controls.Add(this.lblProdajaMotornihVozila);
            this.MaximumSize = new System.Drawing.Size(453, 356);
            this.MinimumSize = new System.Drawing.Size(453, 356);
            this.Name = "PocetnaForma";
            this.Text = "PocetnaForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdajaMotornihVozila;
        private System.Windows.Forms.Button btnPredstavnistva;
        private System.Windows.Forms.Button btnZaposleni;
        private System.Windows.Forms.Button btnVozila;
    }
}