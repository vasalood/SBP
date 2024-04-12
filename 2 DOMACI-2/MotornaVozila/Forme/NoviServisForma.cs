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
    public partial class NoviServisForma : Form
    {
        public int id;
        public NoviServisForma()
        {
            InitializeComponent();
        }
        public NoviServisForma(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnDodajServis_Click(object sender, EventArgs e)
        {
            if(txtIme.Text == "" || txtLokacija.Text == "" || 
                (!chbVulkanizer.Checked &&
                !chbMehanicar.Checked &&
                !chbLimar.Checked &&
                !chbFarbar.Checked))
            {
                MessageBox.Show("MORATE POPUNITI IME I LOKACIJU I BAR JEDAN BOX");
                return;
            }

            DTOManager.dodajNoviServis(id, txtIme.Text, txtLokacija.Text,
                                        chbVulkanizer.Checked, chbMehanicar.Checked,
                                        chbLimar.Checked, chbFarbar.Checked);

            MessageBox.Show("Uspesno dodat ovlasceni servis!");
            this.Close();
        }
    }
}
