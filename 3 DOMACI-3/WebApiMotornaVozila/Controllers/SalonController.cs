using FluentNHibernate.Utils;
using Microsoft.AspNetCore.Mvc;
using MotornaVozila;
using MotornaVozila.Entiteti;

namespace WebApiMotornaVozila.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalonController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiSalonPredstavnistva{predstavnistvoID}")]
        public IActionResult PreuzmiSalonPredstavnistva(int predstavnistvoID)
        {
            try
            {
                var salon = DTOManager.ucitajSalonPredstavnistva(predstavnistvoID);

                return salon == null
                    ? throw new Exception("To predstavnistvo nema salon!")
                    : (IActionResult)new JsonResult(new
                    {
                        salon.Id,
                        salon.Lokacija,
                        salon.Ime,
                        MatBrSefa = salon.SefSalona == null ? 0 : salon.SefSalona.MaticniBroj,
                        ImeSefa = salon.SefSalona == null ? "" : salon.SefSalona.LicnoIme,
                        PrezimeSefa = salon.SefSalona == null ? "" : salon.SefSalona.Prezime
                    });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiIzlozenaVozila{salonID}")]
        public IActionResult PreuzmiIzlozenaVozila(int salonID)
        {
            try
            {
                var vozila = DTOManager.vratiIzlozenaVozila(salonID);

                var all = vozila.Select(p => new
                {
                    p.Id,
                    p.BrojMotora,
                    p.BrojSasije,
                    p.Model,
                    p.Kubikaza,
                    p.Putnicko,
                    p.Teretno
                }).ToList();

                return new JsonResult(all);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiProdaje{salonID}")]
        public IActionResult PreuzmiProdaje(int salonID)
        {
            try
            {
                var prodaje = DTOManager.vratiProdaje(salonID);

                var all = prodaje.Select(p => new
                {
                    p.Id,
                    p.DatumKupovine,
                    p.Cena,
                    ProdatoVozilo = new
                    {
                        p.ProdatoVozilo.Model
                    },
                    KupacVozila = new
                    {
                        KupacIme = p.KupacVozila.KupacFizickoLice == null ? p.KupacVozila.KupacPravnoLice.Ime :
                                                                           p.KupacVozila.KupacFizickoLice.Ime,
                        KupacPrezime = p.KupacVozila.KupacFizickoLice == null ? p.KupacVozila.KupacPravnoLice.Prezime :
                                                                           p.KupacVozila.KupacFizickoLice.Prezime
                    },
                    ProdavacVozila = new
                    {
                        p.Prodavac.LicnoIme,
                        p.Prodavac.Prezime
                    }
                }).ToList();

                return new JsonResult(all);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiProdavceSalona{salonID}")]
        public IActionResult PreuzmiProdavceSalona(int salonID)
        {
            try
            {
                var prodavci = DTOManager.vratiProdavceSalona(salonID);

                var all = prodavci.Select(p => new
                {
                    p.MaticniBroj,
                    p.LicnoIme,
                    p.Prezime
                }).ToList();

                return new JsonResult(all);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiVozilaSalona{salonID}")]
        public IActionResult PreuzmiVozilaSalona(int salonID)
        {
            try
            {
                var prodavci = DTOManager.vratiVozilaSalona(salonID);

                var all = prodavci.Select(p => new
                {
                    p.Id,
                    p.Model,
                    p.Kubikaza,
                    p.Boja
                }).ToList();

                return new JsonResult(all);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiSveZaposleneSalona{salonID}")]
        public IActionResult PreuzmiSveZaposleneSalona(int salonID)
        {
            try
            {
                SalonBasic salon = new SalonBasic()
                {
                    Id = salonID
                };

                var zaposleni = DTOManager.vratiSveZaposleneMesZap(salon);

                var all = zaposleni.Select(p => new
                {
                    p.MatBr,
                    p.Ime,
                    p.Prezime,
                    p.Struka,
                    p.Plata
                });

                return new JsonResult(all);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiImePrezimeSefaSalona{salonID}")]
        public IActionResult PreuzmiImePrezimeSefaSalona(int salonID)
        {
            try
            {
                SalonBasic salon = new SalonBasic()
                {
                    Id = salonID
                };

                var zaposleni = DTOManager.vratiImeIPrezimeSefa(salon);

                if (zaposleni == "") zaposleni = "Nema sefa";

                return Ok(zaposleni);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiLokacijuSalona{salonID}")]
        public IActionResult PreuzmiLokacijuSalona(int salonID)
        {
            try
            {
                var lokacija = DTOManager.vratiLokacijuSalona(salonID);

                return Ok(lokacija);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiImeSalona{salonID}")]
        public IActionResult PreuzmiImeSalona(int salonID)
        {
            try
            {
                var ime = DTOManager.vratiImeSalona(salonID);

                return Ok(ime);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("PromeniSalon/{id}/{noviSef}/{novoIme}/{novaLokacija}")]
        public IActionResult PromeniSalon(int id, long noviSef, string novoIme, string novaLokacija)
        {
            try
            {
                DTOManager.izmeniSalon(id, noviSef, novoIme, novaLokacija);
                return Ok($"Salon sa id-jem {id} uspesno izmenjen");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("DodajSalon")]
        public IActionResult DodajSalon([FromBody]SalonDTO salon)
        {
            try
            {
                DTOManager.dodajNoviSalon(salon);
                return Ok("Salon je dodat.");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}