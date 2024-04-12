using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class ServisiranjeMapiranja : ClassMap<Servisiranje>
    { 
        public ServisiranjeMapiranja() 
        {
            Table("\"SERVISIRANJE\"");

            Id(x => x.Id, "\"Id\"").GeneratedBy.TriggerIdentity();

            Map(x => x.PFR, "\"PFR_Br_Racuna\"");
            Map(x => x.DatumZavrsetka, "\"Datum_Zavrsetka\"");
            Map(x => x.DatumPrijema, "\"Datum_Prijema\"");
            Map(x => x.OpisProblema, "\"Opis_Problema\"");

            References(x => x.OvlasceniServis).Column("\"Id_Servisa\"").LazyLoad();
            References(x => x.ServisiranoVozilo, "\"Id_Servisiranog_Vozila\"").LazyLoad();
            References(x => x.Primalac, "\"Maticni_Broj_Primaoca\"").LazyLoad();
        }
    }
}
