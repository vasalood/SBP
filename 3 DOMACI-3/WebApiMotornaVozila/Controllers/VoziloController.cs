using Microsoft.AspNetCore.Mvc;
using MotornaVozila;

namespace WebApiMotornaVozila.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VoziloController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiSvaVozila")]
        public IActionResult PreuzmiSvaVozila()
        {
            try
            {
                var vozila = DTOManager.vratiSvaVozila();
                var all = vozila.Select(p => new
                {
                    p.id,
                    p.brSasije,
                    p.brMotora,
                    p.model,
                    p.kubikaza,
                    p.putnicko,
                    p.teretno,
                    p.boja
                }).ToList();
                return new JsonResult(all);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiVozilo{BrSasije}")]
        public IActionResult ObrisiVozilo(string BrSasije)
        {
            try
            {
                DTOManager.obrisiVoziloIzSistema(BrSasije);
                return Ok($"Vozilo sa brojem sasije {BrSasije} obrisano");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("DodajVozilo")]
        public IActionResult DodajVozilo([FromBody]VoziloDTO vozilo)
        {
            try
            {
                DTOManager.dodajVozilo(vozilo);
                return Ok($"Vozilo je dodato.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
