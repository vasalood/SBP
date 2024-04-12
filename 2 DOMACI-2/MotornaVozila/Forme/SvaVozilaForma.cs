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
    public partial class SvaVozilaForma : Form
    {
        public int brojVozila = 0;
        public SvaVozilaForma()
        {
            InitializeComponent();
        }

        private void SvaVozilaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.brojVozila = 0;
            List<VoziloPregled> listaVozila = DTOManager.vratiSvaVozila();

            this.listSvaVozila.Items.Clear();

            if (listaVozila == null) return;
            string pom = "";
            foreach (VoziloPregled v in listaVozila)
            {
                if (v.putnicko && v.teretno)  pom = "Pick-Up";
                else if (v.teretno) pom = "Teretno";
                else if (v.putnicko) pom = "Putnicko"; 

                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        v.brSasije,
                        v.brMotora,
                        v.model,
                        v.kubikaza.ToString(),
                        pom,
                        v.boja
                    });
                this.listSvaVozila.Items.Add(item);
                this.brojVozila++;
            }

            txtBrojVozila.Text = this.brojVozila.ToString();
            this.listSvaVozila.Refresh();
        }

        private void btnObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (listSvaVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje zelite da obrisete!");
                return;
            }

            string brSasije = listSvaVozila.SelectedItems[0].SubItems[0].Text;
            DialogResult result = MessageBox.Show("Da li zelite da obrisete izabrano vozilo?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVoziloIzSistema(brSasije);
                MessageBox.Show("Brisanje vozila je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
