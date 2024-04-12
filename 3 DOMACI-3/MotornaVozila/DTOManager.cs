using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using MotornaVozila.Entiteti;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;
using System.Transactions;

namespace MotornaVozila
{
    public class DTOManager
    {
        //uradjeno u controlleru
        #region FormaSviZaposleni
        //uradjeno u controlleru
        public static List<ZaposleniPregled> vratiSveZaposlene()
        {
            List<ZaposleniPregled> zaposleni = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zaposleni> sviZaposleni = from o in s.Query<Zaposleni>()
                                                      select o;

                foreach(Zaposleni z in sviZaposleni)
                {
                    bool sef = false, direktor = false, rukovodilac = false;

                    if(z is Nadredjeni nadredjeni)
                    {
                        sef = nadredjeni.Sef;
                        rukovodilac = nadredjeni.Rukovodilac;
                        direktor = nadredjeni.Direktor;
                    }

                    zaposleni.Add(new ZaposleniPregled(z.MaticniBroj, z.LicnoIme,
                        z.Prezime, z.DatumRodjenja, z.DatumZaposlenja, z.Plata, sef, rukovodilac, direktor));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return zaposleni;
        }
        public static ZaposleniBasic vratiZaposlenogZaIzmenu(long matbr)
        {
            ZaposleniBasic zaposleniBasic = new ZaposleniBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Get<Zaposleni>(matbr);

                zaposleniBasic = new ZaposleniBasic
                {
                    MaticniBroj = z.MaticniBroj,
                    LicnoIme = z.LicnoIme,
                    Prezime = z.Prezime,
                    DatumRodjenja = z.DatumRodjenja,
                    DatumZaposlenja = z.DatumZaposlenja,
                    Plata = z.Plata
                };

                s.Close();
            }
            catch(Exception ex) 
            { 
                throw;
            }
            return zaposleniBasic;
        }

        //uradjeno u controlleru
        public static int obrisiRadnikaIzSistema(long matbr)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zaposleni z = s.Get<Zaposleni>(matbr);

                
                if(z is Podredjeni podredjeni)
                {
                    s.Delete(podredjeni);
                    s.Flush();
                }
                else if(z is Nadredjeni nad)
                {
                    if(nad.Rukovodilac)
                    {
                        foreach (Zaposleni zap in nad.RukovodiZaposlenima)
                        {
                            zap.RukovodilacZaposlenog = null;
                            s.Update(zap);
                            s.Flush();
                        }
                        nad.RukovodiZaposlenima.Clear();
                        s.Update(nad);
                        s.Flush();
                        s.Delete(nad);
                        s.Flush();
                    }
                    else if(nad.Direktor)
                    {
                        IList<Predstavnistvo> predstavnistva = (from p in s.Query<Predstavnistvo>()
                                                                where p.Direktor.MaticniBroj == nad.MaticniBroj
                                                                select p).ToList();

                        foreach(Predstavnistvo p in predstavnistva)
                        {
                            p.Direktor = null; s.Update(p); s.Flush();
                        }

                        //if(nad.JeDirektorPredstavnistva == null) nad.JeDirektorPredstavnistva = null;

                        s.Delete(nad);
                        s.Flush();
                    }
                    else if(nad.Sef)
                    {
                        IList<Salon> saloni = (from salon in s.Query<Salon>()
                                               where salon.SefSalona.MaticniBroj == nad.MaticniBroj
                                               select salon).ToList();
                        IList<OvlasceniServis> servisi = (from servis in s.Query<OvlasceniServis>()
                                               where servis.SefServisa.MaticniBroj == nad.MaticniBroj
                                               select servis).ToList();

                        foreach (Salon salon in saloni)
                        {
                            salon.SefSalona = null; s.Update(salon); s.Flush();
                        }
                        foreach (OvlasceniServis ovl in servisi)
                        {
                            ovl.SefServisa = null; s.Update(ovl); s.Flush();
                        }

                        //if (nad.JeSefServisa != null) { nad.JeSefServisa = null;  }
                        //if(nad.JeSefSalona != null) { nad.JeSefSalona = null; }
                        s.Delete(nad);
                        s.Flush();
                    }
                }
                s.Close();

            }
            catch (Exception ex)
            {
                throw;
            }
            return 1;
        }
        #endregion FormaSviZaposleni

        //uradjeno u controlleru
        #region FormaSvaVozila
        //uradjeno u controlleru
        public static List<VoziloPregled> vratiSvaVozila()
        {
            List<VoziloPregled> vozila = new List<VoziloPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Vozilo> svaVozila = from o in s.Query<Vozilo>().AsParallel()
                                                      select o;

                foreach (Vozilo v in svaVozila)
                { 
                    vozila.Add(new VoziloPregled(v.Id, v.BrojSasije, v.BrojMotora,
                       v.Model, v.Kubikaza, v.Putnicko, v.Teretno, v.Boja ));

                }

                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return vozila;
        }
        //uradjeno u controlleru
        public static void obrisiVoziloIzSistema(string brSasije)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Vozilo> vozila = (from v in s.Query<Vozilo>().AsParallel()
                                        where v.BrojSasije == brSasije
                                        select v).ToList();

               
                IList<Prodaja> prodaje = (from v in s.Query<Prodaja>().AsParallel()
                                          where v.ProdatoVozilo.BrojSasije == brSasije select v).ToList();

                if(prodaje.Count > 0) s.Delete(prodaje[0]);
                s.Flush();
                s.Delete(vozila[0]);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion FormaSvaVozila

        //uradjeno u controlleru
        #region FormaSvaPredstavnistva
        //uradjeno u controlleru
        public static List<PredstavnistvoPregled> vratiSvaPredstavnistva()
        {
            List<PredstavnistvoPregled> predstavnistva = new List<PredstavnistvoPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Predstavnistvo> svaPredstavnistva = from o 
                                                                in s.Query<Predstavnistvo>().AsParallel()
                                                                select o;

                foreach (Predstavnistvo p in svaPredstavnistva)
                {
                    predstavnistva.Add(new PredstavnistvoPregled(p.Id, p.Grad, p.AdresaPredstavnistva,
                        p.Direktor == null ? 
                        "" :
                        p.Direktor.LicnoIme, 
                        p.Direktor == null ?
                        "" :
                        p.Direktor.Prezime));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }

            return predstavnistva;
        }
        //uradjeno u controlleru
        public static SalonBasic ucitajSalonPredstavnistva(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Get<Predstavnistvo>(id);

                if (p.Salon == null) return null;

                SalonBasic sb = new SalonBasic(p.Salon.Id, p.Salon.Lokacija, p.Salon.Ime)
                {
                    SefSalona = p.Salon.SefSalona == null ? null : new NadredjeniBasic()
                    {
                        MaticniBroj = p.Salon.SefSalona.MaticniBroj,
                        LicnoIme = p.Salon.SefSalona.LicnoIme,
                        Prezime = p.Salon.SefSalona.Prezime
                    }
                };
                s.Close();
                return sb;
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }
        //uradjeno u controlleru
        public static OvlasceniServisBasic ucitajServisPredstavnistva(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Get<Predstavnistvo>(id);

                if (p.Servis == null) return null;

                OvlasceniServisBasic sb = new OvlasceniServisBasic
                    (p.Servis.Id, p.Servis.Ime, p.Servis.Lokacija, 
                    p.Servis.StepenOpremljenosti,
                    p.Servis.SaMehanicarskimUslugama,
                    p.Servis.SaLimarskimUslugama,
                    p.Servis.SaFarbarskimUslugama,
                    p.Servis.SaVulkanizerskimUslugama);
                s.Close();
                return sb;
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }
        #endregion FormaSvaPredstavnistva

        //uradjeno u controlleru
        #region SalonIServisForma
        public static List<ZaposleniPregled> vratiSveZaposleneMesZap(MestoZaposljenjaBasic meszap)
        {
            List<ZaposleniPregled> listaZaposlenihMesZap = new List<ZaposleniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Podredjeni> sviZaposleni = null;

                if (meszap is SalonBasic salon) 
                {
                    sviZaposleni = from o in s.Query<Podredjeni>()
                                                           where o.RadiUSalonu.Id == salon.Id
                                                           select o;
                }
                else if(meszap is OvlasceniServisBasic servis)
                {
                    sviZaposleni = from o in s.Query<Podredjeni>()
                                   where o.RadiUServisu.Id == servis.Id
                                   select o;
                }
                else
                {
                    throw new Exception("Ne postoji takvo mesto zaposljenja");
                }

                foreach (Podredjeni z in sviZaposleni)
                {
                    listaZaposlenihMesZap.Add(new ZaposleniPregled(
                        z.MaticniBroj, z.LicnoIme, z.Prezime, z.Struka, z.Plata));
                }

                s.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
            return listaZaposlenihMesZap;
        }

        public static string vratiImeIPrezimeSefa(MestoZaposljenjaBasic meszap)
        {
            string imeIPrezime = "";
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = null;
                OvlasceniServis ovl = null;

                if(meszap is SalonBasic sb)
                {
                    salon = s.Get<Salon>(sb.Id);
                    if(salon.SefSalona == null) { imeIPrezime = ""; }
                    else imeIPrezime = salon.SefSalona.LicnoIme + " " + salon.SefSalona.Prezime;
                }
                else if(meszap is OvlasceniServisBasic ovb)
                {
                    ovl = s.Get<OvlasceniServis>(ovb.Id);
                    if (ovl.SefServisa == null) { imeIPrezime = ""; }
                    else imeIPrezime = ovl.SefServisa.LicnoIme + " " + ovl.SefServisa.Prezime;
                }
                else
                {
                    throw new Exception("Ne postoji takvo mesto zaposljenja");
                }
                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return imeIPrezime;
        }
        #endregion SalonIServisForma

        //uradjeno u controlleru
        #region ServisForma

        //uradjeno u controlleru
        public static OvlasceniServisBasic vratiServisVisegRanga(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OvlasceniServis os = s.Get<OvlasceniServis>(id);

                OvlasceniServis vr = os.ServisVisegRanga;

                if(vr == null)
                {
                    return null;
                }

                OvlasceniServisBasic ovlasceniServisBasic = new OvlasceniServisBasic(
                    vr.Id, vr.Lokacija, vr.Ime, vr.StepenOpremljenosti,
                    vr.SaMehanicarskimUslugama, vr.SaLimarskimUslugama,
                    vr.SaFarbarskimUslugama, vr.SaVulkanizerskimUslugama);

                s.Close();

                return ovlasceniServisBasic;
            }
            catch(Exception ex)
            {
                throw;
            }
            return null;
        }

        //uradjeno u controlleru
        public static List<ServisiranjeBasic> vratiServisiranja(int id)
        {
            List<ServisiranjeBasic> listaServisiranja = new List<ServisiranjeBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                OvlasceniServis ovl = s.Get<OvlasceniServis>(id);

                listaServisiranja = ovl.Servisiranja.Select(servisiranje =>
                new ServisiranjeBasic(servisiranje.Id, servisiranje.PFR,
                servisiranje.DatumPrijema, servisiranje.DatumZavrsetka, servisiranje.OpisProblema)
                {
                    ServisiranoVozilo = new ServisiranoVoziloBasic(
                        servisiranje.ServisiranoVozilo.Id,
                        servisiranje.ServisiranoVozilo.RegistarskiBroj,
                        servisiranje.ServisiranoVozilo.GodinaProizvodnje),
                    Primalac = new PodredjeniBasic()
                    {
                        LicnoIme = servisiranje.Primalac.LicnoIme,
                        Prezime = servisiranje.Primalac.Prezime
                    }
                }).ToList();

                s.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
            return listaServisiranja;
        }
    
        public static List<ServisiranoVoziloBasic> vratiServisiranaVozila(List<ServisiranjeBasic> servisiranja)
        {
            List<ServisiranoVoziloBasic> listaSerVozila = new List<ServisiranoVoziloBasic>();
            try
            {
                HashSet<ServisiranoVozilo> skup = new HashSet<ServisiranoVozilo>();

                ISession s = DataLayer.GetSession();

                foreach (ServisiranjeBasic sb in servisiranja)
                {
                    Servisiranje servisiranje = s.Get<Servisiranje>(sb.Id);
                    ServisiranoVozilo sv = servisiranje.ServisiranoVozilo;

                    if (skup.Add(sv))
                    {
                        Vozilo svv = sv.Vozilo;
                        NezavisnoVozilo nzv = sv.NezavisnoVozilo;

                        listaSerVozila.Add(new ServisiranoVoziloBasic(
                            servisiranje.ServisiranoVozilo.Id,
                            servisiranje.ServisiranoVozilo.RegistarskiBroj,
                            servisiranje.ServisiranoVozilo.GodinaProizvodnje)
                            {
                                Vozilo = svv == null ?
                                         null : 
                                         new VoziloBasic
                                         {
                                             BrojMotora = svv.BrojMotora,
                                             BrojSasije = svv.BrojSasije,
                                             Kubikaza = svv.Kubikaza,
                                             Model = svv.Model,
                                             Boja = svv.Boja,
                                         },
                                NezavisnoVozilo = nzv == null ?
                                                  null :
                                                  new NezavisnoVoziloBasic
                                                  {
                                                      ImeKupca = nzv.ImeKupca,
                                                      PrezimeKupca = nzv.PrezimeKupca,
                                                      BrojTelefona = nzv.BrojTelefona,
                                                      Model = nzv.Model,
                                                      Vin = nzv.Vin
                                                  }
                        });
                    }
                }
            }
            catch(Exception e)
            {
                throw;
            }

            return listaSerVozila;
        }
        #endregion ServisForma

        //uradjeno u controlleru
        #region SalonForma

        public static List<VoziloBasic> vratiIzlozenaVozila(int id)
        {
            List<VoziloBasic> listaVozila = new List<VoziloBasic>();
            try
            {
                ISession session = DataLayer.GetSession();

                Salon salon = session.Get<Salon>(id);

                listaVozila = salon.Vozila.Select(vozilo => new VoziloBasic()
                                                {
                                                    Id = vozilo.Id,
                                                    BrojMotora = vozilo.BrojMotora,
                                                    BrojSasije = vozilo.BrojSasije,
                                                    Model = vozilo.Model,
                                                    Kubikaza = vozilo.Kubikaza,
                                                    Putnicko = vozilo.Putnicko,
                                                    Teretno = vozilo.Teretno
                                                }).ToList();

                session.Close();

            }
            catch (Exception e)
            {
            }

            return listaVozila;
        }

        public static List<ProdajaBasic> vratiProdaje(int id)
        {
            List<ProdajaBasic> prodaje = new List<ProdajaBasic>();
            try
            {
                ISession session = DataLayer.GetSession();

                Salon salon = session.Get<Salon>(id);

                prodaje = salon.Prodaje.Select(prodaja => new ProdajaBasic()
                                                {
                                                    Id = prodaja.Id,
                                                    DatumKupovine = prodaja.DatumKupovine,
                                                    Cena = prodaja.Cena,
                                                    ProdatoVozilo = new VoziloBasic()
                                                    {
                                                        Model = prodaja.ProdatoVozilo.Model
                                                    },
                                                    KupacVozila = new KupacBasic()
                                                    {
                                                        KupacFizickoLice = prodaja.KupacVozila.KupacFizickoLice == null ? 
                                                                           null :
                                                                           new FizickoLiceBasic()
                                                                           {
                                                                               Ime = prodaja.KupacVozila.KupacFizickoLice.Ime,
                                                                               Prezime = prodaja.KupacVozila.KupacFizickoLice.Prezime
                                                                           },
                                                        KupacPravnoLice = prodaja.KupacVozila.KupacPravnoLice == null ?
                                                                          null :
                                                                          new PravnoLiceBasic()
                                                                          {
                                                                              Ime = prodaja.KupacVozila.KupacPravnoLice.Ime,
                                                                              Prezime = prodaja.KupacVozila.KupacPravnoLice.Prezime
                                                                          }
                                                    },
                                                    Prodavac = new PodredjeniBasic()
                                                    {
                                                        LicnoIme = prodaja.Prodavac.LicnoIme,
                                                        Prezime = prodaja.Prodavac.Prezime
                                                    }
                                                }).ToList();
            }
            catch(Exception e)
            {
                throw;
            }
            return prodaje;
        }

        /*public static void obrisiSalon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = s.Get<Salon>(id);
                Nadredjeni n = s.Get<Nadredjeni>(salon.SefSalona.MaticniBroj);

                n.JeSefSalona = null;

                s.SaveOrUpdate(n);
                s.Flush();

                salon.SefSalona = null;
                salon.Radnici = null;

                IList<Prodaja> prodaje = (from p in s.Query<Prodaja>()
                                          where p.SalonProdaje.Id == id
                                          select p).ToList();

                foreach(Prodaja prodaja in prodaje)
                {
                    prodaja.SalonProdaje = null;
                    s.SaveOrUpdate(prodaja);
                    s.Flush();
                }

                salon.Prodaje.Clear();

                IList<Vozilo> vozila = (from v in s.Query<Vozilo>()
                                          where v.Salon.Id == id
                                          select v).ToList();
                foreach(Vozilo v in vozila)
                {
                    v.Salon = null;
                    s.SaveOrUpdate(v);
                    s.Flush();
                }

                salon.Vozila.Clear();


                s.Delete(salon);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            { throw; }
        }*/
        #endregion SalonForma

        //uradjeno u controlleru
        #region ProdajaForma

        //uradjeno u controlleru
        public static void obrisiProdaju(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodaja p = s.Get<Prodaja>(id);

                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            { throw; }
        }

        //uradjeno u controlleru
        public static List<PodredjeniBasic> vratiProdavceSalona(int idSalona)
        {
            List<PodredjeniBasic> prodavci = new List<PodredjeniBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Podredjeni> podredjeni = (from p in s.Query<Podredjeni>()
                                                where p.RadiUSalonu.Id == idSalona
                                                select p
                                                ).ToList();

                prodavci = podredjeni.Select(p => new PodredjeniBasic
                {
                    MaticniBroj = p.MaticniBroj,
                    LicnoIme = p.LicnoIme,
                    Prezime = p.Prezime
                }).ToList();
                s.Close();
            }
            catch(Exception e)
            {
                throw;
            }
            return prodavci;
        }

        //uradjeno u controlleru
        public static List<VoziloBasic> vratiVozilaSalona(int idSalona)
        {
            List<VoziloBasic> vozila = new List<VoziloBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Vozilo> v = (from p in s.Query<Vozilo>()
                                                where (p.Salon.Id == idSalona /*&& p.Prodaja == null*/)
                                                select p
                                                ).ToList();

                IList<Prodaja> prodaja = (from prod in s.Query<Prodaja>()
                                          select prod
                                          ).ToList();

                IList<Vozilo> zaIzbacivanje = new List<Vozilo>();
                foreach(Vozilo vozilo in v)
                {
                    if (prodaja.Contains(vozilo.Prodaja))
                        zaIzbacivanje.Add(vozilo);
                }

                foreach(Vozilo vozilo in zaIzbacivanje)
                {
                    v.Remove(vozilo);
                }

                vozila = v.Select(p => new VoziloBasic
                {
                    Id = p.Id,
                    Model = p.Model,
                    Kubikaza = p.Kubikaza,
                    Boja = p.Boja
                }).ToList();
                s.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            return vozila;
        }
        #endregion ProdajaForma

        //uradjeno u controlleru
        #region NezavisnaVozilaForm

        public static void obrisiNezVozilo(int vin)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                NezavisnoVozilo n = s.Get<NezavisnoVozilo>(vin);
                s.Delete(n);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        #endregion NezavisnaVozilaForm

        //uradjeno u controlleru
        #region Izmene

        //uradjeno u controlleru
        public static void izmeniZaposlenog(ZaposleniBasic zb)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = s.Get<Zaposleni>(zb.MaticniBroj);

                z.LicnoIme = zb.LicnoIme;
                z.Prezime = zb.Prezime;
                z.Plata = zb.Plata;

                s.Update(z);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //uradjeno u controlleru
        public static List<ZaposleniBasic> vratiSefove()
        {
            List<ZaposleniBasic> listaSefova = new List<ZaposleniBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Nadredjeni> zaposleni = (from z in s.Query<Nadredjeni>()
                                               where z.Sef == true
                                               select z).ToList();

                listaSefova = zaposleni.Select(z => 
                                new ZaposleniBasic()
                                {
                                    MaticniBroj = z.MaticniBroj,
                                    LicnoIme = z.LicnoIme,
                                    Prezime = z.Prezime
                                }).ToList();

                s.Close();
            }
            catch (Exception e)
            {
                throw; 
            }
            return listaSefova;
        }

        //uradjeno u controlleru
        public static void izmeniSalon(int id, long noviSef, string novoIme, string novaLokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Salon salon = s.Get<Salon>(id);

                if(novoIme != "") salon.Ime = novoIme;
                if(novaLokacija != "") salon.Lokacija = novaLokacija;

                Nadredjeni n = s.Get<Nadredjeni>(noviSef);


                salon.SefSalona = n;

                n.JeSefSalona = salon;
                //salon.SefSalona.LicnoIme = sb.SefSalona.LicnoIme;
                //salon.SefSalona.Prezime = sb.SefSalona.Prezime;
                s.Update(n);
                s.Update(salon);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            { 
                throw; 
            }
        }

        //uradjeno u controlleru
        public static void izmeniServis(int id, long noviSef, string novoIme, string novaLokacija)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                OvlasceniServis servis = s.Get<OvlasceniServis>(id);

                if (novoIme != "") servis.Ime = novoIme;
                if (novaLokacija != "") servis.Lokacija = novaLokacija;

                Nadredjeni n = s.Get<Nadredjeni>(noviSef);


                servis.SefServisa = n;

                n.JeSefServisa = servis;
                //salon.SefSalona.LicnoIme = sb.SefSalona.LicnoIme;
                //salon.SefSalona.Prezime = sb.SefSalona.Prezime;
                s.Update(n);
                s.Update(servis);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        //uradjeno u controlleru
        public static string vratiLokacijuSalona(int id)
        {
            string lokacija = "";
            try
            {
                ISession s = DataLayer.GetSession();
                Salon salon = s.Get<Salon>(id);
                lokacija = salon.Lokacija;
                s.Close();
            }
            catch(Exception e)
            {
                throw;
            }
            return lokacija;
        }

        //uradjeno u controlleru
        public static string vratiImeSalona(int id)
        {
            string ime = "";
            try
            {
                ISession s = DataLayer.GetSession();
                Salon salon = s.Get<Salon>(id);
                ime = salon.Ime;
                s.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            return ime;
        }

        //uradjeno u controlleru
        public static string vratiLokacijuServisa(int id)
        {
            string lokacija = "";
            try
            {
                ISession s = DataLayer.GetSession();
                OvlasceniServis servis = s.Get<OvlasceniServis>(id);
                lokacija = servis.Lokacija;
                s.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            return lokacija;
        }

        //uradjeno u controlleru
        public static string vratiImeServisa(int id)
        {
            string ime = "";
            try
            {
                ISession s = DataLayer.GetSession();
                OvlasceniServis servis = s.Get<OvlasceniServis>(id);
                ime = servis.Ime;
                s.Close();
            }
            catch (Exception e)
            {
                throw;
            }
            return ime;
        }

        //uradjeno u controlleru
        public static void izmeniPredstavnistvo(int id, string grad, string ime)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Get<Predstavnistvo>(id);

                if(grad != "")
                    p.Grad = grad;

                if(ime != "")
                    p.AdresaPredstavnistva = ime;

                s.Update(p);
                s.Flush();
                s.Close();
            }
            catch(Exception e )
            {
                throw;
            }
        }
        #endregion Izmene


        #region Post
        public static void dodajNoviSalon(SalonDTO salonDto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Get<Predstavnistvo>(salonDto.PredstavnistvoId);

                Salon salon = new Salon
                {
                    Lokacija = salonDto.Lokacija,
                    Ime = salonDto.Ime,
                    PredstavnistvoSalona = p
                };

                if (p.Salon == null) p.Salon = salon;
                else
                    throw new Exception("Predstavnistvo vec sadrzi salon.");

                s.SaveOrUpdate(p);
                s.SaveOrUpdate(salon);
                s.Flush();
                s.Close();
            }
            catch(Exception e ) 
            {
                throw;
            }
        }
        public static void dodajNoviServis(OvlasceniServisDTO servis)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = s.Get<Predstavnistvo>(servis.PredstavnistvoId);

                OvlasceniServis o = new OvlasceniServis
                {
                    Lokacija = servis.Lokacija,
                    Ime = servis.Ime,
                    StepenOpremljenosti = "Dobro opremljen",
                    SaMehanicarskimUslugama = servis.Mehanicar,
                    SaFarbarskimUslugama = servis.Farbar,
                    SaLimarskimUslugama = servis.Limar,
                    SaVulkanizerskimUslugama = servis.Vulkanizer,
                    PredstavnistvoServisa = p    
                };

                if (p.Servis == null) p.Servis = o;
                else
                    throw new Exception("Predstavnistvo vec sadrzi servis.");

                s.SaveOrUpdate(p);
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void dodajVozilo(VoziloDTO voziloDto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo v = new Vozilo
                {
                    Boja = voziloDto.Boja,
                    TipGoriva = voziloDto.Gorivo,
                    Kubikaza = voziloDto.Kubikaza,
                    Model = voziloDto.Model,
                    BrojMotora = voziloDto.BrojMotora,
                    BrojSasije = voziloDto.BrojSasije,
                    Putnicko = voziloDto.Putnicko,
                    Teretno = voziloDto.Teretno
                };

                Salon salon = s.Get<Salon>(voziloDto.IdSalona); 

                v.Salon = salon;

                s.SaveOrUpdate(v);
                s.Flush();
                s.Close();
            }
            catch (Exception e) 
            {
                throw;
            }
        }
        public static void dodajNovoPredstavnistvo(PredstavnistvoDTO predstavnistvo)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Predstavnistvo p = new Predstavnistvo
                {
                    Grad=predstavnistvo.Grad,
                    AdresaPredstavnistva = predstavnistvo.Adresa
                };

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public static void dodajNovogPodredjenogTehnicka(PodredjeniDTO podredjeni)
        {
            try
            {
                string struka = "Tehnicka struka";
                ISession s = DataLayer.GetSession();

                Podredjeni p = new Podredjeni
                {
                    MaticniBroj = podredjeni.MatBr,
                    LicnoIme = podredjeni.Ime,
                    Prezime = podredjeni.Prezime,
                    DatumRodjenja = podredjeni.DatumRodjenja,
                    DatumZaposlenja = podredjeni.DatumZaposlenja,
                    Struka = struka,
                    Plata = podredjeni.Plata,
                    GodineRadnogStaza = podredjeni.GodineRadnogStaza,
                    DugorocnostZaposlenja=podredjeni.DugorocnostZaposlenja,

                };
                if (podredjeni.NazivSpecijalnosti != null && podredjeni.DatumSticanjaSpecijalnosti != null && podredjeni.InstitucijaSticanjaSpecijalnosti != null)
                {
                    p.NazivSpecijalnosti = podredjeni.NazivSpecijalnosti;
                    p.InstitucijaSticanjaSpecijalnosti =podredjeni.InstitucijaSticanjaSpecijalnosti;
                    p.DatumSticanjaSpecijalnosti = (DateTime)podredjeni.DatumSticanjaSpecijalnosti;
                }
                if(podredjeni.DugorocnostZaposlenja!=null&&podredjeni.DugorocnostZaposlenja=="Po ugovoru"&&
                    podredjeni.DatumIstekaUgovora!=null)
                {
                    p.DatumIstekaUgovora =(DateTime) podredjeni.DatumIstekaUgovora;
                }
                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void dodajNovogNadredjenogTehnicka(NadredjeniDTO nadredjeni)
        {
            try
            {
                string struka = "Tehnicka struka";
                ISession s = DataLayer.GetSession();

                Nadredjeni p = new Nadredjeni
                {
                    MaticniBroj = nadredjeni.MatBr,
                    LicnoIme = nadredjeni.Ime,
                    Prezime = nadredjeni.Prezime,
                    DatumRodjenja = nadredjeni.DatumRodjenja,
                    DatumZaposlenja = nadredjeni.DatumZaposlenja,
                    Struka = struka,
                    Plata = nadredjeni.Plata,
                    GodineRadnogStaza = nadredjeni.GodineRadnogStaza,
                    Sef = nadredjeni.Sef,
                    Direktor = nadredjeni.Direktor,
                    Rukovodilac = nadredjeni.Rukovodilac
                };

                if(nadredjeni.NazivSpecijalnosti!=null&&nadredjeni.DatumSticanjaSpecijalnosti!=null&&nadredjeni.InstitucijaSticanjaSpecijalnosti!=null)
                {
                    p.NazivSpecijalnosti = nadredjeni.NazivSpecijalnosti;
                    p.InstitucijaSticanjaSpecijalnosti = nadredjeni.InstitucijaSticanjaSpecijalnosti;
                    p.DatumSticanjaSpecijalnosti = (DateTime)nadredjeni.DatumSticanjaSpecijalnosti;
                }
                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void dodajNovogNadredjenogEkonomska(NadredjeniDTO nadredjeni)
        {
            try
            {
                string struka = "Ekonomska struka";
                ISession s = DataLayer.GetSession();

                Nadredjeni p = new Nadredjeni
                {
                    MaticniBroj = nadredjeni.MatBr,
                    LicnoIme = nadredjeni.Ime,
                    Prezime = nadredjeni.Prezime,
                    DatumRodjenja = nadredjeni.DatumRodjenja,
                    DatumZaposlenja = nadredjeni.DatumZaposlenja,
                    Struka = struka,
                    Plata = nadredjeni.Plata,
                    GodineRadnogStaza = nadredjeni.GodineRadnogStaza,
                    Sef = nadredjeni.Sef,
                    Direktor = nadredjeni.Direktor,
                    Rukovodilac = nadredjeni.Rukovodilac
                };
                if(nadredjeni.PosedujeSertifikat!=null&&nadredjeni.DatumVazenjaSertifikata!=null)
                {
                    p.PosedujeSertifikat = (int)nadredjeni.PosedujeSertifikat;
                    p.DatumVazenjaSertifikata = (DateTime)nadredjeni.DatumVazenjaSertifikata;
                }

                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void dodajNovogPodredjenogEkonomska(PodredjeniDTO podredjeni)
        {
            try
            {
                string struka = "Ekonomska struka";
                ISession s = DataLayer.GetSession();

                Podredjeni p = new Podredjeni
                {
                    MaticniBroj = podredjeni.MatBr,
                    LicnoIme = podredjeni.Ime,
                    Prezime = podredjeni.Prezime,
                    DatumRodjenja = podredjeni.DatumRodjenja,
                    DatumZaposlenja = podredjeni.DatumZaposlenja,
                    Struka = struka,
                    Plata =podredjeni.Plata,
                    GodineRadnogStaza = podredjeni.GodineRadnogStaza,
                    DugorocnostZaposlenja=podredjeni.DugorocnostZaposlenja,
                };
                if (podredjeni.PosedujeSertifikat != null && podredjeni.DatumVazenjaSertifikata != null)
                {
                    p.PosedujeSertifikat = (int)podredjeni.PosedujeSertifikat;
                    p.DatumVazenjaSertifikata = (DateTime)podredjeni.DatumVazenjaSertifikata;
                }
                if (podredjeni.DugorocnostZaposlenja != null && podredjeni.DugorocnostZaposlenja == "Po ugovoru" &&
                    podredjeni.DatumIstekaUgovora != null)
                {
                    p.DatumIstekaUgovora = (DateTime)podredjeni.DatumIstekaUgovora;
                }
                s.Save(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static void obaviProdaju(ProdajaDTO dto)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prodaja prodaja = new Prodaja
                {
                    DatumKupovine = dto.DatumKupovine,
                    Cena = dto.Cena
                };

                Vozilo v = s.Get<Vozilo>(dto.IdVozila);
                prodaja.ProdatoVozilo = v;

                if(v==null)
                   throw new Exception("Nepostojece vozilo.");

                Salon salon = s.Get<Salon>(v.Salon.Id);
                prodaja.SalonProdaje = salon;

                Podredjeni p = s.Get<Podredjeni>(dto.MatBrProdavca);
                if (p == null)
                    throw new Exception("Nepostojeci prodavac.");
                prodaja.Prodavac = p;

                Kupac? k= dto.IdKupca!=null?s.Get<Kupac>(dto.IdKupca):null;


                /*Kupac k = new Kupac
                {
                    KupacFizickoLice = new FizickoLice
                    {
                        MaticniBroj = kupac,
                        Ime = imeKupca,
                        Prezime = prezimeKupca
                    }
                };*/
                if(k==null)
                {
                    if (dto.ImeKupca == null || dto.PrezimeKupca == null||dto.MatBrKupca==null)
                        throw new Exception("Novi kupci moraju imati ime i prezime, i maticni broj.");
                    k = new Kupac();
                    s.Save(k);
                    s.Flush();
                    FizickoLice fizickoLice = new FizickoLice
                    {
                        MaticniBroj = (long)dto.MatBrKupca,
                        Ime = dto.ImeKupca,
                        Prezime = dto.PrezimeKupca,
                        FizickoLiceKupuje = k
                    };

                    s.Save(fizickoLice);
                    s.Flush();

                }

                prodaja.KupacVozila = k;

                v.Prodaja = prodaja;

                s.Save(prodaja);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                throw;
            }
        }
        #endregion Post
    }
}