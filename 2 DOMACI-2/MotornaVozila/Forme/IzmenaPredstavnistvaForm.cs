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
    public partial class IzmenaPredstavnistvaForm : Form
    {
        public int id;
        public IzmenaPredstavnistvaForm()
        {
            InitializeComponent();
        }
        public IzmenaPredstavnistvaForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            DTOManager.izmeniPredstavnistvo(id, txtGrad.Text, txtIme.Text);
            MessageBox.Show("Predstavnistvo uspesno izmenjeno!");
            this.Close();
        }
    }
}
