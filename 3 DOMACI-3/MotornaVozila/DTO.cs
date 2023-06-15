using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotornaVozila.Entiteti;
using Oracle.ManagedDataAccess.Types;

namespace MotornaVozila
{
    #region SviZaposleni

    public class ZaposleniPregled
    {
        public long MatBr;
        public string Ime;
        public string Prezime;
        public DateTime DatumRodjenja;
        public DateTime DatumZaposlenja;
        public int Plata;
        public bool Sef;
        public bool Rukovodilac;
        public bool Direktor;
        public string Struka;
        public int GodineRadnogStaza;
        public DateTime DatumSticanjaSpecijalnosti;
        public string NazivSpecijalnosti;
        public string InstitucijaSticanjaSpecijalnosti;
        public int PosedujeSertifikat;
        public DateTime DatumVazenjaSertifikata;
        public ZaposleniPregled() { }
        public ZaposleniPregled(long mbr, string ime, 
            string prezime, DateTime datRodj, DateTime datZap, int plata, bool sef, bool rukovodilac, bool direktor)
        {
            MatBr = mbr;
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datRodj;
            DatumZaposlenja = datZap;
            Plata = plata;
            Sef = sef;
            Rukovodilac = rukovodilac;
            Direktor = direktor;
        }
        public ZaposleniPregled(long mbr, string ime, string prezime, string struka, int plata) 
        {
            MatBr = mbr;
            Ime = ime;
            Prezime = prezime;
            this.Struka = struka;
            this.Plata = plata;
        }
    }
    public class ZaposleniDTO
    {
        public long MatBr { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public int Plata { get; set; }
        public string Struka { get; set; }
        public int GodineRadnogStaza { get; set; }
        public DateTime? DatumSticanjaSpecijalnosti { get; set; }
        public string? NazivSpecijalnosti { get; set; }
        public string? InstitucijaSticanjaSpecijalnosti { get; set; }
        public int? PosedujeSertifikat { get; set; }
        public DateTime? DatumVazenjaSertifikata { get; set; }
    }

    public class ZaposleniBasic
    {
        public  long MaticniBroj ;
        public  int Plata ;
        public  string LicnoIme ;
        public  string Prezime ;
        public  DateTime DatumRodjenja ;
        public  DateTime DatumZaposlenja ;
        public  int GodineRadnogStaza ;
        public  string Struka ;
        public  DateTime? DatumSticanjaSpecijalnosti ;
        public  string? NazivSpecijalnosti ;
        public  string? InstitucijaSticanjaSpecijalnosti ;
        public  int? PosedujeSertifikat ;
        public  DateTime? DatumVazenjaSertifikata ;
        public  NadredjeniBasic RukovodilacZaposlenog ;
        public ZaposleniBasic() { }
        public ZaposleniBasic(long maticniBroj, int plata, string licnoIme, string prezime, DateTime datumRodjenja, DateTime datumZaposlenja, int godineRadnogStaza, string struka, DateTime datumSticanjaSpecijalnosti, string nazivSpecijalnosti, string institucijaSticanjaSpecijalnosti, int posedujeSertifikat, DateTime datumVazenjaSertifikata, NadredjeniBasic rukovodilacZaposlenog)
        {
            MaticniBroj = maticniBroj;
            Plata = plata;
            LicnoIme = licnoIme;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            DatumZaposlenja = datumZaposlenja;
            GodineRadnogStaza = godineRadnogStaza;
            Struka = struka;
            DatumSticanjaSpecijalnosti = datumSticanjaSpecijalnosti;
            NazivSpecijalnosti = nazivSpecijalnosti;
            InstitucijaSticanjaSpecijalnosti = institucijaSticanjaSpecijalnosti;
            PosedujeSertifikat = posedujeSertifikat;
            DatumVazenjaSertifikata = datumVazenjaSertifikata;
            RukovodilacZaposlenog = rukovodilacZaposlenog;
        }
    }

    public class NadredjeniPregled:ZaposleniPregled
    {
        public bool rukovodilac;
        public bool direktor;
        public bool sef;
    }

    public class NadredjeniDTO:ZaposleniDTO
    {
        public bool Rukovodilac { get; set; }
        public bool Direktor { get; set; }
        public bool Sef { get; set; }
    }
    public class NadredjeniBasic : ZaposleniBasic
    {
        public  bool Rukovodilac ;
        public  bool Direktor ;
        public  bool Sef ;
        public  IList<ZaposleniBasic> RukovodiZaposlenima ;
        public PredstavnistvoBasic JeDirektorPredstavnistva ;
        public SalonBasic JeSefSalona ;
        public OvlasceniServisBasic JeSefServisa ;
        public NadredjeniBasic() { }
        public NadredjeniBasic(
            long maticniBroj, int plata, string licnoIme, 
            string prezime, DateTime datumRodjenja, DateTime datumZaposlenja, 
            int godineRadnogStaza, string struka, DateTime datumSticanjaSpecijalnosti, 
            string nazivSpecijalnosti, string institucijaSticanjaSpecijalnosti, 
            int posedujeSertifikat, DateTime datumVazenjaSertifikata, NadredjeniBasic 
            rukovodilacZaposlenog,
            bool rukovodilac, bool direktor, bool sef, 
            PredstavnistvoBasic jeDirektorPredstavnistva, SalonBasic jeSefSalona, 
            OvlasceniServisBasic jeSefServisa)

        :base(maticniBroj, plata, licnoIme, prezime, datumRodjenja, datumZaposlenja, 
             godineRadnogStaza, struka, datumSticanjaSpecijalnosti, nazivSpecijalnosti,
             institucijaSticanjaSpecijalnosti, posedujeSertifikat, datumVazenjaSertifikata,
             rukovodilacZaposlenog)
        {
            Rukovodilac = rukovodilac;
            Direktor = direktor;
            Sef = sef;
            RukovodiZaposlenima = new List<ZaposleniBasic>();   
            JeDirektorPredstavnistva = jeDirektorPredstavnistva;
            JeSefSalona = jeSefSalona;
            JeSefServisa = jeSefServisa;
        }
    }

    public class PodredjeniPregled:ZaposleniPregled
    {
        public string DugorocnostZaposlenja;
        public DateTime DatumIstekaUgovora;

    }

    public class PodredjeniDTO:ZaposleniDTO
    {
        public string DugorocnostZaposlenja { get; set; }
        public DateTime? DatumIstekaUgovora { get; set; }
    }
    public class PodredjeniBasic : ZaposleniBasic
    {
        public  string DugorocnostZaposlenja ;
        public  DateTime DatumIstekaUgovora ;
        public OvlasceniServisBasic RadiUServisu ;
        public SalonBasic RadiUSalonu ;
        public  IList<ProdajaBasic> Prodaje ;
        public  IList<VoziloBasic> UvezenaVozila ;
        public ServisiranjeBasic primioVoziloNaServis;
        public PodredjeniBasic() { }
        public PodredjeniBasic(
            long maticniBroj, int plata, string licnoIme,
            string prezime, DateTime datumRodjenja, DateTime datumZaposlenja,
            int godineRadnogStaza, string struka, DateTime datumSticanjaSpecijalnosti,
            string nazivSpecijalnosti, string institucijaSticanjaSpecijalnosti,
            int posedujeSertifikat, DateTime datumVazenjaSertifikata, NadredjeniBasic
            rukovodilacZaposlenog,
            string dugorocnostZaposlenja, DateTime datumIstekaUgovora, 
            OvlasceniServisBasic radiUServisu, SalonBasic radiUSalonu)

        :base(maticniBroj, plata, licnoIme, prezime, datumRodjenja, datumZaposlenja,
             godineRadnogStaza, struka, datumSticanjaSpecijalnosti, nazivSpecijalnosti,
             institucijaSticanjaSpecijalnosti, posedujeSertifikat, datumVazenjaSertifikata,
             rukovodilacZaposlenog)
        {
            DugorocnostZaposlenja = dugorocnostZaposlenja;
            DatumIstekaUgovora = datumIstekaUgovora;
            RadiUServisu = radiUServisu;
            RadiUSalonu = radiUSalonu;
            Prodaje = new List<ProdajaBasic>();
            UvezenaVozila = new List<VoziloBasic>();
        }
    }
    
    #endregion SviZaposleni

    #region SvaVozila
    public class VoziloPregled
    {
        public int id;
        public string brSasije;
        public string brMotora;
        public string model;
        public float kubikaza;
        public bool putnicko;
        public bool teretno;
        public string boja;
        public string motor;
        public string gorivo;
        public VoziloPregled() { }
        public VoziloPregled(int id, string brSasije, 
            string brMotora, string model, 
            float kubikaza, bool putnicko, 
            bool teretno, string boja)
        {
            this.id = id;
            this.brSasije = brSasije;
            this.brMotora = brMotora;
            this.model = model;
            this.kubikaza = kubikaza;
            this.putnicko = putnicko;
            this.teretno = teretno;
            this.boja = boja;
        }
    }

    public class VoziloDTO
    {
        public string Boja { get; set; }
        public string Gorivo { get; set; }
        public float Kubikaza { get; set; }
        public string Model { get; set; }
        public string BrojMotora { get; set; }
        public string BrojSasije { get; set; }
        public bool Putnicko { get; set; }
        public bool Teretno { get; set; }
        public int IdSalona { get; set; }
    }
    public class VoziloBasic
    {
        public int Id;
        public string BrojSasije;
        public string BrojMotora;
        public float Kubikaza;
        public string TipGoriva;
        public string Model;
        public string Boja;
        public bool Putnicko;
        public int BrojPutnika;
        public bool Teretno;
        public int Nosivost;
        public string TeretniProstor;
        public DateTime DatumUvoza;
        public SalonBasic Salon;
        public ProdajaBasic Prodaja;
        public ServisiranoVoziloBasic VoziloZaServis;
        public PodredjeniBasic TehnickoLice;

        public VoziloBasic() { }
        public VoziloBasic(int id, string brojSasije, string brojMotora, float kubikaza, string tipGoriva, string model, string boja, bool putnicko, int brojPutnika, bool teretno, int nosivost, string teretniProstor, DateTime datumUvoza, SalonBasic salon, ProdajaBasic prodaja, ServisiranoVoziloBasic voziloZaServis, PodredjeniBasic tehnickoLice)
        {
            Id = id;
            BrojSasije = brojSasije;
            BrojMotora = brojMotora;
            Kubikaza = kubikaza;
            TipGoriva = tipGoriva;
            Model = model;
            Boja = boja;
            Putnicko = putnicko;
            BrojPutnika = brojPutnika;
            Teretno = teretno;
            Nosivost = nosivost;
            TeretniProstor = teretniProstor;
            DatumUvoza = datumUvoza;
            Salon = salon;
            Prodaja = prodaja;
            VoziloZaServis = voziloZaServis;
            TehnickoLice = tehnickoLice;
        }
    }
    #endregion SvaVozila

    #region NezavisnaVozila
    public class NezavisnoVoziloPregled
    {

    }
    public class NezavisnoVoziloBasic
    {
        public int Vin;
        public string ImeKupca;
        public string PrezimeKupca;
        public string BrojTelefona;
        public string Model;
        public ServisiranoVoziloBasic NezavisnoVoziloZaServis;
        public NezavisnoVoziloBasic() { }
        public NezavisnoVoziloBasic(int vin, string imeKupca, string prezimeKupca, string brojTelefona, string model, ServisiranoVoziloBasic nezavisnoVoziloZaServis)
        {
            Vin = vin;
            ImeKupca = imeKupca;
            PrezimeKupca = prezimeKupca;
            BrojTelefona = brojTelefona;
            Model = model;
            NezavisnoVoziloZaServis = nezavisnoVoziloZaServis;
        }
    }
    #endregion NezavisnaVozila

    #region ServisiranaVozila
    public class ServisiranoVoziloPregled
    {

    }
    public class ServisiranoVoziloBasic
    {
        public  int Id;
        public  string RegistarskiBroj ;
        public  int GodinaProizvodnje ;
        public  VoziloBasic Vozilo ;
        public  NezavisnoVoziloBasic NezavisnoVozilo ;
        public  IList<ServisiranjeBasic> Servisiranja ;
        public ServisiranoVoziloBasic() { }
        public ServisiranoVoziloBasic(int id, string registarskiBroj, int godinaProizvodnje/*, VoziloBasic vozilo, NezavisnoVoziloBasic nezavisnoVozilo*/)
        {
            Id = id;
            RegistarskiBroj = registarskiBroj;
            GodinaProizvodnje = godinaProizvodnje;
            //Vozilo = vozilo;
            //NezavisnoVozilo = nezavisnoVozilo;
            Servisiranja = new List<ServisiranjeBasic>();
        }
    }
    #endregion ServisiranaVozila

    #region Servisiranja 
    public class ServisiranjePregled
    {
        public string PFR;
        public string datumZavrsetka;
        public string opis;
        public string regVozila;
        public string ImeiPrezime;
        public string datumPrijema;
        
        public ServisiranjePregled(string PFR, string datumPrijema, string datumZavrsetka, string opis, string regVozila, string imeiprezime) 
        {
            this.PFR = PFR;
            this.datumPrijema = datumPrijema;
            this.datumZavrsetka = datumZavrsetka;
            this.opis = opis;
            this.regVozila = regVozila;
            ImeiPrezime = imeiprezime;
        }
    }
    public class ServisiranjeBasic
    {
        public  int Id;
        public  string PFR ;
        public  DateTime DatumZavrsetka ;
        public  DateTime DatumPrijema ;
        public  string OpisProblema ;
        public  OvlasceniServisBasic OvlasceniServis;
        public  ServisiranoVoziloBasic ServisiranoVozilo;
        public PodredjeniBasic Primalac;
        public ServisiranjeBasic() { }
        public ServisiranjeBasic(int id, string pFR, DateTime datumZavrsetka, DateTime datumPrijema, string opisProblema/*, OvlasceniServisBasic ovlasceniServis, ServisiranoVoziloBasic servisiranoVozilo*/)
        {
            Id = id;
            PFR = pFR;
            DatumZavrsetka = datumZavrsetka;
            DatumPrijema = datumPrijema;
            OpisProblema = opisProblema;
            //OvlasceniServis = ovlasceniServis;
            //ServisiranoVozilo = servisiranoVozilo;
        }
    }
    #endregion Servisiranja

    #region SvaPredstavnistva
    public class PredstavnistvoPregled
    {
        public int id;
        public string grad;
        public string adresa;
        public string imeDirektora;
        public string prezimeDirektora;
        public PredstavnistvoPregled() { }
        public PredstavnistvoPregled(int id, string grad, string adresa, string imedirektor, string prezimedirektor)
        {
            this.id = id;
            this.grad = grad;
            this.adresa = adresa;
            this.imeDirektora = imedirektor;
            this.prezimeDirektora = prezimedirektor;
        }
    }

    public class PredstavnistvoDTO
    {
        public string Grad { get; set; }
        public string Adresa { get; set; }
    }
    public class PredstavnistvoBasic
    {
        public  int Id;
        public  string Grad ;
        public  string AdresaPredstavnistva ;
        public  NadredjeniBasic Direktor ;
        public  SalonBasic Salon ;
        public  OvlasceniServisBasic Servis ;
        public PredstavnistvoBasic() { }
        public PredstavnistvoBasic(int id, string grad, string adresaPredstavnistva, NadredjeniBasic direktor, SalonBasic salon, OvlasceniServisBasic servis)
        {
            Id = id;
            Grad = grad;
            AdresaPredstavnistva = adresaPredstavnistva;
            Direktor = direktor;
            Salon = salon;
            Servis = servis;
        }
    }
    #endregion SvaPredstavnistva

    #region MestoZaposljenja
    public class MestoZaposljenjaPregled
    {
    
    }
    public class MestoZaposljenjaBasic
    {
        public int Id;
        public  string Lokacija ;
        public  string Ime ;
        public  IList<PodredjeniBasic> Radnici ;

        public MestoZaposljenjaBasic() { }
        public MestoZaposljenjaBasic(int id, string lokacija, string ime)
        {
            Id = id;
            Lokacija = lokacija;
            Ime = ime;
            Radnici = new List<PodredjeniBasic>();
        }
    }
    #endregion MestoZaposljenja

    #region Saloni
    public class SalonPregled
    {
        public int idPredstavnistva;
        public string imeSalona;
        public string lokacijaSalona;
    }

    public class SalonDTO
    {
        public int PredstavnistvoId { get; set; }
        public string Ime { get; set; }
        public string Lokacija { get; set; }
    }
    public class SalonBasic : MestoZaposljenjaBasic
    {
        public  IList<VoziloBasic> Vozila ;
        public  IList<ProdajaBasic> Prodaje ;
        public  PredstavnistvoBasic PredstavnistvoSalona ;
        public  NadredjeniBasic SefSalona ;
        public SalonBasic() { }

        public SalonBasic(int id, string lokacija, string ime)

        :base(id, lokacija, ime)
        {
            Vozila = new List<VoziloBasic>();
            Prodaje = new List<ProdajaBasic>();
        }
    }
    #endregion Saloni

    #region OvlasceniServis
    public class OvlasceniServisPregled
    {
        public int predstavnistvoId;
        public string ime;
        public string lokacija;
        public bool vulkanizer;
        public bool mehanicar;
        public bool limar;
        public bool farbar;
    }

    public class OvlasceniServisDTO
    {
        public int PredstavnistvoId { get; set; }
        public string Ime { get; set; }
        public string Lokacija { get; set; }
        public bool Vulkanizer { get; set; }
        public bool Mehanicar { get; set; }
        public bool Limar{get;set;}
        public bool Farbar { get; set; }
    }

    public class OvlasceniServisBasic : MestoZaposljenjaBasic
    {
        public  string StepenOpremljenosti ;
        public bool SaMehanicarskimUslugama ;
        public bool SaLimarskimUslugama ;
        public bool SaFarbarskimUslugama ;
        public bool SaVulkanizerskimUslugama ;
        public  PredstavnistvoBasic PredstavnistvoServisa ;
        public  IList<ServisiranjeBasic> Servisiranja ;
        public  OvlasceniServisBasic ServisVisegRanga ;
        public  IList<OvlasceniServisBasic> ServisiNizegRanga ;
        public  NadredjeniBasic SefServisa ;
        public OvlasceniServisBasic() { }
        public OvlasceniServisBasic(
            int id, string lokacija, string ime,
            string stepenOpremljenosti, bool saMehanicarskimUslugama, bool saLimarskimUslugama, bool saFarbarskimUslugama, bool saVulkanizerskimUslugama/*, PredstavnistvoBasic predstavnistvoServisa, OvlasceniServisBasic servisVisegRanga, NadredjeniBasic sefServisa*/)
        
        :base(id, lokacija, ime)
        {
            StepenOpremljenosti = stepenOpremljenosti;
            SaMehanicarskimUslugama = saMehanicarskimUslugama;
            SaLimarskimUslugama = saLimarskimUslugama;
            SaFarbarskimUslugama = saFarbarskimUslugama;
            SaVulkanizerskimUslugama = saVulkanizerskimUslugama;
            //PredstavnistvoServisa = predstavnistvoServisa;
            Servisiranja = new List<ServisiranjeBasic>();
            //ServisVisegRanga = servisVisegRanga;
            ServisiNizegRanga = new List<OvlasceniServisBasic>();
            //SefServisa = sefServisa;
        }
    }
    #endregion OvlasceniServis

    #region Prodaja
    public class ProdajaPregled
    {
        public int cena;
        public DateTime datumKupovine;
        public long matBrKupca;
        public int idSalona;
        public long matBrProdavca;
        public int idVozila;
        public string imeKupca;
        public string prezimeKupca;
    }

    public class ProdajaDTO
    {
        public int Cena { get; set; }
        public DateTime DatumKupovine { get; set; }
        public int? IdKupca { get; set; }
        public long? MatBrKupca { get; set; }
        public long MatBrProdavca { get; set; }
        public int IdVozila { get; set; }
        public string? ImeKupca { get; set; }
        public string? PrezimeKupca { get; set; }
    }
    public class ProdajaBasic
    {
        public int Id;
        public  DateTime DatumKupovine;
        public  int Cena;
        public  VoziloBasic ProdatoVozilo;
        public  SalonBasic SalonProdaje;
        public  PodredjeniBasic Prodavac;
        public  KupacBasic KupacVozila;
        public ProdajaBasic() { }
        public ProdajaBasic(int id, DateTime datumKupovine, int cena/*, VoziloBasic prodatoVozilo, SalonBasic salonProdaje, PodredjeniBasic prodavac, KupacBasic kupacVozila*/)
        {
            Id = id;
            DatumKupovine = datumKupovine;
            Cena = cena;
            /*ProdatoVozilo = prodatoVozilo;
            SalonProdaje = salonProdaje;
            Prodavac = prodavac;
            KupacVozila = kupacVozila;*/
        }
    }
    #endregion Prodaja

    #region Kupac
    public class KupacPregled
    {

    }
    public class KupacBasic
    {
        public  int Id;
        public  string Broj_Telefona1 ;
        public  string Broj_Telefona2 ;
        public  PravnoLiceBasic KupacPravnoLice ;
        public FizickoLiceBasic KupacFizickoLice ;
        public  IList<ProdajaBasic> KupljenaVozila ;
        public KupacBasic() { }
        public KupacBasic(int id, string broj_Telefona1, string broj_Telefona2/*, PravnoLiceBasic kupacPravnoLice, FizickoLiceBasic kupacFizickoLice*/)
        {
            Id = id;
            Broj_Telefona1 = broj_Telefona1;
            Broj_Telefona2 = broj_Telefona2;
            //KupacPravnoLice = kupacPravnoLice;
            //KupacFizickoLice = kupacFizickoLice;
            KupljenaVozila = new List<ProdajaBasic>();
        }
    }

    #endregion Kupac

    #region FizickoLice
    public class FizickoLicePregled
    {

    }
    public class FizickoLiceBasic
    {
        public  long MaticniBroj ;
        public  string Ime ;
        public  string Prezime ;
        public  KupacBasic FizickoLiceKupuje ;
        public FizickoLiceBasic() { }
        public FizickoLiceBasic(long maticniBroj, string ime, string prezime, KupacBasic fizickoLiceKupuje)
        {
            MaticniBroj = maticniBroj;
            Ime = ime;
            Prezime = prezime;
            FizickoLiceKupuje = fizickoLiceKupuje;
        }
    }

    #endregion FizickoLice

    #region PravnoLice
    public class PravnoLicePregled
    {

    }
    public class PravnoLiceBasic
    {
        public  long PIB ;
        public  string Ime ;
        public  string Prezime ;
        public  KupacBasic PravnoLiceKupuje ;
        public PravnoLiceBasic() { }
        public PravnoLiceBasic(long pIB, string ime, string prezime, KupacBasic pravnoLiceKupuje)
        {
            PIB = pIB;
            Ime = ime;
            Prezime = prezime;
            PravnoLiceKupuje = pravnoLiceKupuje;
        }
    }

    #endregion PravnoLice
}