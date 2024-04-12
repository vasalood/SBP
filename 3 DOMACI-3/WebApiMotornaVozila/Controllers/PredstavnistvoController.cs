using Microsoft.AspNetCore.Mvc;
using MotornaVozila;

namespace WebApiMotornaVozila.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PredstavnistvoController : ControllerBase
    {
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("PreuzmiSvaPredstavnistva")]
        public IActionResult PreuzmiSvaPredstavnistva()
        {
            try
            {
                var zaposleni = DTOManager.vratiSvaPredstavnistva();
                var all = zaposleni.Select(p => new
                {
                    p.id,
                    p.grad,
                    p.adresa,
                    p.imeDirektora,
                    p.prezimeDirektora
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
        [HttpPut("PromeniPredstavnistvo/{id}/{grad}/{ime}")]
        public IActionResult PromeniPredstavnistvo(int id, string grad, string ime)
        {
            try
            {
                DTOManager.izmeniPredstavnistvo(id, grad, ime);
                return Ok($"Predstavnistvo sa id-jem {id} uspesno izmenjeno");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost("DodajPredstavnistvo")]
        public IActionResult DodajPredstavnistvo([FromBody]PredstavnistvoDTO predstavnistvo)
        {
            try
            {
                DTOManager.dodajNovoPredstavnistvo(predstavnistvo);
                return Ok("Predstavnistvo dodato.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
