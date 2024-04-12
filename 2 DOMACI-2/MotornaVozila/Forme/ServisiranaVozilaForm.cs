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
    public partial class ServisiranaVozilaForm : Form
    {
        public List<VoziloBasic> vozila;
        public ServisiranaVozilaForm()
        {
            InitializeComponent();
        }
        public ServisiranaVozilaForm(List<VoziloBasic> vozila)
        {
            InitializeComponent();
            this.vozila = vozila;
        }

        private void ServisiranaVozilaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.listVozila.Items.Clear();

            foreach (VoziloBasic v in vozila)
            {
                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        v.BrojMotora,
                        v.BrojSasije,
                        v.Kubikaza.ToString(),
                        v.Model,
                        v.Boja
                    });

                this.listVozila.Items.Add(item);
            }

            this.listVozila.Refresh();
        }
    }
}
