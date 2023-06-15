using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotornaVozila.Entiteti;
using FluentNHibernate.Mapping;

namespace MotornaVozila.Mapiranja
{
    public class MestoZaposljenjaMapiranja : ClassMap<MestoZaposljenja>
    {
        public MestoZaposljenjaMapiranja() 
        {
            UseUnionSubclassForInheritanceMapping();

            Id(x => x.Id).Column("\"Id\"").GeneratedBy.TriggerIdentity();
            Map(x => x.Lokacija, "\"Lokacija\"");
            Map(x => x.Ime, "\"Ime\"");
        }
    }
}
