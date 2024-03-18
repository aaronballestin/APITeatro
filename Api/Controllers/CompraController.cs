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



        /*[HttpGet]
        public ActionResult<CompraGetDTO> GetCom(string usuario, string password)
        {
            var sesion = _usuarioService.GetUsuario(usuario, password);
            if (sesion == null)
            {
                return NotFound();
            }
            return Ok(sesion);

        }*/

        
        /*[HttpGet("{id}")]
        public ActionResult<UsuarioGetCompras> GetUsuario(int id)
        {
            var usuario = _usuarioService.GetUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }*/


        [HttpPost]
        public ActionResult AddCompra(CompraPostDTO comprasDTO)
        {
            foreach (var asiento in comprasDTO.asientos)
            {
                var compra = new Compra {SesionId = comprasDTO.sesionId, AsientoId = asiento, UsuarioId = comprasDTO.usuarioId};
                _compraService.AddCompra(compra);

            }
            

        }



    
    }
}