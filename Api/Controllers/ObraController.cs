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
            try
            {
                var obras = _obraService.GetObras();
                return Ok(obras);

            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obras disponibles");
            }

        }

        [HttpGet("{id}")]
        public ActionResult<ObraGetSesionDTO> GetObra(int id)
        {
            
            try
            {
                var obra = _obraService.GetObra(id);
                return Ok(obra);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound("No hay obra disponible con el id: " + id);

            }



        }

        [HttpPost]
        public ActionResult<int> AddObra(ObraPostDTO obraDTO)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            try
            {
                var obra = new Obra { NombreObra = obraDTO.nombre, DescripcionObra = obraDTO.descripcion, RutaFotoObra = obraDTO.rutaFoto, AuditoriaUsuario = obraDTO.auditoriaUsuario, AuditoriaHorario = DateTime.Now, DuracionObra = obraDTO.duracion };
                var newObraId = _obraService.AddObra(obra);
                return CreatedAtAction(nameof(GetObra), new { id = newObraId }, obra);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }



        }

        [HttpPut("{id}")]
        public IActionResult UpdateObra(int id, ObraPostDTO obraDTO)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                Obra obra = _obraService.GetObraById(id);
                if (id != obra.ObraId)
                {
                    return BadRequest();
                }

                obra.NombreObra = obraDTO.nombre;
                obra.DescripcionObra = obraDTO.descripcion;
                obra.RutaFotoObra = obraDTO.rutaFoto;
                obra.DuracionObra = obraDTO.duracion;
                obra.AuditoriaUsuario = obraDTO.auditoriaUsuario;
                obra.AuditoriaHorario = DateTime.Now;
                _obraService.UpdateObra(obra);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteObra(int id)
        {
            try
            {
                _obraService.DeleteObra(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {

                return NotFound();
            }

        }
    }
}
