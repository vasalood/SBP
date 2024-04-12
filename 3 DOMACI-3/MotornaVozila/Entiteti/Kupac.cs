using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Kupac
    {
        public virtual int Id { get; protected set; }
        public virtual string Broj_Telefona1 { get; set; }
        public virtual string Broj_Telefona2 { get; set; }
        public virtual PravnoLice KupacPravnoLice { get; set; }
        public virtual FizickoLice KupacFizickoLice { get; set; }
        public virtual IList<Prodaja> KupljenaVozila { get; set; }
        public Kupac() 
        {
            KupljenaVozila = new List<Prodaja>();
        }
    }
}
