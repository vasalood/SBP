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
    public partial class ServisiranjaForm : Form
    {
        public List<ServisiranjeBasic> servisiranja;
        public ServisiranjaForm()
        {
            InitializeComponent();
        }
        public ServisiranjaForm(List<ServisiranjeBasic> lista)
        {
            InitializeComponent();
            servisiranja = lista;   
        }

        private void ServisiranjaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima() 
        {
            this.listServisiranja.Items.Clear();

            foreach (ServisiranjeBasic z in servisiranja)
            {
                ServisiranjePregled sp = new ServisiranjePregled(z.PFR, z.DatumPrijema.ToShortDateString(),
                    z.DatumZavrsetka.ToShortDateString()
                    , z.OpisProblema, z.ServisiranoVozilo.RegistarskiBroj,
                    z.Primalac.LicnoIme + " " + z.Primalac.Prezime);

                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        sp.PFR,
                        sp.datumPrijema,
                        sp.datumZavrsetka,
                        sp.opis,
                        sp.regVozila,
                        sp.ImeiPrezime
                    });

                this.listServisiranja.Items.Add(item);
            }

            this.listServisiranja.Refresh();
        }
        private void btnNezavisnaVozila_Click(object sender, EventArgs e)
        {
            List<ServisiranoVoziloBasic> svb = DTOManager.vratiServisiranaVozila(servisiranja);

            List<NezavisnoVoziloBasic> nvb = svb.Where(x => x.NezavisnoVozilo != null)
                                                .Select(x => x.NezavisnoVozilo).ToList();
            ServisiranaNezavisnaVozilaForm forma = new ServisiranaNezavisnaVozilaForm(nvb);
            forma.ShowDialog();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            List<ServisiranoVoziloBasic> svb = DTOManager.vratiServisiranaVozila(servisiranja);

            List<VoziloBasic> vb = svb.Where(x => x.Vozilo != null)
                                                .Select(x => x.Vozilo).ToList();

            ServisiranaVozilaForm forma = new ServisiranaVozilaForm(vb);
            forma.ShowDialog();
        }
    }
}
