using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class VoziloMapiranja : ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {
            Table("\"VOZILO\"");

            Id(x => x.Id, "\"Id\"").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojSasije, "\"Broj_Sasije\"");
            Map(x => x.BrojMotora, "\"Broj_Motora\"");
            Map(x => x.Kubikaza, "\"Kubikaza\"");
            Map(x => x.TipGoriva, "\"Tip_goriva\"");
            Map(x => x.Model, "\"Model\"");
            Map(x => x.Boja, "\"Boja\"");
            Map(x => x.Putnicko, "\"VPutnicko\"");
            Map(x => x.BrojPutnika, "\"Broj_putnika\"");
            Map(x => x.Teretno, "\"VTeretno\"");
            Map(x => x.Nosivost, "\"Nosivost\"");
            Map(x => x.TeretniProstor, "\"Teretni_prostor\"");
            Map(x => x.DatumUvoza, "\"Datum_Uvoza\"");

            References(x => x.Salon).Column("\"Id_Salona\"").LazyLoad();
            //HasOne(x => x.Prodaja).PropertyRef(x => x.ProdatoVozilo);
            References(x => x.VoziloZaServis).Column("\"Id_Servisiranog_Vozila\"").LazyLoad();
            References(x => x.TehnickoLice).Column("\"Mat_Br_Tehnicara\"").LazyLoad();
        }
    }
}
