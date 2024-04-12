using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class FizickoLice
    {
        public virtual long MaticniBroj { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual Kupac FizickoLiceKupuje { get; set; }
        public FizickoLice()
        {
        }
    }
}
