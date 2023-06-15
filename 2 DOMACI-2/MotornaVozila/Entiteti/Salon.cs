using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Salon : MestoZaposljenja
    {
        public virtual IList<Vozilo> Vozila { get; set; }
        public virtual IList<Prodaja> Prodaje { get; set; }
        public virtual Predstavnistvo PredstavnistvoSalona { get; set; }
        public virtual Nadredjeni SefSalona { get; set; }
        public Salon() 
        {
            Vozila = new List<Vozilo>();
            Prodaje = new List<Prodaja>();
        }
    }
}
