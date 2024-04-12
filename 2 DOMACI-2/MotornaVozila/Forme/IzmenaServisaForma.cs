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
    public partial class IzmenaServisaForma : Form
    {
        public OvlasceniServisBasic sb;
        public IzmenaServisaForma()
        {
            InitializeComponent();
        }
        public IzmenaServisaForma(OvlasceniServisBasic sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        private void IzmenaServisaForma_Load(object sender, EventArgs e)
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

            DTOManager.izmeniServis(sb.Id, Int64.Parse(listSefovi.SelectedItems[0].SubItems[0].Text),
                                        txtIme.Text, txtLokacija.Text);

            this.Close();
        }
    }
}
