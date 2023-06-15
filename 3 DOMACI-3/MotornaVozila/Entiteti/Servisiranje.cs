using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Servisiranje
    {
        public virtual int Id { get; protected set; }
        public virtual string PFR { get; set; }
        public virtual DateTime DatumZavrsetka { get; set; }
        public virtual DateTime DatumPrijema { get; set; }
        public virtual string OpisProblema { get; set; }
        public virtual OvlasceniServis OvlasceniServis { get; set; }
        public virtual ServisiranoVozilo ServisiranoVozilo { get; set; }
        public virtual Podredjeni Primalac { get; set; }
        public Servisiranje()
        {
        }
    }
}
