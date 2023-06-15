using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class PravnoLice
    {
        public virtual long PIB { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual Kupac PravnoLiceKupuje { get; set; }
        public PravnoLice()
        {
        }
    }
}
