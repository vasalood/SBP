using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class ServisiranoVoziloMapiranja : ClassMap<ServisiranoVozilo>
    {
        public ServisiranoVoziloMapiranja() 
        {
            Table("\"SERVISIRANO_VOZILO\"");

            Id(x =>  x.Id, "\"Id\"").GeneratedBy.TriggerIdentity();

            Map(x => x.RegistarskiBroj, "\"Registarski_broj\"");
            Map(x => x.GodinaProizvodnje, "\"Godina_Proizvodnje\"");

            HasOne(x => x.NezavisnoVozilo).PropertyRef(x => x.NezavisnoVoziloZaServis);
            HasOne(x => x.Vozilo).PropertyRef(x => x.VoziloZaServis);
            HasMany(x => x.Servisiranja).KeyColumn("\"Id_Servisiranog_Vozila\"").Cascade.All().Inverse();
        }
    }
}
