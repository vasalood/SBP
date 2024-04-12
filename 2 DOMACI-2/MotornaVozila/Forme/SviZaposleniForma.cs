using MotornaVozila.Entiteti;
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
    public partial class SviZaposleniForma : Form
    {
        public int brojZaposlenih = 0;  
        public SviZaposleniForma()
        {
            InitializeComponent();
        }

        private void SviZaposleniForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.brojZaposlenih = 0;
            List<ZaposleniPregled> listaZaposlenih = DTOManager.vratiSveZaposlene();

            this.listSviZaposleni.Items.Clear();

            if (listaZaposlenih == null) return;

            foreach (ZaposleniPregled z in listaZaposlenih ) 
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        z.MatBr.ToString(),
                        z.Ime,
                        z.Prezime,
                        z.DatumRodjenja.ToShortDateString(),
                        z.DatumZaposlenja.ToShortDateString(),
                        z.Plata.ToString(),
                        z.Sef ? "Da" : "Ne",
                        z.Rukovodilac ? "Da" : "Ne",
                        z.Direktor ? "Da" : "Ne"
                    });
                this.listSviZaposleni.Items.Add(item);
                this.brojZaposlenih++;
            }

            txtBrojZaposlenih.Text = this.brojZaposlenih.ToString();
            this.listSviZaposleni.Refresh();
        }

        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (listSviZaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da izmenite!");
                return;
            }
            long matbr = Int64.Parse(listSviZaposleni.SelectedItems[0].SubItems[0].Text);

            ZaposleniBasic zs = DTOManager.vratiZaposlenogZaIzmenu(matbr);
            IzmenaZaposlenogForma forma = new IzmenaZaposlenogForma(zs);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnDodajNadredjenog_Click(object sender, EventArgs e)
        {
            NoviNadredjeniForm forma = new NoviNadredjeniForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnDodajPodr_Click(object sender, EventArgs e)
        {
            NoviPodredjeniForm forma = new NoviPodredjeniForm();
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            if (listSviZaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!");
                return;
            }

            long matbr = Int64.Parse(listSviZaposleni.SelectedItems[0].SubItems[0].Text);
            DialogResult result = MessageBox.Show("Da li zelite da obrisete izabranog zaposlenog?",
                                                    "Warning",
                                                    MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                int rez = DTOManager.obrisiRadnikaIzSistema(matbr);
                if (rez == 1) MessageBox.Show("Brisanje zaposlenog je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }
    }
}
