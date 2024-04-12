using Microsoft.AspNetCore.Mvc;
using MotornaVozila;

namespace WebApiMotornaVozila.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OvlasceniServisController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiServisPredstavnistva{predstavnistvoID}")]
        public IActionResult PreuzmiServisPredstavnistva(int predstavnistvoID)
        {
            try
            {
                var servis = DTOManager.ucitajServisPredstavnistva(predstavnistvoID);

                return servis == null
                    ? throw new Exception("To predstavnistvo nema servis!")
                    : new JsonResult(new
                {
                    servis.Id,
                    servis.Lokacija,
                    servis.Ime,
                    servis.StepenOpremljenosti,
                    servis.SaFarbarskimUslugama,
                    servis.SaLimarskimUslugama,
                    servis.SaVulkanizerskimUslugama,
                    servis.SaMehanicarskimUslugama
                    });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("VratiServisVisegRanga{id}")]
        public IActionResult VratiServisVisegRanga(int id)
        {
            try
            {
                var servisiranje = DTOManager.vratiServisVisegRanga(id);



                return servisiranje == null
                    ? throw new Exception("To predstavnistvo nema servis!")
                    : new JsonResult(new
                    {
                        servisiranje.Id,
                        servisiranje.Lokacija,
                        servisiranje.Ime,
                        servisiranje.StepenOpremljenosti,
                        servisiranje.SaFarbarskimUslugama,
                        servisiranje.SaLimarskimUslugama,
                        servisiranje.SaVulkanizerskimUslugama,
                        servisiranje.SaMehanicarskimUslugama
                    });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("VratiServisiranja{id}")]
        public IActionResult VratiServisiranja(int id)
        {
            try
            {
                var servisiranja = DTOManager.vratiServisiranja(id);



                var all = servisiranja.Select(p => new
                {
                    p.Id,
                    p.PFR,
                    p.DatumPrijema,
                    p.DatumZavrsetka,
                    p.OpisProblema,
                    ServisiranoVozilo = new
                    {
                        p.ServisiranoVozilo.Id,
                        p.ServisiranoVozilo.RegistarskiBroj,
                        p.ServisiranoVozilo.GodinaProizvodnje
                    },
                    Primalac = new
                    {
                        p.Primalac.LicnoIme,
                        p.Primalac.Prezime
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
        [HttpGet("VratiServisiranaVozila{id}")]
        public IActionResult VratiServisiranaVozila(int id) //id je za ovlasceni servis
        {
            try
            {
                var servisiranja = DTOManager.vratiServisiranja(id);

                var servisiranaVozila = DTOManager.vratiServisiranaVozila(servisiranja);

                var all = servisiranaVozila.Select(p => new
                {
                    p.Id,
                    p.RegistarskiBroj,
                    p.GodinaProizvodnje,
                    Vozilo = p.Vozilo == null ? null : new
                    {
                        p.Vozilo.BrojMotora,
                        p.Vozilo.BrojSasije,
                        p.Vozilo.Kubikaza,
                        p.Vozilo.Model,
                        p.Vozilo.Boja
                    },
                    NezavisnoVozilo = p.NezavisnoVozilo == null ? null : new 
                    {
                        p.NezavisnoVozilo.ImeKupca,
                        p.NezavisnoVozilo.PrezimeKupca,
                        p.NezavisnoVozilo.BrojTelefona,
                        p.NezavisnoVozilo.Model,
                        p.NezavisnoVozilo.Vin
                    }
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
        [HttpGet("PreuzmiSveZaposleneServisa{servisID}")]
        public IActionResult PreuzmiSveZaposleneServisa(int servisID)
        {
            try
            {
                OvlasceniServisBasic servis = new OvlasceniServisBasic()
                {
                    Id = servisID
                };

                var zaposleni = DTOManager.vratiSveZaposleneMesZap(servis);

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
        [HttpGet("PreuzmiImePrezimeSefaServisa{servisID}")]
        public IActionResult PreuzmiImePrezimeSefaServisa(int servisID)
        {
            try
            {
                OvlasceniServisBasic servis = new OvlasceniServisBasic()
                {
                    Id = servisID
                };

                var zaposleni = DTOManager.vratiImeIPrezimeSefa(servis);

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
        [HttpGet("PreuzmiLokacijuServisa{servisID}")]
        public IActionResult PreuzmiLokacijuServisa(int servisID)
        {
            try
            {
                var lokacija = DTOManager.vratiLokacijuServisa(servisID);

                return Ok(lokacija);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiImeServisa{servisID}")]
        public IActionResult PreuzmiImeServisa(int servisID)
        {
            try
            {
                var ime = DTOManager.vratiImeServisa(servisID);

                return Ok(ime);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("PromeniServis/{id}/{noviSef}/{novoIme}/{novaLokacija}")]
        public IActionResult PromeniServis(int id, long noviSef, string novoIme, string novaLokacija)
        {
            try
            {
                DTOManager.izmeniServis(id, noviSef, novoIme, novaLokacija);
                return Ok($"Servis sa id-jem {id} uspesno izmenjen");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("PostaviServis")]
        public IActionResult PostaviServis([FromBody]OvlasceniServisDTO servis)
        {
            try
            {
                DTOManager.dodajNoviServis(servis);
                return Ok("Servis je dodat.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

