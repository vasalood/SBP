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
    public partial class DodajVoziloForma : Form
    {
        public int idSalona;
        public DodajVoziloForma()
        {
            InitializeComponent();
        }
        public DodajVoziloForma(int id)
        {
            InitializeComponent();
            idSalona = id;
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtBoja.Text == "" ||
                txtGorivo.Text == "" ||
                txtKubikaza.Text == "" ||
                txtModel.Text == "" ||
                txtMotor.Text == "" ||
                txtSasija.Text == "" ||
                (!chbPutnicko.Checked && !chbTeretno.Checked))
            {
                MessageBox.Show("SVA POLJA SU OBAVEZNA!");
                return;
            }

            DTOManager.dodajVozilo(txtBoja.Text, txtGorivo.Text, txtKubikaza.Text,
                txtModel.Text, txtMotor.Text, txtSasija.Text, chbPutnicko.Checked,
                chbTeretno.Checked, idSalona);
            MessageBox.Show("Vozilo uspesno dodato");
            this.Close();
        }
    }
}
