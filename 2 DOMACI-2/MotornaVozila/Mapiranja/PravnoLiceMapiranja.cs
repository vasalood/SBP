using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class PravnoLiceMapiranja : ClassMap<PravnoLice>
    {
        public PravnoLiceMapiranja()
        {
            Table("\"PRAVNO_LICE\"");

            Id(x => x.PIB, "\"PIB\"").GeneratedBy.Assigned();

            Map(x => x.Ime, "\"Ime\"");
            Map(x => x.Prezime, "\"Prezime\"");

            References(x => x.PravnoLiceKupuje, "\"IDK\"").LazyLoad();
        }
    }
}
