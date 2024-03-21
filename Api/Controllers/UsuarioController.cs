using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TeatroApi.Models;
using TeatroApi.Business;


namespace TeatroApi.Api
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }




        
        [HttpGet]
        public ActionResult<List<UsuarioDTO>> GetUsuario()
        {
            var sesion = _usuarioService.GetUsuarios();
            if (sesion == null)
            {
                return NotFound();
            }
            return Ok(sesion);

        }

        
        [HttpGet("{id}")]
        public ActionResult<UsuarioGetCompras> GetUsuario(int id)
        {
            var usuario = _usuarioService.GetUsuario(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }


        [HttpPost]
        public ActionResult<int> AddUsuario(UsuarioPostDTO usuarioDTO)
        {
            var usuario = new Usuario {NombreUsuario = usuarioDTO.nombre, EmailUsuario = usuarioDTO.email, PasswordUsuario = usuarioDTO.password, Rol = "Guest"};
            var usuarioId = _usuarioService.AddUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = usuarioId }, usuario);
        }



    
    }
}