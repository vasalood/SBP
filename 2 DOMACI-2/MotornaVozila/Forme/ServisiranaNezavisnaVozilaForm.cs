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
    public partial class ServisiranaNezavisnaVozilaForm : Form
    {
        List<NezavisnoVoziloBasic> nezavisnaVozila;
        public ServisiranaNezavisnaVozilaForm()
        {
            InitializeComponent();
        }
        public ServisiranaNezavisnaVozilaForm(List<NezavisnoVoziloBasic> nezavisnaVozila)
        {
            InitializeComponent();
            this.nezavisnaVozila = nezavisnaVozila;
        }

        private void ServisiranaNezavisnaVozilaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.listNezavisnaVozila.Items.Clear();

            foreach (NezavisnoVoziloBasic v in nezavisnaVozila)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        v.ImeKupca,
                        v.PrezimeKupca,
                        v.BrojTelefona,
                        v.Model,
                        v.Vin.ToString()
                    });

                this.listNezavisnaVozila.Items.Add(item);
            }

            this.listNezavisnaVozila.Refresh();
        }

        private void btnObrisiNezavisnoVozilo_Click(object sender, EventArgs e)
        {
            if (listNezavisnaVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje zelite da obrisete!");
                return;
            }

            int vin = Int32.Parse(listNezavisnaVozila.SelectedItems[0].SubItems[4].Text);
            string poruka = "Da li zelite da obrisete izabrano vozilo?";
            string title = "Warning";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiNezVozilo(vin);
                MessageBox.Show("Brisanje vozila je uspesno obavljeno!");

                NezavisnoVoziloBasic nzb = null;

                foreach(NezavisnoVoziloBasic n in nezavisnaVozila)
                {
                    if(n.Vin == vin)
                    {
                        nzb = n; break;
                    }
                }

                if (nzb != null) { nezavisnaVozila.Remove(nzb); }

                this.popuniPodacima();
            }
        }
    }
}
