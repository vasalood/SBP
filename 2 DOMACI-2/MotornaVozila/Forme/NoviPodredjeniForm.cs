using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotornaVozila.Forme
{
    public partial class NoviPodredjeniForm : Form
    {
       
        public NoviPodredjeniForm()
        {
            InitializeComponent();
            numPlata.Maximum = 500000;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
           
          long matbr = Int64.Parse(txtMbr.Text);
            if (cbxEkonomska.Checked)
                DTOManager.dodajNovogPodredjenogEkonomska(matbr, txtIme.Text, txtPrezime.Text, datumRodj.Value, datumZap.Value, cbxDa.Checked, datumSertifikata.Value,(int)numPlata.Value,(int)godineStaza.Value);
            else
                DTOManager.dodajNovogPodredjenogTehnicka(matbr, txtIme.Text, txtPrezime.Text, datumRodj.Value, datumZap.Value,tbxNazivSpec.Text,tbxInstitucijaSpec.Text,datumSticanja.Value, (int)numPlata.Value, (int)godineStaza.Value);

            MessageBox.Show("Uspesno dodat radnik");
            this.Close();
        }

        private void cbxTehnicka_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTehnicka.Checked)
            {
                cbxEkonomska.Enabled = false;
                datumSertifikata.Enabled = false;
                cbxDa.Enabled = false;
                cbxNe.Enabled = false;
            }
            else
            {
                cbxEkonomska.Enabled = true;
                datumSertifikata.Enabled = true;
                cbxDa.Enabled = true;
                cbxNe.Enabled = true;
            }
        }

        private void cbxEkonomska_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEkonomska.Checked)
            {
                cbxTehnicka.Enabled = false;
                tbxInstitucijaSpec.Enabled = false;
                tbxNazivSpec.Enabled = false;
                datumSticanja.Enabled = false;
            }
            else
            { 
                cbxTehnicka.Enabled = true;
                tbxInstitucijaSpec.Enabled = true;
                tbxNazivSpec.Enabled = true;
                datumSticanja.Enabled = true;
            }
        }

        private void cbxDa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDa.Checked)
            {
                cbxNe.Enabled = false;
            }
            else
                cbxNe.Enabled = true;
        }

        private void cbxNe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNe.Checked)
            {
                cbxDa.Enabled = false;
                datumSertifikata.Enabled = false;
            }
            else
            {
                cbxDa.Enabled = true;
                datumSertifikata.Enabled = true;
            }
        }

        private void datumSertifikata_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void datumSticanja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxInstitucijaSpec_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxNazivSpec_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void datumZap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datumRodj_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //public int id;
        //public NoviSalonForma()
        //{
        //    InitializeComponent();
        //}
        //public NoviSalonForma(int id)
        //{
        //    InitializeComponent();
        //    this.id = id;
        //}
        //private void btnDodajSalon_Click(object sender, EventArgs e)
        //{
        //    if (txtIme.Text == "" || txtLokacija.Text == "")
        //    {
        //        MessageBox.Show("POLJA SU OBAVEZNA");
        //        return;
        //    }
        //    DTOManager.dodajNoviSalon(id, txtIme.Text, txtLokacija.Text);

        //    MessageBox.Show("Uspesno dodat salon");
        //    this.Close();
        //}
    }
}
