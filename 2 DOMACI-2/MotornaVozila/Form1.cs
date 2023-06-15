using MotornaVozila.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotornaVozila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = new Vozilo
                {
                    BrojSasije = "AAAAAA42HA55784",
                    BrojMotora = "AAAAAA0145300815",
                    Kubikaza = 2,
                    TipGoriva = "Dizel",
                    Model = "AAAAA Fabia",
                    Boja = "AAAAAA siva",
                    Putnicko = true,
                    BrojPutnika = 4,
                    Teretno = false
                };

                Salon salon = s.Get<Salon>(123);
                v.Salon = salon;

                ServisiranoVozilo sv = new ServisiranoVozilo
                {
                    RegistarskiBroj = "PKDDDEE",
                    GodinaProizvodnje = 2004,
                };

                s.SaveOrUpdate(sv);
                s.Flush();
                s.Close();

                ISession s1 = DataLayer.GetSession();
                v.VoziloZaServis = sv;
                Servisiranje servisiranje = new Servisiranje
                {
                    PFR = "2 719 862 444 2",
                    DatumZavrsetka = DateTime.Now,
                    DatumPrijema = DateTime.Now,
                    OpisProblema = "PROBAPROBAPROBA",
                    OvlasceniServis = s1.Get<OvlasceniServis>(80)
                };
                s1.SaveOrUpdate(v);
                s1.Flush(); s1.Close();

                ISession s2 = DataLayer.GetSession();
                servisiranje.ServisiranoVozilo = v.VoziloZaServis;
                s2.SaveOrUpdate(servisiranje);
                s2.Flush(); s2.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btnUcitajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = s.Load<Vozilo>(120);

                MessageBox.Show(v.Model);

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btnDodajPredstavnistvo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = new Predstavnistvo
                {
                    Grad = "Leskovac",
                    AdresaPredstavnistva = "Nikole Tesle 13"
                };

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btnUcitajPredstavnistvo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Load<Predstavnistvo>(3);
                MessageBox.Show(p.AdresaPredstavnistva);

                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btnUcitajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Load<Zaposleni>(1288888436388);
                MessageBox.Show($"{z.LicnoIme} {z.Prezime}");

                if (z.GetType() == typeof(Nadredjeni))
                    MessageBox.Show("Nadredjeni");
                else if (z.GetType() == typeof(Podredjeni))
                    MessageBox.Show("Podredjeni");
                else
                    MessageBox.Show("Bilo sta");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                /*Zaposleni z = new Nadredjeni
                {
                    MaticniBroj = 2234989936668,
                    Plata = 40000,
                    LicnoIme = "Milojko",
                    Prezime = "Pantic",
                    //DatumRodjenja = ,
                    //DatumZaposlenja = ,
                    GodineRadnogStaza = 3,
                    Struka = "Ekonomska struka",
                    //DatumSticanjaSpecijalnosti = ,
                    //NazivSpecijalnosti = ,
                    //InstitucijaSticanjaSpecijalnosti = ,
                    //PosedujeSertifikat = ,
                    //DatumVazenjaSertifikata = ,
                    //TipPozicije = "Podredjeni",
                    Rukovodilac = true,
                    Direktor = false,
                    Sef = false
                };*/

                Podredjeni p = new Podredjeni
                {
                    MaticniBroj = 4444455936668,
                    Plata = 30000,
                    LicnoIme = "Milinko",
                    Prezime = "Pancic",
                    //DatumRodjenja = ,
                    //DatumZaposlenja = ,
                    GodineRadnogStaza = 3,
                    Struka = "Tehnicka struka",
                    //DatumSticanjaSpecijalnosti = ,
                    //NazivSpecijalnosti = ,
                    //InstitucijaSticanjaSpecijalnosti = ,
                    //PosedujeSertifikat = ,
                    //DatumVazenjaSertifikata = ,
                    //TipPozicije = "Podredjeni",
                    /*Rukovodilac = true,
                    Direktor = false,
                    Sef = false*/
                    DugorocnostZaposlenja = "Po ugovoru",
                    DatumIstekaUgovora = DateTime.Now
                };

                Salon salon = s.Get<Salon>(123);

                p.RadiUSalonu = salon;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajServis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OvlasceniServis o = new OvlasceniServis
                {
                    Lokacija = "Pere Perica",
                    Ime = "Servis auto Pere Perica",
                    StepenOpremljenosti = "Dobro opremljen",
                    SaMehanicarskimUslugama = true,
                    SaFarbarskimUslugama = false,
                    SaLimarskimUslugama = false,
                    SaVulkanizerskimUslugama = false
                };

                s.SaveOrUpdate(o);
                s.Flush(); 
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajServis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OvlasceniServis o = s.Load<OvlasceniServis>(0);
                MessageBox.Show($"{o.Ime} {o.Lokacija} {o.StepenOpremljenosti}");

                s.Close();
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            /*try
            {
                ISession s = DataLayer.GetSession();

                Kupac k = new Kupac
                {
                    Broj_Telefona1 = "063-125-4421",
                    Broj_Telefona2 = "061-225-4441"
                };

                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void btnUcitajKupca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kupac k = s.Load<Kupac>(3004);
                MessageBox.Show(k.Broj_Telefona1);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajPravnoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PravnoLice p = new PravnoLice
                {
                    PIB = 6555144452,
                    Ime = "PROBA KAT",
                    Prezime = "KAT PROBA",
                    /*Broj_Telefona1 = "0600000023",
                    Broj_Telefona2 = "065333555"*/
                };

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajPravnoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PravnoLice p = s.Load<PravnoLice>(9558313102);
                MessageBox.Show($"{p.Ime} {p.Prezime}");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajFizickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoLice f = new FizickoLice
                {
                    MaticniBroj = 6395123552234,
                    Ime = "Milosava",
                    Prezime = "Markovic"
                };

                s.SaveOrUpdate(f);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajFizickoLice_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickoLice f = s.Load<FizickoLice>(2005968675191);
                MessageBox.Show($"{f.Ime} {f.Prezime}");

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajProdaju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodaja p = new Prodaja
                {
                    DatumKupovine = DateTime.Now,
                    Cena = 2344,
                    //IdVozila = 102
                };

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajProdaju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodaja p = s.Get<Prodaja>(5020);
                //MessageBox.Show(p.Cena.ToString());

                Podredjeni podredjeni = s.Get<Podredjeni>(803994658751);

                p.Prodavac = podredjeni;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajSalon_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = new Salon
                {
                    Lokacija = "Probna adresa",
                    Ime = "Salon probni"
                };

                s.SaveOrUpdate(salon);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUcitajSalon_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = s.Load<Salon>(9);
                MessageBox.Show($"{salon.Ime} {salon.Lokacija}");
                
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDodajServisiranje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Servisiranje servisiranje = new Servisiranje
                {
                    PFR = "6 555 555 555 4",
                    OpisProblema = "RRRRRRRR SERVISIRANJE"
                };

                ServisiranoVozilo servisiranoVozilo = new ServisiranoVozilo
                {
                    RegistarskiBroj = "AA000AA",
                    GodinaProizvodnje = 1800
                };

                s.SaveOrUpdate(servisiranoVozilo);
                s.Flush();

                //ISession s = DataLayer.GetSession();

                Vozilo vozilo = s.Get<Vozilo>(121);

                //servisiranoVozilo.Vozilo = vozilo;
                vozilo.VoziloZaServis = servisiranoVozilo;

                servisiranje.ServisiranoVozilo = servisiranoVozilo;

                s.SaveOrUpdate(vozilo);
                s.SaveOrUpdate(servisiranje);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUcitajServisiranje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Servisiranje servisiranje = s.Load<Servisiranje>(4);
                MessageBox.Show(servisiranje.PFR);
                MessageBox.Show(servisiranje.OpisProblema);
                
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDodajSerVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ServisiranoVozilo sv = new ServisiranoVozilo
                {
                    RegistarskiBroj = "BG194RR",
                    GodinaProizvodnje = 2003
                };

                s.SaveOrUpdate(sv);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUcitajSerVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ServisiranoVozilo sv = s.Load<ServisiranoVozilo>(1052);
                MessageBox.Show(sv.Vozilo.Id.ToString());
                MessageBox.Show(sv.GodinaProizvodnje.ToString());

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDodajNezavisnoVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NezavisnoVozilo nv = new NezavisnoVozilo
                {
                    Vin = 7777777,
                    ImeKupca = "Svetozar",
                    PrezimeKupca = "Nikolic",
                    BrojTelefona = "061-876-5234",
                    Model = "DACIA Sandero"
                };

                s.SaveOrUpdate(nv);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUcitajNezavisnoVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NezavisnoVozilo sv = s.Load<NezavisnoVozilo>(6734512);
                MessageBox.Show(sv.ImeKupca);
                MessageBox.Show(sv.Model);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnIzloziVozila_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = new Salon
                {
                    Lokacija = "Probna adresa za vezu",
                    Ime = "Salon probni za vezu"
                };

                Vozilo v1 = new Vozilo
                {
                    BrojSasije = "IAUOOW42KK12784",
                    BrojMotora = "343T30435310405",
                    Kubikaza = 3,
                    TipGoriva = "Dizel",
                    Model = "Vezano vozilo",
                    Boja = "Probna boja",
                    Putnicko = true,
                    BrojPutnika = 4,
                    Teretno = false
                };

                Vozilo v2 = new Vozilo
                {
                    BrojSasije = "IAUPPW42QQ12784",
                    BrojMotora = "343T88435344403",
                    Kubikaza = 3,
                    TipGoriva = "Dizel",
                    Model = "Vezano vozilo2",
                    Boja = "Probna boja2",
                    Putnicko = true,
                    BrojPutnika = 4,
                    Teretno = false
                };

                v1.Salon = salon;
                v2.Salon = salon;
                //salon.Vozila.Add(v1);
                //salon.Vozila.Add(v2);

                s.SaveOrUpdate(salon);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnObaviProdaju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                /*Prodaja p = new Prodaja
                {
                    DatumKupovine = DateTime.Now,
                    Cena = 8888,
                };*/

                Prodaja p = s.Get<Prodaja>(5041);

                /*Vozilo v = s.Load<Vozilo>(124);

                p.ProdatoVozilo = v;
                p.SalonProdaje = v.Salon;*/

                Kupac kupac = s.Get<Kupac>(3000);

                p.KupacVozila = kupac;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalonIServis_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = s.Load<Salon>(41);
                //OvlasceniServis ov = s.Load<OvlasceniServis>(40);
                Predstavnistvo p = s.Load<Predstavnistvo>(21);

                salon.PredstavnistvoSalona = p;
                //ov.PredstavnistvoServisa = p;

                s.SaveOrUpdate(salon);
                //s.SaveOrUpdate(ov);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNiziRang_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OvlasceniServis ov = s.Load<OvlasceniServis>(0);
                //OvlasceniServis ov = s.Load<OvlasceniServis>(40);

                foreach(OvlasceniServis servis in ov.ServisiNizegRanga)
                {
                    MessageBox.Show(servis.Ime);
                }
                
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajNadredjenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni milojko = s.Load<Zaposleni>(2234989936668);
                Nadredjeni ana = s.Load<Nadredjeni>(1506975236325);

                milojko.RukovodilacZaposlenog = ana;
                //ana.RukovodiZaposlenima.Add(milojko);

                //s.SaveOrUpdate(ana);
                s.SaveOrUpdate(milojko);
                s.Flush();
                s.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDirektorPredst_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Get<Predstavnistvo>(21);
                Zaposleni z = s.Get<Zaposleni>(7702992632111);

                if(!(z is Nadredjeni nadredjeni) || !nadredjeni.Direktor)
                {
                    throw new Exception("Nije nadredjeni ili direktor");
                }


                if (z is Nadredjeni zad) MessageBox.Show("Nadredjeni");

                p.Direktor = nadredjeni;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btnSefovanje_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OvlasceniServis o = s.Get<OvlasceniServis>(40);
                Zaposleni z = s.Get<Zaposleni>(1203988436388);

                if (!(z is Nadredjeni nadredjeni) 
                    || !nadredjeni.Sef 
                    || nadredjeni.JeSefSalona != null 
                    || nadredjeni.JeSefServisa != null)
                {
                    throw new Exception("Zaposleni ili nije sef ili vec sefuje");
                }

                o.SefServisa = nadredjeni;

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btnRadiU_Click(object sender, EventArgs e)
        {
            /*try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Get<Zaposleni>(2311984437657);
                //Salon salon = s.Get<Salon>(7);
                OvlasceniServis ovl = s.Get<OvlasceniServis>(6);

                if(!(z is Podredjeni podredjeni) 
                   || podredjeni.RadiUSalonu != null
                   || podredjeni.RadiUServisu != null)
                {
                    throw new Exception("VEC RADI ili je nadredjeni");
                }

                //podredjeni.RadiUSalonu = salon;
                podredjeni.RadiUServisu = ovl;

                s.SaveOrUpdate(podredjeni);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.ToString());
            }*/
        }

        private void btnProbaVozila_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = new Vozilo
                {
                    BrojSasije = "NIJESERVISIRANO",
                    BrojMotora = "NIJESERVISIRANO",
                    Kubikaza = 2,
                    TipGoriva = "Dizel",
                    Model = "NIJESERVISIRANO",
                    Boja = "NIJESERVISIRANO",
                    Putnicko = true,
                    BrojPutnika = 4,
                    Teretno = false
                };

                Salon salon = s.Get<Salon>(123);
                v.Salon = salon;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.InnerException.ToString());
            }
        }
    }
}