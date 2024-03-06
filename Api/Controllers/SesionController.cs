using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TeatroApi.Models;
using TeatroApi.Business;

namespace TeatroApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SesionController : ControllerBase
    {
        private readonly ISesionService _sesionService;

        public SesionController(ISesionService sesionService)
        {
            _sesionService = sesionService;
        }

        [HttpGet]
        public ActionResult<List<Sesion>> GetSesiones()
        {
            var sesiones = _sesionService.GetSesiones();
            return Ok(sesiones);
        }

        /*[HttpGet("{id}")]
        public ActionResult<Sesion> GetSesion(int id)
        {
            var sesion = _sesionService.GetSesion(id);
            if (sesion == null)
            {
                return NotFound();
            }
            return Ok(sesion);

        }*/

        [HttpGet("{id}")]
        public ActionResult<SesionGetAsientosDTO> GetSesion(int id)
        {
            var sesion = _sesionService.GetSesionDTO(id);
            if (sesion == null)
            {
                return NotFound();
            }
            return Ok(sesion);

        }

        [HttpPost]
        public ActionResult<int> AddSesion(SesionPostDTO sesionDTO)
        {
            var sesion = new Sesion {ObraId = sesionDTO.obraId, FechaHora = sesionDTO.horario, SalaId = sesionDTO.salaId};
            var newSesionId = _sesionService.AddSesion(sesion);
            return CreatedAtAction(nameof(GetSesion), new { id = newSesionId }, sesion);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSesion(int id, Sesion sesion)
        {
            if (id != sesion.SesionId)
            {
                return BadRequest();
            }

            _sesionService.UpdateSesion(sesion);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSesion(int id)
        {
            _sesionService.DeleteSesion(id);
            return NoContent();
        }
    }
}
