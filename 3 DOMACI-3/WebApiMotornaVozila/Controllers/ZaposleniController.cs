using Microsoft.AspNetCore.Mvc;
using MotornaVozila;

namespace WebApiMotornaVozila.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZaposleniController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiSveZaposlene")]
        public IActionResult PreuzmiSveZaposlene()
        {
            try
            {
                var zaposleni = DTOManager.vratiSveZaposlene();
                var all = zaposleni.Select(p => new
                {
                    p.MatBr,
                    p.Ime,
                    p.Prezime,
                    p.DatumRodjenja,
                    p.DatumZaposlenja,
                    p.Plata,
                    p.Sef,
                    p.Rukovodilac,
                    p.Direktor
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
        [HttpDelete("ObrisiZaposlenog{matBr}")]
        public IActionResult ObrisiZaposlenog(long matBr)
        {
            try
            {
                DTOManager.obrisiRadnikaIzSistema(matBr);

                return Ok($"Zaposleni sa maticnim brojem {matBr} obrisan");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiSefove")]
        public IActionResult PreuzmiSefove()
        {
            try
            {
                var zaposleni = DTOManager.vratiSefove();
                var all = zaposleni.Select(p => new
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
        [HttpGet("PreuzmiZaposlenogZaIzmenu{matbr}")]
        public IActionResult PreuzmiZaposlenogZaIzmenu(long matbr)
        {
            try
            {
                var zaposleni = DTOManager.vratiZaposlenogZaIzmenu(matbr);

                return new JsonResult(new
                {
                    zaposleni.MaticniBroj,
                    zaposleni.LicnoIme,
                    zaposleni.Prezime,
                    zaposleni.DatumRodjenja,
                    zaposleni.DatumZaposlenja,
                    zaposleni.Plata
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("PromeniZaposlenog/{matbr}/{ime}/{prezime}/{plata}")]
        public IActionResult PromeniZaposlenog(long matbr, string ime, string prezime, int plata)
        {
            try
            {
                ZaposleniBasic izmenaZaposleni = new ZaposleniBasic()
                {
                    MaticniBroj = matbr,
                    LicnoIme = ime,
                    Prezime = prezime,
                    Plata = plata
                };

                DTOManager.izmeniZaposlenog(izmenaZaposleni);
                return Ok($"Zaposleni sa maticnim broje {matbr} uspesno izmenjen");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("DodajPodredjenog")]
        public IActionResult DodajPodredjenog([FromBody]PodredjeniDTO zaposleni)
        {
            try
            {
                if (zaposleni.Struka == "Tehnicka") DTOManager.dodajNovogPodredjenogTehnicka(zaposleni);
                else DTOManager.dodajNovogPodredjenogEkonomska(zaposleni);
                return Ok("Podredjeni dodat.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("DodajNadredjenog")]
        public IActionResult DodajNadredjenog([FromBody] NadredjeniDTO zaposleni)
        {
            try
            {
                if (zaposleni.Struka == "Tehnicka") DTOManager.dodajNovogNadredjenogTehnicka(zaposleni);
                else DTOManager.dodajNovogNadredjenogEkonomska(zaposleni);
                return Ok("Nadredjeni dodat.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}