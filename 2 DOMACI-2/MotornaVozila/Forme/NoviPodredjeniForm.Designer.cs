namespace MotornaVozila.Forme
{
    partial class NoviPodredjeniForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTehnicka = new System.Windows.Forms.CheckBox();
            this.cbxEkonomska = new System.Windows.Forms.CheckBox();
            this.txtMbr = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.datumRodj = new System.Windows.Forms.DateTimePicker();
            this.datumZap = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxNazivSpec = new System.Windows.Forms.TextBox();
            this.tbxInstitucijaSpec = new System.Windows.Forms.TextBox();
            this.datumSticanja = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datumSertifikata = new System.Windows.Forms.DateTimePicker();
            this.cbxDa = new System.Windows.Forms.CheckBox();
            this.cbxNe = new System.Windows.Forms.CheckBox();
            this.godineStaza = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numPlata = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.godineStaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maticni Broj";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum Rodjenja:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum zaposlenja";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbxTehnicka
            // 
            this.cbxTehnicka.AutoSize = true;
            this.cbxTehnicka.Location = new System.Drawing.Point(59, 225);
            this.cbxTehnicka.Name = "cbxTehnicka";
            this.cbxTehnicka.Size = new System.Drawing.Size(103, 17);
            this.cbxTehnicka.TabIndex = 5;
            this.cbxTehnicka.Text = "Tehnicka struka";
            this.cbxTehnicka.UseVisualStyleBackColor = true;
            this.cbxTehnicka.CheckedChanged += new System.EventHandler(this.cbxTehnicka_CheckedChanged);
            // 
            // cbxEkonomska
            // 
            this.cbxEkonomska.AutoSize = true;
            this.cbxEkonomska.Location = new System.Drawing.Point(344, 225);
            this.cbxEkonomska.Name = "cbxEkonomska";
            this.cbxEkonomska.Size = new System.Drawing.Size(114, 17);
            this.cbxEkonomska.TabIndex = 6;
            this.cbxEkonomska.Text = "Ekonomska struka";
            this.cbxEkonomska.UseVisualStyleBackColor = true;
            this.cbxEkonomska.CheckedChanged += new System.EventHandler(this.cbxEkonomska_CheckedChanged);
            // 
            // txtMbr
            // 
            this.txtMbr.Location = new System.Drawing.Point(164, 38);
            this.txtMbr.Name = "txtMbr";
            this.txtMbr.Size = new System.Drawing.Size(100, 20);
            this.txtMbr.TabIndex = 7;
            this.txtMbr.TextChanged += new System.EventHandler(this.txtMbr_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(164, 65);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 8;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(164, 102);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 9;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // datumRodj
            // 
            this.datumRodj.Location = new System.Drawing.Point(184, 144);
            this.datumRodj.Name = "datumRodj";
            this.datumRodj.Size = new System.Drawing.Size(200, 20);
            this.datumRodj.TabIndex = 10;
            this.datumRodj.ValueChanged += new System.EventHandler(this.datumRodj_ValueChanged);
            // 
            // datumZap
            // 
            this.datumZap.Location = new System.Drawing.Point(184, 189);
            this.datumZap.Name = "datumZap";
            this.datumZap.Size = new System.Drawing.Size(200, 20);
            this.datumZap.TabIndex = 11;
            this.datumZap.ValueChanged += new System.EventHandler(this.datumZap_ValueChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(556, 336);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Naziv specijalnosti";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Institucija sticanja specijalnosti";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Datum sticanja specijalnosti";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbxNazivSpec
            // 
            this.tbxNazivSpec.Location = new System.Drawing.Point(194, 260);
            this.tbxNazivSpec.Name = "tbxNazivSpec";
            this.tbxNazivSpec.Size = new System.Drawing.Size(100, 20);
            this.tbxNazivSpec.TabIndex = 16;
            this.tbxNazivSpec.TextChanged += new System.EventHandler(this.tbxNazivSpec_TextChanged);
            // 
            // tbxInstitucijaSpec
            // 
            this.tbxInstitucijaSpec.Location = new System.Drawing.Point(194, 296);
            this.tbxInstitucijaSpec.Name = "tbxInstitucijaSpec";
            this.tbxInstitucijaSpec.Size = new System.Drawing.Size(100, 20);
            this.tbxInstitucijaSpec.TabIndex = 17;
            this.tbxInstitucijaSpec.TextChanged += new System.EventHandler(this.tbxInstitucijaSpec_TextChanged);
            // 
            // datumSticanja
            // 
            this.datumSticanja.Location = new System.Drawing.Point(184, 339);
            this.datumSticanja.Name = "datumSticanja";
            this.datumSticanja.Size = new System.Drawing.Size(200, 20);
            this.datumSticanja.TabIndex = 18;
            this.datumSticanja.ValueChanged += new System.EventHandler(this.datumSticanja_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Posedovanje Sertifikata";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Datum vazenja sertifikata";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // datumSertifikata
            // 
            this.datumSertifikata.Location = new System.Drawing.Point(506, 293);
            this.datumSertifikata.Name = "datumSertifikata";
            this.datumSertifikata.Size = new System.Drawing.Size(200, 20);
            this.datumSertifikata.TabIndex = 21;
            this.datumSertifikata.ValueChanged += new System.EventHandler(this.datumSertifikata_ValueChanged);
            // 
            // cbxDa
            // 
            this.cbxDa.AutoSize = true;
            this.cbxDa.Location = new System.Drawing.Point(506, 259);
            this.cbxDa.Name = "cbxDa";
            this.cbxDa.Size = new System.Drawing.Size(40, 17);
            this.cbxDa.TabIndex = 22;
            this.cbxDa.Text = "Da";
            this.cbxDa.UseVisualStyleBackColor = true;
            this.cbxDa.CheckedChanged += new System.EventHandler(this.cbxDa_CheckedChanged);
            // 
            // cbxNe
            // 
            this.cbxNe.AutoSize = true;
            this.cbxNe.Location = new System.Drawing.Point(630, 259);
            this.cbxNe.Name = "cbxNe";
            this.cbxNe.Size = new System.Drawing.Size(40, 17);
            this.cbxNe.TabIndex = 23;
            this.cbxNe.Text = "Ne";
            this.cbxNe.UseVisualStyleBackColor = true;
            this.cbxNe.CheckedChanged += new System.EventHandler(this.cbxNe_CheckedChanged);
            // 
            // godineStaza
            // 
            this.godineStaza.Location = new System.Drawing.Point(559, 177);
            this.godineStaza.Name = "godineStaza";
            this.godineStaza.Size = new System.Drawing.Size(120, 20);
            this.godineStaza.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 54;
            this.label12.Text = "Godine radnog staza";
            // 
            // numPlata
            // 
            this.numPlata.Location = new System.Drawing.Point(525, 137);
            this.numPlata.Name = "numPlata";
            this.numPlata.Size = new System.Drawing.Size(120, 20);
            this.numPlata.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(431, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Plata";
            // 
            // NoviPodredjeniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.godineStaza);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numPlata);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbxNe);
            this.Controls.Add(this.cbxDa);
            this.Controls.Add(this.datumSertifikata);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.datumSticanja);
            this.Controls.Add(this.tbxInstitucijaSpec);
            this.Controls.Add(this.tbxNazivSpec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.datumZap);
            this.Controls.Add(this.datumRodj);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtMbr);
            this.Controls.Add(this.cbxEkonomska);
            this.Controls.Add(this.cbxTehnicka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NoviPodredjeniForm";
            this.Text = "NoviPodredjeniForm";
            ((System.ComponentModel.ISupportInitialize)(this.godineStaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxTehnicka;
        private System.Windows.Forms.CheckBox cbxEkonomska;
        private System.Windows.Forms.TextBox txtMbr;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.DateTimePicker datumRodj;
        private System.Windows.Forms.DateTimePicker datumZap;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxNazivSpec;
        private System.Windows.Forms.TextBox tbxInstitucijaSpec;
        private System.Windows.Forms.DateTimePicker datumSticanja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datumSertifikata;
        private System.Windows.Forms.CheckBox cbxDa;
        private System.Windows.Forms.CheckBox cbxNe;
        private System.Windows.Forms.NumericUpDown godineStaza;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numPlata;
        private System.Windows.Forms.Label label11;
    }
}