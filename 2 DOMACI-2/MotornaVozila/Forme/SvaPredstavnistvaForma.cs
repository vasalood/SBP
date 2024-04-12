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
    public partial class SvaPredstavnistvaForma : Form
    {
        public SvaPredstavnistvaForma()
        {
            InitializeComponent();
        }

        private void SvaPredstavnistvaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima() 
        {
            List<PredstavnistvoPregled> listaPredstavnistva = DTOManager.vratiSvaPredstavnistva();

            this.listSvaPredstavnistva.Items.Clear();

            if (listaPredstavnistva == null) return;
            
            foreach (PredstavnistvoPregled p in listaPredstavnistva)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        p.id.ToString(),
                        p.grad,
                        p.adresa,
                        p.imeDirektora + " " + p.prezimeDirektora
                    });
                this.listSvaPredstavnistva.Items.Add(item);
            }

            this.listSvaPredstavnistva.Refresh();
        }

        private void btnPrikaziSalon_Click(object sender, EventArgs e)
        {
            if (listSvaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete predstavnistvo!");
                return;
            }

            int id = Int32.Parse(listSvaPredstavnistva.SelectedItems[0].SubItems[0].Text);

            SalonBasic salon = DTOManager.ucitajSalonPredstavnistva(id);
            if (salon == null)
            {
                MessageBox.Show("Izabrano predstavnistvo nema salon.");
                return;
            }

            //nova forma za salon
            FormaSalon forma = new FormaSalon(salon);
            forma.ShowDialog();
        }

        private void btnPrikaziServis_Click(object sender, EventArgs e)
        {
            if (listSvaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete predstavnistvo!");
                return;
            }

            int id = Int32.Parse(listSvaPredstavnistva.SelectedItems[0].SubItems[0].Text);

            OvlasceniServisBasic servis = DTOManager.ucitajServisPredstavnistva(id);
            if (servis == null)
            {
                MessageBox.Show("Izabrano predstavnistvo nema servis.");
                return;
            }
            OvlasceniServisForma forma = new OvlasceniServisForma(servis);
            forma.ShowDialog();
        }

        private void btnDodajSalon_Click(object sender, EventArgs e)
        {
            if (listSvaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete predstavnistvo!");
                return;
            }

            int id = Int32.Parse(listSvaPredstavnistva.SelectedItems[0].SubItems[0].Text);

            if(DTOManager.ucitajSalonPredstavnistva(id) != null)
            {
                MessageBox.Show("Po tekstu zadatka predstavnistvo sme da ima samo jedan salon!");
                return;
            }

            NoviSalonForma forma = new NoviSalonForma(id);
            forma.ShowDialog();
        }

        private void btnDodajServis_Click(object sender, EventArgs e)
        {
            if (listSvaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete predstavnistvo!");
                return;
            }

            int id = Int32.Parse(listSvaPredstavnistva.SelectedItems[0].SubItems[0].Text);

            if (DTOManager.ucitajServisPredstavnistva(id) != null)
            {
                MessageBox.Show("Po tekstu zadatka predstavnistvo sme da ima samo jedan servis!");
                return;
            }

            NoviServisForma forma = new NoviServisForma(id);
            forma.ShowDialog();
        }

        private void btnDodajPredstavnistvo_Click(object sender, EventArgs e)
        {
            DodavanjePredstavnistvaForm forma = new DodavanjePredstavnistvaForm();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void btnIzmeniPredstavnistvo_Click(object sender, EventArgs e)
        {
            if (listSvaPredstavnistva.SelectedItems.Count == 0)
            {
                MessageBox.Show("Morate da izaberete predstavnistvo!");
                return;
            }

            int id = Int32.Parse(listSvaPredstavnistva.SelectedItems[0].SubItems[0].Text);

            IzmenaPredstavnistvaForm forma = new IzmenaPredstavnistvaForm(id);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
