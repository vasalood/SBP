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
    public partial class FormaSalon : Form
    {
        private SalonBasic salon;
        public FormaSalon()
        {
            InitializeComponent();
        }
        public FormaSalon(SalonBasic salon)
        {
            InitializeComponent();
            this.salon = salon;
        }
        private void FormaSalon_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            List<ZaposleniPregled> listaZaposlenih = DTOManager.vratiSveZaposleneMesZap(salon);

            string imeIPrezime = DTOManager.vratiImeIPrezimeSefa(salon);
            string imeSalona = DTOManager.vratiImeSalona(salon.Id);
            string lokacijaSalona = DTOManager.vratiLokacijuSalona(salon.Id);

            txtImeSefaSalona.Text = imeIPrezime;
            txtLokacijaSalona.Text = lokacijaSalona;//salon.Lokacija;
            txtImeSalona.Text = imeSalona;//salon.Ime;

            this.listSviZaposleniSalona.Items.Clear();

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
                this.listSviZaposleniSalona.Items.Add(item);
            }

            this.listSviZaposleniSalona.Refresh();
        }

        private void btnIzlozenaVozila_Click(object sender, EventArgs e)
        {
            //List<VoziloBasic> vozila = DTOManager.vratiIzlozenaVozila(salon.Id);

            //IzlozenaVozilaForma forma = new IzlozenaVozilaForma(vozila);
            IzlozenaVozilaForma forma = new IzlozenaVozilaForma(salon.Id);

            forma.ShowDialog();
        }

        private void btnProdataVozila_Click(object sender, EventArgs e)
        {
            //List<ProdajaBasic> prodaje = DTOManager.vratiProdaje(salon.Id);

            //ProdajeForm forma = new ProdajeForm(prodaje);
            ProdajeForm forma = new ProdajeForm(salon.Id);

            forma.ShowDialog();
        }

        private void btnIzmenaSalona_Click(object sender, EventArgs e)
        {
            IzmenaSalonaForma forma = new IzmenaSalonaForma(salon);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
