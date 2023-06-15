using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class SalonMapiranja : SubclassMap<Salon>
    {
        public SalonMapiranja() 
        {
            Table("\"SALON\"");

            Abstract();

            HasMany(x => x.Vozila).KeyColumn("\"Id_Salona\"").Cascade.All().Inverse();
            HasMany(x => x.Prodaje).KeyColumn("\"IdS\"").Cascade.All().Inverse();
            References(x => x.PredstavnistvoSalona).Column("\"Id_Predstavnistva\"").LazyLoad();
            References(x => x.SefSalona, "\"Maticni_Broj_Sefa\"").LazyLoad();
            HasMany(x => x.Radnici).KeyColumn("\"Id_Salona\"").Cascade.All().Inverse();
        }
    }
}
