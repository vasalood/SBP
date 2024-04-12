namespace MotornaVozila.Forme
{
    partial class NoviServisForma
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
            this.btnDodajServis = new System.Windows.Forms.Button();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.chbVulkanizer = new System.Windows.Forms.CheckBox();
            this.chbMehanicar = new System.Windows.Forms.CheckBox();
            this.chbFarbar = new System.Windows.Forms.CheckBox();
            this.chbLimar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDodajServis
            // 
            this.btnDodajServis.Location = new System.Drawing.Point(78, 174);
            this.btnDodajServis.Name = "btnDodajServis";
            this.btnDodajServis.Size = new System.Drawing.Size(77, 29);
            this.btnDodajServis.TabIndex = 9;
            this.btnDodajServis.Text = "Dodaj servis";
            this.btnDodajServis.UseVisualStyleBackColor = true;
            this.btnDodajServis.Click += new System.EventHandler(this.btnDodajServis_Click);
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Location = new System.Drawing.Point(14, 47);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(86, 13);
            this.lblLokacija.TabIndex = 8;
            this.lblLokacija.Text = "Lokacija servisa:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(39, 15);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(63, 13);
            this.lblIme.TabIndex = 7;
            this.lblIme.Text = "Ime servisa:";
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(104, 44);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(102, 20);
            this.txtLokacija.TabIndex = 6;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(104, 12);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(102, 20);
            this.txtIme.TabIndex = 5;
            // 
            // chbVulkanizer
            // 
            this.chbVulkanizer.AutoSize = true;
            this.chbVulkanizer.Location = new System.Drawing.Point(68, 82);
            this.chbVulkanizer.Name = "chbVulkanizer";
            this.chbVulkanizer.Size = new System.Drawing.Size(126, 17);
            this.chbVulkanizer.TabIndex = 10;
            this.chbVulkanizer.Text = "Vulkanizerske usluge";
            this.chbVulkanizer.UseVisualStyleBackColor = true;
            // 
            // chbMehanicar
            // 
            this.chbMehanicar.AutoSize = true;
            this.chbMehanicar.Location = new System.Drawing.Point(68, 105);
            this.chbMehanicar.Name = "chbMehanicar";
            this.chbMehanicar.Size = new System.Drawing.Size(127, 17);
            this.chbMehanicar.TabIndex = 11;
            this.chbMehanicar.Text = "Mehanicarske usluge";
            this.chbMehanicar.UseVisualStyleBackColor = true;
            // 
            // chbFarbar
            // 
            this.chbFarbar.AutoSize = true;
            this.chbFarbar.Location = new System.Drawing.Point(68, 128);
            this.chbFarbar.Name = "chbFarbar";
            this.chbFarbar.Size = new System.Drawing.Size(107, 17);
            this.chbFarbar.TabIndex = 12;
            this.chbFarbar.Text = "Farbarske usluge";
            this.chbFarbar.UseVisualStyleBackColor = true;
            // 
            // chbLimar
            // 
            this.chbLimar.AutoSize = true;
            this.chbLimar.Location = new System.Drawing.Point(68, 151);
            this.chbLimar.Name = "chbLimar";
            this.chbLimar.Size = new System.Drawing.Size(102, 17);
            this.chbLimar.TabIndex = 13;
            this.chbLimar.Text = "Limarske usluge";
            this.chbLimar.UseVisualStyleBackColor = true;
            // 
            // NoviServisForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 215);
            this.Controls.Add(this.chbLimar);
            this.Controls.Add(this.chbFarbar);
            this.Controls.Add(this.chbMehanicar);
            this.Controls.Add(this.chbVulkanizer);
            this.Controls.Add(this.btnDodajServis);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtIme);
            this.MaximumSize = new System.Drawing.Size(244, 254);
            this.MinimumSize = new System.Drawing.Size(244, 254);
            this.Name = "NoviServisForma";
            this.Text = "NoviServisForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajServis;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.CheckBox chbVulkanizer;
        private System.Windows.Forms.CheckBox chbMehanicar;
        private System.Windows.Forms.CheckBox chbFarbar;
        private System.Windows.Forms.CheckBox chbLimar;
    }
}