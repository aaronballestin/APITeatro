using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TeatroApi.Models;
using TeatroApi.Business;


namespace TeatroApi.Api
{

    [ApiController]
    [Route("[controller]")]
    public class authController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public authController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }



        [HttpPost("/login")]
        public ActionResult<UsuarioGetDTO> GetUsuario(UsuarioLoginDTO usuarioLoginDTO)
        {
            
            var sesion = _usuarioService.GetUsuario(usuarioLoginDTO.email, usuarioLoginDTO.password);
            if (sesion == null)
            {
                return NotFound();
            }
            return Ok(sesion);

        }


        [HttpPost("/register")]
        public ActionResult<int> AddUsuario(UsuarioPostDTO usuarioDTO)
        {
            var usuario = new Usuario {NombreUsuario = usuarioDTO.nombre, EmailUsuario = usuarioDTO.email, PasswordUsuario = usuarioDTO.password, Rol = "Guest"};
            var usuarioId = _usuarioService.AddUsuario(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = usuarioId }, usuario);
        }



    
    }
}