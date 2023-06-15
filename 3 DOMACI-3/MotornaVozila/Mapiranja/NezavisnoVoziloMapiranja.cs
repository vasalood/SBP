using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class NezavisnoVoziloMapiranja : ClassMap<NezavisnoVozilo>
    {
        public NezavisnoVoziloMapiranja() 
        {
            Table("\"VOZILO_KUPLJENO_NEZAVISNO\"");

            Id(x => x.Vin, "\"Vin\"").GeneratedBy.Assigned();

            Map(x => x.ImeKupca, "\"Ime_Kupca\"");
            Map(x => x.PrezimeKupca, "\"Prezime_Kupca\"");
            Map(x => x.BrojTelefona, "\"Broj_Telefona\"");
            Map(x => x.Model, "\"Model\"");

            References(x => x.NezavisnoVoziloZaServis, "\"ID_Servisiranog_Vozila\"").LazyLoad();
        }
    }
}