using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;

namespace MotornaVozila.Mapiranja
{
    public class OvlasceniServisMapiranja : SubclassMap<OvlasceniServis>
    {
        public OvlasceniServisMapiranja()
        {
            Table("\"OVLASCENI_SERVIS\"");

            Abstract();

            Map(x => x.StepenOpremljenosti, "\"Stepen_Opremljenosti\"");
            Map(x => x.SaMehanicarskimUslugama, "\"Sa_Mehanicarskim_Uslugama\"");
            Map(x => x.SaLimarskimUslugama, "\"Sa_Limarskim_Uslugama\"");
            Map(x => x.SaFarbarskimUslugama, "\"Sa_Farbarskim_Uslugama\"");
            Map(x => x.SaVulkanizerskimUslugama, "\"Sa_Vulkanizerskim_Uslugama\"");

            References(x => x.PredstavnistvoServisa).Column("\"ID_Predstavnistva\"").LazyLoad()/*.Unique()*/;
            HasMany(x => x.Servisiranja).KeyColumn("\"Id_Servisa\"").Cascade.All().Inverse();
            References(x => x.ServisVisegRanga).Column("\"ID_Servisa_Viseg_Ranga\"").LazyLoad();
            HasMany(x => x.ServisiNizegRanga).KeyColumn("\"ID_Servisa_Viseg_Ranga\"").Cascade.All().Inverse().LazyLoad();
            References(x => x.SefServisa, "\"Maticni_Broj_Sefa\"").LazyLoad();
            HasMany(x => x.Radnici).KeyColumn("\"Id_Ovlascenog_Servisa\"").Cascade.All().Inverse();
        }
    }
}
