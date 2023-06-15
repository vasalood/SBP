using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class ProdajaMapiranja : ClassMap<Prodaja>
    {
        public ProdajaMapiranja()
        {
            Table("\"PRODAJA\"");

            Id(x => x.Id, "\"Id\"").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumKupovine, "\"Datum_Kupovine\"");
            Map(x => x.Cena, "\"Cena\"");

            References(x => x.ProdatoVozilo).Column("\"Id_Vozila\"").LazyLoad();
            References(x => x.SalonProdaje).Column("\"IdS\"").LazyLoad();
            References(x => x.Prodavac).Column("\"Mat_Br_Prodavca\"").LazyLoad();
            References(x => x.KupacVozila).Column("\"IDK\"").LazyLoad();
        }
    }
}
