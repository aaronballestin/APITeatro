using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TeatroApi.Models;
using TeatroApi.Business;

namespace TeatroApi.Api
{
    [ApiController]
    [Route("[controller]")]
    public class ObraController : ControllerBase
    {
        private readonly IObraService _obraService;

        public ObraController(IObraService obraService)
        {
            _obraService = obraService;
        }

        [HttpGet]
        public ActionResult<List<ObraGetDTO>> GetObras()
        {
            var obras = _obraService.GetObras();
            return Ok(obras);
        }

        [HttpGet("{id}")]
        public ActionResult<ObraGetSesionDTO> GetObra(int id)
        {
            var obra = _obraService.GetObra(id);
            if (obra == null)
            {
                return NotFound();
            }
            return Ok(obra);
            
        }

        [HttpPost]
        public ActionResult<int> AddObra(ObraPostDTO obraDTO)
        {
            var obra = new Obra {NombreObra = obraDTO.nombre, DescripcionObra = obraDTO.descripcion, RutaFotoObra = obraDTO.rutaFoto, AuditoriaUsuario = obraDTO.auditoriaUsuario,  AuditoriaHorario = DateTime.Now};
            var newObraId = _obraService.AddObra(obra);
            return CreatedAtAction(nameof(GetObra), new { id = newObraId }, obra);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateObra(int id, ObraPostDTO obraDTO)
        {
            Obra obra = _obraService.GetObraById(id);
            if (id != obra.ObraId)
            {
                return BadRequest();
            }

            obra.NombreObra = obraDTO.nombre;
            obra.DescripcionObra = obraDTO.descripcion;
            obra.RutaFotoObra = obraDTO.rutaFoto;
            obra.AuditoriaUsuario = obraDTO.auditoriaUsuario;
            obra.AuditoriaHorario = DateTime.Now;
            
            _obraService.UpdateObra(obra);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteObra(int id)
        {
            _obraService.DeleteObra(id);
            return NoContent();
        }
    }
}
