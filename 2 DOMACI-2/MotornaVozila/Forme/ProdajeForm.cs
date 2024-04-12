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
    public partial class ProdajeForm : Form
    {
        //List<ProdajaBasic> prodaje;
        public int idSalona;
        public ProdajeForm()
        {
            InitializeComponent();
        }
        public ProdajeForm(/*List<ProdajaBasic> prodaje*/int id)
        {
            InitializeComponent();
            //this.prodaje = prodaje;
            this.idSalona = id;
        }

        private void ProdajeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.listaProdaja.Items.Clear();
            string lice = "";
            string imeIPrezime = "";
            List<ProdajaBasic> prodaje = DTOManager.vratiProdaje(idSalona);
            foreach (ProdajaBasic pb in prodaje)
            {
                if(pb.KupacVozila.KupacPravnoLice == null) 
                { 
                    lice = "Fizicko";
                    imeIPrezime = pb.KupacVozila.KupacFizickoLice.Ime + " " + pb.KupacVozila.KupacFizickoLice.Prezime;
                }
                else if(pb.KupacVozila.KupacFizickoLice == null) 
                { 
                    lice = "Pravno";
                    imeIPrezime = pb.KupacVozila.KupacPravnoLice.Ime + " " + pb.KupacVozila.KupacPravnoLice.Prezime;
                }

                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        pb.DatumKupovine.ToShortDateString(),
                        pb.ProdatoVozilo.Model,
                        pb.Cena.ToString(),
                        imeIPrezime,
                        lice,
                        pb.Prodavac.LicnoIme + " " + pb.Prodavac.Prezime,
                        pb.Id.ToString()
                    });

                this.listaProdaja.Items.Add(item);
            }

            this.listaProdaja.Refresh();
        }

        private void btnObrisiProdaju_Click(object sender, EventArgs e)
        {
            if (listaProdaja.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodaju koju zelite da obrisete!");
                return;
            }

            int idProdaje = Int32.Parse(listaProdaja.SelectedItems[0].SubItems[6].Text);
            DialogResult result = MessageBox.Show("Da li zelite da obrisete izabranu prodaju?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiProdaju(idProdaje);
                MessageBox.Show("Brisanje prodaje je uspesno obavljeno!");

                /*ProdajaBasic zaBrisanje = null;

                foreach(ProdajaBasic pb in prodaje)
                {
                    if(pb.Id == idProdaje)
                    {
                        zaBrisanje = pb;
                    }
                }

                if( zaBrisanje != null )
                {
                    prodaje.Remove(zaBrisanje);
                }*/

                this.popuniPodacima();
            }
        }

        private void btnProdaja_Click(object sender, EventArgs e)
        {
            ObaviProdajuForm forma = new ObaviProdajuForm(idSalona);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}
