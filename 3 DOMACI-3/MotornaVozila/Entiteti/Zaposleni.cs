using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MotornaVozila.Entiteti
{
    public abstract class Zaposleni
    {
        public virtual long MaticniBroj { get; set; }
        public virtual int Plata { get; set; }
        public virtual string LicnoIme { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
        public virtual int GodineRadnogStaza { get; set; }
        public virtual string Struka { get; set; }
        public virtual DateTime DatumSticanjaSpecijalnosti { get; set; }
        public virtual string NazivSpecijalnosti { get; set; }
        public virtual string InstitucijaSticanjaSpecijalnosti { get; set; }
        public virtual int PosedujeSertifikat { get; set; }
        public virtual DateTime DatumVazenjaSertifikata { get; set; }
        public virtual Nadredjeni RukovodilacZaposlenog { get; set; }
        public Zaposleni()
        {
        }
    }
    public class Nadredjeni : Zaposleni
    {
        public virtual bool Rukovodilac { get; set; }
        public virtual bool Direktor { get; set; }
        public virtual bool Sef { get; set; }
        public virtual IList<Zaposleni> RukovodiZaposlenima { get; set; }
        public virtual Predstavnistvo JeDirektorPredstavnistva { get; set; }
        public virtual Salon JeSefSalona { get; set; }
        public virtual OvlasceniServis JeSefServisa { get; set; }
        public Nadredjeni() 
        {
            RukovodiZaposlenima = new List<Zaposleni>();
        }
    }
    public class Podredjeni : Zaposleni
    {
        public virtual string DugorocnostZaposlenja { get; set; }
        public virtual DateTime DatumIstekaUgovora { get; set; }
        public virtual OvlasceniServis RadiUServisu { get; set; }
        public virtual Salon RadiUSalonu { get; set; }
        public virtual IList<Prodaja> Prodaje { get; set; }
        public virtual IList<Vozilo> UvezenaVozila { get; set; }
        public virtual IList<Servisiranje> PrimioVoziloNaServis { get; set; }
        public Podredjeni() 
        {
            Prodaje = new List<Prodaja>();
            UvezenaVozila = new List<Vozilo>();
            PrimioVoziloNaServis = new List<Servisiranje>();
        }
    }
}
