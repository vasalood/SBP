using Microsoft.AspNetCore.Mvc;
using MotornaVozila;

namespace WebApiMotornaVozila.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NezavisnoVoziloController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiNezavisnoVozilo/{vin}")]
        public IActionResult ObrisiNezavisnoVozilo(int vin)
        {
            try
            {
                DTOManager.obrisiNezVozilo(vin);

                return Ok($"Nezavisno vozilo sa VIN brojem {vin} obrisano");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
