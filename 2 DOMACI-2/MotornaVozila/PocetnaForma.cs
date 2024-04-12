using MotornaVozila.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotornaVozila
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void btnPredstavnistva_Click(object sender, EventArgs e)
        {
            SvaPredstavnistvaForma forma = new SvaPredstavnistvaForma();
            forma.ShowDialog();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            SviZaposleniForma forma = new SviZaposleniForma();
            forma.ShowDialog();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            SvaVozilaForma forma = new SvaVozilaForma();
            forma.ShowDialog();
        }
    }
}
