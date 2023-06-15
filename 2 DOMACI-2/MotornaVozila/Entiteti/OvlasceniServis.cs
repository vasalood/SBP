using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotornaVozila.Entiteti
{
    public class OvlasceniServis : MestoZaposljenja
    {
        public virtual string StepenOpremljenosti { get; set; }
        public virtual bool SaMehanicarskimUslugama { get; set; }
        public virtual bool SaLimarskimUslugama { get; set; }
        public virtual bool SaFarbarskimUslugama { get; set; }
        public virtual bool SaVulkanizerskimUslugama { get; set; }
        public virtual Predstavnistvo PredstavnistvoServisa { get; set; }
        public virtual IList<Servisiranje> Servisiranja { get; set; }
        public virtual OvlasceniServis ServisVisegRanga { get; set; }
        public virtual IList<OvlasceniServis> ServisiNizegRanga { get; set; }
        public virtual Nadredjeni SefServisa { get; set; }
        public OvlasceniServis()
        {
            Servisiranja = new List<Servisiranje>();
            ServisiNizegRanga = new List<OvlasceniServis>();
        }    
    }
}
