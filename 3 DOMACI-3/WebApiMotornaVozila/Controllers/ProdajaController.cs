using Microsoft.AspNetCore.Mvc;
using MotornaVozila;

namespace WebApiMotornaVozila.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdajaController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("ObrisiProdaju{prodajaID}")]
        public IActionResult ObrisiProdaju(int prodajaID)
        {
            try
            {
                DTOManager.obrisiProdaju(prodajaID);

                return Ok($"Prodaja sa id-em {prodajaID} obrisana");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("ObaviProdaju")]
        public IActionResult ObaviProdaju(ProdajaDTO prodaja)
        {
            try
            {
                DTOManager.obaviProdaju(prodaja);

                return Ok("Prodaja obavljena");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
