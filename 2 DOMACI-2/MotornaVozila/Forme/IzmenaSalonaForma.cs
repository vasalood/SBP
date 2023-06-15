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
    public partial class IzmenaSalonaForma : Form
    {
        public SalonBasic sb;
        public IzmenaSalonaForma()
        {
            InitializeComponent();
        }
        public IzmenaSalonaForma(SalonBasic sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        private void IzmenaSalonaForma_Load(object sender, EventArgs e)
        {
            this.listSefovi.Items.Clear();

            if (listSefovi == null) return;

            List<ZaposleniBasic> sefovi = DTOManager.vratiSefove();

            foreach (ZaposleniBasic sef in sefovi)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        sef.MaticniBroj.ToString(),
                        sef.LicnoIme,
                        sef.Prezime
                    });
                this.listSefovi.Items.Add(item);
            }

            this.listSefovi.Refresh();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listSefovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite novog sefa!");
                return;
            }

            DTOManager.izmeniSalon(sb.Id, Int64.Parse(listSefovi.SelectedItems[0].SubItems[0].Text),
                                        txtIme.Text, txtLokacija.Text);


            //if (txtIme.Text != "") sb.Ime = txtIme.Text;
            //if(txtLokacija.Text != "") sb.Lokacija = txtLokacija.Text;
            //if(sb.SefSalona != null)
            //{
            //    sb.SefSalona.LicnoIme = listSefovi.SelectedItems[0].SubItems[0].Text;
            //    sb.SefSalona.Prezime = listSefovi.SelectedItems[0].SubItems[1].Text;
           // }

            this.Close();
        }
    }
}
