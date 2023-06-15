using Microsoft.Win32;
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
    public partial class ObaviProdajuForm : Form
    {
        public int idSalona;
        public ObaviProdajuForm()
        {
            InitializeComponent();
        }
        public ObaviProdajuForm(int id)
        {
            InitializeComponent();
            idSalona = id;
        }

        private void ObaviProdajuForm_Load(object sender, EventArgs e)
        {
            List<VoziloBasic> listaVozila = DTOManager.vratiVozilaSalona(idSalona);

            this.listVozila.Items.Clear();

            if (listaVozila == null) return;
            if (listaVozila.Count == 0)
            {
                MessageBox.Show("Ne postoje vozila u ovom salonu");
                this.Close();
                return;
            }

            foreach (VoziloBasic v in listaVozila)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        v.Model,
                        v.Kubikaza.ToString(),
                        v.Boja,
                        v.Id.ToString()
                    });
                this.listVozila.Items.Add(item);
            }

            this.listVozila.Refresh();

            List<PodredjeniBasic> listaZaposlenih = DTOManager.vratiProdavceSalona(idSalona);

            this.listProdavci.Items.Clear();

            if (listaZaposlenih == null) return;
            if (listaZaposlenih.Count == 0)
            {
                MessageBox.Show("Ne postoje prodavci u ovom salonu");
                this.Close();
                return;
            }
            foreach (PodredjeniBasic z in listaZaposlenih)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        z.MaticniBroj.ToString(),
                        z.LicnoIme,
                        z.Prezime,
                    });
                this.listProdavci.Items.Add(item);
            }

            this.listProdavci.Refresh();
        }

        private void btnObaviProdaju_Click(object sender, EventArgs e)
        {
            if (listProdavci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete prodavca!");
                return;
            }
            if (listVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete vozila!");
                return;
            }
            if(dtpProdaja.Value == null) { dtpProdaja.Value = DateTime.Now; }
            if(txtIme.Text == "" || txtMat.Text == "" || txtPrezime.Text == "")
            {
                MessageBox.Show("Morate da dodate sva polja za kupca!");
                return;
            }
            if(txtCena.Text == "")
            {
                MessageBox.Show("Morate da dodate cenu!");
                return;
            }

            long mbr = Int64.Parse(listProdavci.SelectedItems[0].SubItems[0].Text);
            int idV = Int32.Parse(listVozila.SelectedItems[0].SubItems[3].Text);

            int cena;
            if(!Int32.TryParse(txtCena.Text, out cena))
            {
                MessageBox.Show("Cena mora biti broj.");
                return;
            }

            long matBRKupca;

            if(!Int64.TryParse(txtMat.Text, out matBRKupca))
            {
                MessageBox.Show("Maticni broj mora biti broj.");
                return;
            }

            string imeKupca = txtIme.Text;
            string prezimeKupca = txtPrezime.Text;
            DateTime datumKupovine = dtpProdaja.Value;

            DTOManager.obaviProdaju(idSalona, mbr, idV, cena, matBRKupca, imeKupca, prezimeKupca, datumKupovine);
            MessageBox.Show("Prodaja uspesno obavljena!");
            this.Close();
        }
    }
}
