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
    public partial class OvlasceniServisForma : Form
    {
        public OvlasceniServisBasic servis;
        public OvlasceniServisForma()
        {
            InitializeComponent();
        }
        public OvlasceniServisForma(OvlasceniServisBasic servis)
        {
            InitializeComponent();
            this.servis = servis;
        }

        private void OvlasceniServisForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            List<ZaposleniPregled> listaZaposlenih = DTOManager.vratiSveZaposleneMesZap(servis);

            string imeIPrezime = DTOManager.vratiImeIPrezimeSefa(servis);
            string imeServisa = DTOManager.vratiImeServisa(servis.Id);
            string lokacijaServisa = DTOManager.vratiLokacijuServisa(servis.Id);

            txtImeSefaServisa.Text = imeIPrezime;
            txtLokacijaServisa.Text = lokacijaServisa;
            txtImeServisa.Text = imeServisa;
            chbLimar.Checked = servis.SaLimarskimUslugama;
            chbFarbar.Checked = servis.SaFarbarskimUslugama;
            chbMehanicar.Checked = servis.SaMehanicarskimUslugama;
            chbVulkanizer.Checked = servis.SaVulkanizerskimUslugama;

            this.listSviZaposleniServisa.Items.Clear();

            if (listaZaposlenih == null) return;

            foreach (ZaposleniPregled z in listaZaposlenih)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        z.MatBr.ToString(),
                        z.Ime,
                        z.Prezime,
                        z.Struka,
                        z.Plata.ToString()
                    });
                this.listSviZaposleniServisa.Items.Add(item);
            }

            this.listSviZaposleniServisa.Refresh();
        }

        private void btnServisVisegRanga_Click(object sender, EventArgs e)
        {
            OvlasceniServisBasic servisVisegRanga = DTOManager.vratiServisVisegRanga(servis.Id);

            if(servisVisegRanga == null) return;

            OvlasceniServisForma formaVisegRanga = new OvlasceniServisForma(servisVisegRanga);
            formaVisegRanga.ShowDialog();
        }

        private void btnPrikaziServisiranja_Click(object sender, EventArgs e)
        {
            List<ServisiranjeBasic> servisiranja = DTOManager.vratiServisiranja(servis.Id);

            ServisiranjaForm forma = new ServisiranjaForm(servisiranja);
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzmenaServisaForma forma = new IzmenaServisaForma(servis);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
