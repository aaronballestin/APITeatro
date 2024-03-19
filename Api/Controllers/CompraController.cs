using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TeatroApi.Models;
using TeatroApi.Business;


namespace TeatroApi.Api
{

    [ApiController]
    [Route("[controller]")]
    public class CompraController : ControllerBase
    {
        private readonly ICompraService _compraService;

        public CompraController(ICompraService compraService)
        {
            _compraService = compraService;
        }




        [HttpPost]
        public ActionResult AddCompra(CompraPostDTO compraDTO)
        {
            try
            {
                var result = _compraService.AddCompra(compraDTO);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(500, $"Error interno del servidor: {e.Message}");
            }


        }

        [HttpGet("{id}")]

        public ActionResult<CompraDTO> GetCompra(int id)
        {
            var compra = _compraService.GetCompra(id);
            if (compra == null)
            {
                return NotFound();
            }

            return Ok(compra);
        }

        [HttpGet]
        public ActionResult<List<CompraDTO>> GetCompras()
        {
            var compras = _compraService.GetCompras();
            return Ok(compras);
        }


    }
}