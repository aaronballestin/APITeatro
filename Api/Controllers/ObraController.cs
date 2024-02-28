using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TeatroApi.Models;
using TeatroApi.Business;

namespace TeatroApi.Controllers
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
        public ActionResult<List<Obra>> GetObras()
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
        public ActionResult<int> AddObra(Obra obra)
        {
            var newObraId = _obraService.AddObra(obra);
            return CreatedAtAction(nameof(GetObra), new { id = newObraId }, obra);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateObra(int id, Obra obra)
        {
            if (id != obra.ObraId)
            {
                return BadRequest();
            }

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
