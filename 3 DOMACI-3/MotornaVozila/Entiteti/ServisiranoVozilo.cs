using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class ServisiranoVozilo
    {
        public virtual int Id { get; protected set; }
        public virtual string RegistarskiBroj { get; set; }
        public virtual int GodinaProizvodnje { get; set; }
        public virtual Vozilo Vozilo { get; set; }
        public virtual NezavisnoVozilo NezavisnoVozilo { get; set; }
        public virtual IList<Servisiranje> Servisiranja { get; set; }
        public ServisiranoVozilo() 
        {
            Servisiranja = new List<Servisiranje>();
        }
    }
}
