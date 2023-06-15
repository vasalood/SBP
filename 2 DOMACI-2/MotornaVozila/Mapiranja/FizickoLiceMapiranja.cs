using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class FizickoLiceMapiranja : ClassMap<FizickoLice>
    {
        public FizickoLiceMapiranja()
        {
            Table("\"FIZICKO_LICE\"");

            Id(x => x.MaticniBroj, "\"Maticni_Broj\"").GeneratedBy.Assigned();

            Map(x => x.Ime, "\"Ime\"");
            Map(x => x.Prezime, "\"Prezime\"");

            References(x => x.FizickoLiceKupuje, "\"IDK\"").LazyLoad();
        }
    }
}
