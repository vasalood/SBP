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
    public partial class IzmenaZaposlenogForma : Form
    {
        public ZaposleniBasic zb;
        public IzmenaZaposlenogForma()
        {
            InitializeComponent();
        }
        public IzmenaZaposlenogForma(ZaposleniBasic zb)
        {
            InitializeComponent();
            this.zb = zb;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            zb.LicnoIme = txtIme.Text;
            zb.Prezime = txtPrezime.Text;
            zb.Plata = Int32.Parse(txtPlata.Text);

            DTOManager.izmeniZaposlenog(zb);
            this.Close();
        }
    }
}
