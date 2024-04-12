using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Predstavnistvo
    {
        public virtual int Id { get; protected set; }
        public virtual string Grad { get; set; }
        public virtual string AdresaPredstavnistva { get; set; }
        public virtual Nadredjeni Direktor { get; set; }
        public virtual Salon Salon { get; set; }
        public virtual OvlasceniServis Servis { get; set; }
        public Predstavnistvo()
        {
        }
    }
}
