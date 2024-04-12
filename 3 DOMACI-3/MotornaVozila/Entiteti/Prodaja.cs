using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Prodaja
    {
        public virtual int Id { get; protected set; }
        public virtual DateTime DatumKupovine { get; set; }
        public virtual int Cena { get; set; }
        public virtual Vozilo ProdatoVozilo { get; set; }
        public virtual Salon SalonProdaje { get; set; }
        public virtual Podredjeni Prodavac { get; set; }
        public virtual Kupac KupacVozila { get; set; }
        public Prodaja()
        {
        }
    }
}
