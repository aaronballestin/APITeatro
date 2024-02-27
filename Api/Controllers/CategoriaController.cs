using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TeatroApi.Models;
using TeatroApi.Business;

namespace TeatroApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]
        public ActionResult<List<Categoria>> GetCategoria()
        {
            var categorias = _categoriaService.GetCategorias();
            return Ok(categorias);
        }

        [HttpGet("{id}")]
        public ActionResult<CategoriaGetDTO> GetCategoria(int id)
        {
            var categoria = _categoriaService.GetCategoriaDTO(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return Ok(categoria);
            
        }

        [HttpPost]
        public ActionResult AddCategoria(Categoria categoria)
        {
            _categoriaService.AddCategoria(categoria);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateObra(int id, Categoria categoria)
        {
            if (id != categoria.CategoriaId)
            {
                return BadRequest();
            }

            _categoriaService.UpdateCategoria(categoria);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveCategoria(int id)
        {
            _categoriaService.RemoveCategoria(id);
            return NoContent();
        }
    }
}
