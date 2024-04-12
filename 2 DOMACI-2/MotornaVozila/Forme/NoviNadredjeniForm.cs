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
    public partial class NoviNadredjeniForm : Form
    {
        public NoviNadredjeniForm()
        {
            InitializeComponent();
            numPlata.Maximum = 500000;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            long matbr = Int64.Parse(txtMbr.Text);
            if (cbxEkonomska.Checked)
                DTOManager.dodajNovogNadredjenogEkonomska(matbr, txtIme.Text, txtPrezime.Text, datumRodj.Value, datumZap.Value, cbxDa.Checked, datumSertifikata.Value,(int)numPlata.Value,(int)godineStaza.Value,cbxSef.Checked,cbxDiretkor.Checked,cbxRukovodilac.Checked);
            else
                DTOManager.dodajNovogNadredjenogTehnicka(matbr, txtIme.Text, txtPrezime.Text, datumRodj.Value, datumZap.Value, tbxNazivSpec.Text, tbxInstitucijaSpec.Text, datumSticanja.Value, (int)numPlata.Value, (int)godineStaza.Value, cbxSef.Checked, cbxDiretkor.Checked, cbxRukovodilac.Checked);

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

    }
}
