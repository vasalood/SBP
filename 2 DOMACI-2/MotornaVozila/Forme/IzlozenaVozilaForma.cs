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
    public partial class IzlozenaVozilaForma : Form
    {
        //List<VoziloBasic> vozila;
        public int idSalona;
        public IzlozenaVozilaForma()
        {
            InitializeComponent();
        }
        public IzlozenaVozilaForma(/*List<VoziloBasic> vozila*/int id)
        {
            InitializeComponent();
            //this.vozila = vozila;
            idSalona = id;
        }

        private void IzlozenaVozilaForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.listIzlozenaVozila.Items.Clear();

            List<VoziloBasic> vozila = DTOManager.vratiIzlozenaVozila(/*salon.Id*/idSalona);

            string pom = "";

            foreach (VoziloBasic vb in vozila)
            {
                if(vb.Putnicko && vb.Teretno) { pom = "Pick-Up"; }
                else if(vb.Putnicko) { pom = "Putnicko"; }
                else if (vb.Teretno) { pom = "Teretno"; }

                ListViewItem item = new ListViewItem(
                    new string[]
                    {
                        vb.BrojMotora,
                        vb.BrojSasije,
                        vb.Model,
                        vb.Kubikaza.ToString(),
                        pom
                    });

                this.listIzlozenaVozila.Items.Add(item);
            }

            this.listIzlozenaVozila.Refresh();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            DodajVoziloForma dodajVozilo = new DodajVoziloForma(idSalona);
            dodajVozilo.ShowDialog();
            popuniPodacima();
        }
    }
}
