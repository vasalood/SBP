using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using MotornaVozila.Entiteti;
using FluentNHibernate.Conventions.Helpers;

namespace MotornaVozila.Mapiranja
{
    public class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("\"ZAPOSLENI\"");

            Id(x => x.MaticniBroj, "\"Maticni_Broj\"").GeneratedBy.Assigned();
            DiscriminateSubClassesOnColumn("\"Tip_Pozicije\"");

            Map(x => x.Plata, "\"Plata\"");
            Map(x => x.LicnoIme, "\"Licno_Ime\"");
            Map(x => x.Prezime, "\"Prezime\"");
            Map(x => x.DatumRodjenja, "\"Datum_Rodjenja\"");
            Map(x => x.DatumZaposlenja, "\"Datum_Zaposlenja\"");
            Map(x => x.GodineRadnogStaza, "\"Godine_Radnog_Staza\"");
            Map(x => x.Struka, "\"Struka\"");
            Map(x => x.DatumSticanjaSpecijalnosti, "\"Dat_Sticanja_Spec\"");
            Map(x => x.NazivSpecijalnosti, "\"Naziv_Spec\"");
            Map(x => x.InstitucijaSticanjaSpecijalnosti, "\"Inst_Stic_Spec\"");
            Map(x => x.PosedujeSertifikat, "\"Poseduje_Sertifikat\"");
            Map(x => x.DatumVazenjaSertifikata, "\"Datum_Vazenja_Sertifikata\"");

            References(x => x.RukovodilacZaposlenog, "\"Mat_Br_Rukovodioca\"").LazyLoad();
        }
    }
    public class NadredjeniMapiranja : SubclassMap<Nadredjeni>
    {
        public NadredjeniMapiranja()
        {
            DiscriminatorValue("Nadredjeni");
            Map(x => x.Rukovodilac, "\"Rukovodilac\"");
            Map(x => x.Direktor, "\"Direktor\"");
            Map(x => x.Sef, "\"Sef\"");

            HasMany(x => x.RukovodiZaposlenima).KeyColumn("\"Mat_Br_Rukovodioca\"").Cascade.All().Inverse();
            //HasOne(x => x.JeDirektorPredstavnistva).PropertyRef(x => x.Direktor).Cascade.All().LazyLoad();
            //HasOne(x => x.JeSefSalona).PropertyRef(x => x.SefSalona).Cascade.All().LazyLoad();
            //HasOne(x => x.JeSefServisa).PropertyRef(x => x.SefServisa).Cascade.All().LazyLoad();
        }
    }
    public class PodredjeniMapiranja : SubclassMap<Podredjeni>
    {
        public PodredjeniMapiranja()
        {
            DiscriminatorValue("Podredjeni");

            Map(x => x.DugorocnostZaposlenja, "\"Dugorocnost_Zaposlenja\"");
            Map(x => x.DatumIstekaUgovora, "\"Datum_Isteka_Ugovora\"");

            References(x => x.RadiUServisu, "\"Id_Ovlascenog_Servisa\"").LazyLoad();
            References(x => x.RadiUSalonu, "\"Id_Salona\"").LazyLoad();
            HasMany(x => x.Prodaje).KeyColumn("\"Mat_Br_Prodavca\"").Cascade.All().Inverse();
            HasMany(x => x.UvezenaVozila).KeyColumn("\"Mat_Br_Tehnicara\"").Cascade.All().Inverse();
            HasMany(x => x.PrimioVoziloNaServis).KeyColumn("\"Maticni_Broj_Primaoca\"").Cascade.All().Inverse();
        }
    }
}
