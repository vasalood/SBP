using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class NezavisnoVozilo
    {
        public virtual int Vin { get; set; }
        public virtual string ImeKupca { get; set; }
        public virtual string PrezimeKupca { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string Model { get; set; }
        public virtual ServisiranoVozilo NezavisnoVoziloZaServis { get; set; }
        public NezavisnoVozilo() 
        {
        }
    }
}
