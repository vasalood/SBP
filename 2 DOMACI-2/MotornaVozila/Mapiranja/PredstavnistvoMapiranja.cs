using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class PredstavnistvoMapiranja : ClassMap<Predstavnistvo>
    {
        public PredstavnistvoMapiranja()
        {
            Table("\"PREDSTAVNISTVO\"");

            Id(x => x.Id, "\"Id\"").GeneratedBy.TriggerIdentity();

            Map(x => x.Grad, "\"Grad\"");
            Map(x => x.AdresaPredstavnistva, "\"Adresa_Predstavnistva\"");

            References(x => x.Direktor, "\"Maticni_Broj_Direktora\"").LazyLoad();
            HasOne(x => x.Salon).PropertyRef(x => x.PredstavnistvoSalona);
            HasOne(x => x.Servis).PropertyRef(x => x.PredstavnistvoServisa);
        }
    }
}
