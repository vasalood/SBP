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
    public partial class NoviSalonForma : Form
    {
        public int id;
        public NoviSalonForma()
        {
            InitializeComponent();
        }
        public NoviSalonForma(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void btnDodajSalon_Click(object sender, EventArgs e)
        {
            if(txtIme.Text == "" || txtLokacija.Text == "")
            {
                MessageBox.Show("POLJA SU OBAVEZNA");
                return;
            }
            DTOManager.dodajNoviSalon(id, txtIme.Text, txtLokacija.Text);

            MessageBox.Show("Uspesno dodat salon");
            this.Close();
        }
    }
}
