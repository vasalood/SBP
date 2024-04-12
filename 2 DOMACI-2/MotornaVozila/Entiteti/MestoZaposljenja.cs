using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public abstract class MestoZaposljenja
    {
        public virtual int Id { get; protected set; }
        public virtual string Lokacija { get; set; }
        public virtual string Ime { get; set; }
        public virtual IList<Podredjeni> Radnici { get; set; }
        public MestoZaposljenja() 
        {
            Radnici = new List<Podredjeni>();
        }
    }
}
