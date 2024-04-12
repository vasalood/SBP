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
    public partial class DodavanjePredstavnistvaForm : Form
    {
        public DodavanjePredstavnistvaForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtGrad.Text == "" || txtIme.Text == "")
            {
                MessageBox.Show("POLJA SU OBAVEZNA");
                return;
            }
            DTOManager.dodajNovoPredstavnistvo(txtGrad.Text, txtIme.Text);
            MessageBox.Show("Predstavnistvo uspesno dodato!");
            this.Close();
        }
    }
}
