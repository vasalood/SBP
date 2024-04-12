using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class KupacMapiranja : ClassMap<Kupac>
    {
        public KupacMapiranja()
        {
            Table("\"KUPAC\"");

            Id(x => x.Id, "\"IdKupca\"").GeneratedBy.TriggerIdentity();

            Map(x => x.Broj_Telefona1, "\"Broj_Telefona1\"");
            Map(x => x.Broj_Telefona2, "\"Broj_Telefona2\"");

            HasMany(x => x.KupljenaVozila).KeyColumn("\"IDK\"").Cascade.All().Inverse();
            HasOne(x => x.KupacPravnoLice).PropertyRef(x => x.PravnoLiceKupuje);
            HasOne(x => x.KupacFizickoLice).PropertyRef(x => x.FizickoLiceKupuje);
        }
    }
}
