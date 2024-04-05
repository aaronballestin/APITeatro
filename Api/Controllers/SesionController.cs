using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TeatroApi.Models;
using TeatroApi.Business;

namespace TeatroApi.Api
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
        public ActionResult<List<SesionIntranetDTO>> GetSesiones()
        {
            var sesiones = _sesionService.GetSesiones();
            return Ok(sesiones);
        }

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
        public ActionResult AddSesion(SesionPostDTO sesionDTO)
        {
            // var sesion = new Sesion {FechaHora = sesionDTO.horario, SalaId = sesionDTO.salaId, Precio = sesionDTO.precio, AuditoriaUsuario = sesionDTO.auditoriaUsuario, AuditoriaHorario = DateTime.Now};
             try{
             _sesionService.AddSesion(sesionDTO);
                return Ok();

             }catch(Exception e){
                return BadRequest("No se ha podido añadir una sesion");

             }
            
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSesion(int id, SesionPutDTO sesionDTO)
        {
            var sesion = _sesionService.GetSesion(id);
            if (id != sesion.SesionId)
            {
                return BadRequest();
            }
            sesion.SalaId = sesionDTO.salaId;
            sesion.FechaHora = sesionDTO.horario; 
            sesion.Precio = sesionDTO.precio;
            sesion.AuditoriaUsuario = sesionDTO.auditoriaUsuario;
            sesion.AuditoriaHorario = DateTime.Now;

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
