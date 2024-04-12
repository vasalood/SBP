using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class Vozilo
    {
        public virtual int Id { get; protected set; }
        public virtual string BrojSasije { get; set; }
        public virtual string BrojMotora { get; set; }
        public virtual float Kubikaza { get; set; }
        public virtual string TipGoriva { get; set; }
        public virtual string Model { get; set; }
        public virtual string Boja { get; set; }
        public virtual bool Putnicko { get; set; }
        public virtual int BrojPutnika { get; set; }
        public virtual bool Teretno { get; set; }
        public virtual int Nosivost { get; set; }
        public virtual string TeretniProstor { get; set; }
        public virtual DateTime DatumUvoza { get; set; }
        public virtual Salon Salon { get; set; }
        public virtual Prodaja Prodaja { get; set; }
        public virtual ServisiranoVozilo VoziloZaServis { get; set; }
        public virtual Podredjeni TehnickoLice { get; set; }
        public Vozilo()
        {
        }
    }
}
