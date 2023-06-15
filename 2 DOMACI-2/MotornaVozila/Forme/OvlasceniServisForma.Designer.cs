namespace MotornaVozila.Forme
{
    partial class OvlasceniServisForma
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
            this.listSviZaposleniServisa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSviZaposleniServis = new System.Windows.Forms.Label();
            this.txtLokacijaServisa = new System.Windows.Forms.TextBox();
            this.lblImeSalona = new System.Windows.Forms.Label();
            this.txtImeServisa = new System.Windows.Forms.TextBox();
            this.lblLokacijaSalona = new System.Windows.Forms.Label();
            this.txtImeSefaServisa = new System.Windows.Forms.TextBox();
            this.lblSef = new System.Windows.Forms.Label();
            this.btnPrikaziServisiranja = new System.Windows.Forms.Button();
            this.btnServisVisegRanga = new System.Windows.Forms.Button();
            this.chbVulkanizer = new System.Windows.Forms.CheckBox();
            this.chbMehanicar = new System.Windows.Forms.CheckBox();
            this.chbFarbar = new System.Windows.Forms.CheckBox();
            this.chbLimar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listSviZaposleniServisa
            // 
            this.listSviZaposleniServisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listSviZaposleniServisa.HideSelection = false;
            this.listSviZaposleniServisa.Location = new System.Drawing.Point(15, 37);
            this.listSviZaposleniServisa.Name = "listSviZaposleniServisa";
            this.listSviZaposleniServisa.Size = new System.Drawing.Size(528, 413);
            this.listSviZaposleniServisa.TabIndex = 5;
            this.listSviZaposleniServisa.UseCompatibleStateImageBehavior = false;
            this.listSviZaposleniServisa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Maticni broj";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Struka";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Plata";
            this.columnHeader5.Width = 106;
            // 
            // lblSviZaposleniServis
            // 
            this.lblSviZaposleniServis.AutoSize = true;
            this.lblSviZaposleniServis.Location = new System.Drawing.Point(12, 18);
            this.lblSviZaposleniServis.Name = "lblSviZaposleniServis";
            this.lblSviZaposleniServis.Size = new System.Drawing.Size(149, 13);
            this.lblSviZaposleniServis.TabIndex = 8;
            this.lblSviZaposleniServis.Text = "Lista svih zaposlenih u servisu";
            // 
            // txtLokacijaServisa
            // 
            this.txtLokacijaServisa.Location = new System.Drawing.Point(643, 34);
            this.txtLokacijaServisa.Name = "txtLokacijaServisa";
            this.txtLokacijaServisa.ReadOnly = true;
            this.txtLokacijaServisa.Size = new System.Drawing.Size(139, 20);
            this.txtLokacijaServisa.TabIndex = 10;
            // 
            // lblImeSalona
            // 
            this.lblImeSalona.AutoSize = true;
            this.lblImeSalona.Location = new System.Drawing.Point(546, 37);
            this.lblImeSalona.Name = "lblImeSalona";
            this.lblImeSalona.Size = new System.Drawing.Size(63, 13);
            this.lblImeSalona.TabIndex = 11;
            this.lblImeSalona.Text = "Ime servisa:";
            // 
            // txtImeServisa
            // 
            this.txtImeServisa.Location = new System.Drawing.Point(643, 60);
            this.txtImeServisa.Name = "txtImeServisa";
            this.txtImeServisa.ReadOnly = true;
            this.txtImeServisa.Size = new System.Drawing.Size(139, 20);
            this.txtImeServisa.TabIndex = 12;
            // 
            // lblLokacijaSalona
            // 
            this.lblLokacijaSalona.AutoSize = true;
            this.lblLokacijaSalona.Location = new System.Drawing.Point(546, 67);
            this.lblLokacijaSalona.Name = "lblLokacijaSalona";
            this.lblLokacijaSalona.Size = new System.Drawing.Size(50, 13);
            this.lblLokacijaSalona.TabIndex = 13;
            this.lblLokacijaSalona.Text = "Lokacija:";
            // 
            // txtImeSefaServisa
            // 
            this.txtImeSefaServisa.Location = new System.Drawing.Point(643, 86);
            this.txtImeSefaServisa.Name = "txtImeSefaServisa";
            this.txtImeSefaServisa.ReadOnly = true;
            this.txtImeSefaServisa.Size = new System.Drawing.Size(139, 20);
            this.txtImeSefaServisa.TabIndex = 14;
            // 
            // lblSef
            // 
            this.lblSef.AutoSize = true;
            this.lblSef.Location = new System.Drawing.Point(546, 89);
            this.lblSef.Name = "lblSef";
            this.lblSef.Size = new System.Drawing.Size(91, 13);
            this.lblSef.TabIndex = 15;
            this.lblSef.Text = "Ime i prezime sefa";
            // 
            // btnPrikaziServisiranja
            // 
            this.btnPrikaziServisiranja.Location = new System.Drawing.Point(590, 301);
            this.btnPrikaziServisiranja.Name = "btnPrikaziServisiranja";
            this.btnPrikaziServisiranja.Size = new System.Drawing.Size(192, 38);
            this.btnPrikaziServisiranja.TabIndex = 16;
            this.btnPrikaziServisiranja.Text = "Prikaz servisiranja obavljenih\r\nu servisu\r\n\r\n";
            this.btnPrikaziServisiranja.UseVisualStyleBackColor = true;
            this.btnPrikaziServisiranja.Click += new System.EventHandler(this.btnPrikaziServisiranja_Click);
            // 
            // btnServisVisegRanga
            // 
            this.btnServisVisegRanga.Location = new System.Drawing.Point(590, 363);
            this.btnServisVisegRanga.Name = "btnServisVisegRanga";
            this.btnServisVisegRanga.Size = new System.Drawing.Size(192, 23);
            this.btnServisVisegRanga.TabIndex = 17;
            this.btnServisVisegRanga.Text = "Prikazi servis viseg ranga";
            this.btnServisVisegRanga.UseVisualStyleBackColor = true;
            this.btnServisVisegRanga.Click += new System.EventHandler(this.btnServisVisegRanga_Click);
            // 
            // chbVulkanizer
            // 
            this.chbVulkanizer.AutoCheck = false;
            this.chbVulkanizer.AutoSize = true;
            this.chbVulkanizer.Location = new System.Drawing.Point(590, 139);
            this.chbVulkanizer.Name = "chbVulkanizer";
            this.chbVulkanizer.Size = new System.Drawing.Size(126, 17);
            this.chbVulkanizer.TabIndex = 18;
            this.chbVulkanizer.Text = "Vulkanizerske usluge";
            this.chbVulkanizer.UseVisualStyleBackColor = true;
            // 
            // chbMehanicar
            // 
            this.chbMehanicar.AutoCheck = false;
            this.chbMehanicar.AutoSize = true;
            this.chbMehanicar.Location = new System.Drawing.Point(590, 172);
            this.chbMehanicar.Name = "chbMehanicar";
            this.chbMehanicar.Size = new System.Drawing.Size(127, 17);
            this.chbMehanicar.TabIndex = 19;
            this.chbMehanicar.Text = "Mehanicarske usluge";
            this.chbMehanicar.UseVisualStyleBackColor = true;
            // 
            // chbFarbar
            // 
            this.chbFarbar.AutoCheck = false;
            this.chbFarbar.AutoSize = true;
            this.chbFarbar.Location = new System.Drawing.Point(590, 216);
            this.chbFarbar.Name = "chbFarbar";
            this.chbFarbar.Size = new System.Drawing.Size(107, 17);
            this.chbFarbar.TabIndex = 20;
            this.chbFarbar.Text = "Farbarske usluge";
            this.chbFarbar.UseVisualStyleBackColor = true;
            // 
            // chbLimar
            // 
            this.chbLimar.AutoCheck = false;
            this.chbLimar.AutoSize = true;
            this.chbLimar.Location = new System.Drawing.Point(590, 255);
            this.chbLimar.Name = "chbLimar";
            this.chbLimar.Size = new System.Drawing.Size(102, 17);
            this.chbLimar.TabIndex = 21;
            this.chbLimar.Text = "Limarske usluge";
            this.chbLimar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Izmeni servis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OvlasceniServisForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbLimar);
            this.Controls.Add(this.chbFarbar);
            this.Controls.Add(this.chbMehanicar);
            this.Controls.Add(this.chbVulkanizer);
            this.Controls.Add(this.btnServisVisegRanga);
            this.Controls.Add(this.btnPrikaziServisiranja);
            this.Controls.Add(this.lblSef);
            this.Controls.Add(this.txtImeSefaServisa);
            this.Controls.Add(this.lblLokacijaSalona);
            this.Controls.Add(this.txtImeServisa);
            this.Controls.Add(this.lblImeSalona);
            this.Controls.Add(this.txtLokacijaServisa);
            this.Controls.Add(this.lblSviZaposleniServis);
            this.Controls.Add(this.listSviZaposleniServisa);
            this.MaximumSize = new System.Drawing.Size(855, 498);
            this.MinimumSize = new System.Drawing.Size(855, 498);
            this.Name = "OvlasceniServisForma";
            this.Text = "OvlasceniServisForma";
            this.Load += new System.EventHandler(this.OvlasceniServisForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listSviZaposleniServisa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblSviZaposleniServis;
        private System.Windows.Forms.TextBox txtLokacijaServisa;
        private System.Windows.Forms.Label lblImeSalona;
        private System.Windows.Forms.TextBox txtImeServisa;
        private System.Windows.Forms.Label lblLokacijaSalona;
        private System.Windows.Forms.TextBox txtImeSefaServisa;
        private System.Windows.Forms.Label lblSef;
        private System.Windows.Forms.Button btnPrikaziServisiranja;
        private System.Windows.Forms.Button btnServisVisegRanga;
        private System.Windows.Forms.CheckBox chbVulkanizer;
        private System.Windows.Forms.CheckBox chbMehanicar;
        private System.Windows.Forms.CheckBox chbFarbar;
        private System.Windows.Forms.CheckBox chbLimar;
        private System.Windows.Forms.Button button1;
    }
}