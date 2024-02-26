using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TeatroApi.Models;
using TeatroApi.Business;

namespace TeatroApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SesionAsientoController : ControllerBase
    {
        private readonly ISesionAsientoService _sesionAsientoService;

        public SesionAsientoController(ISesionAsientoService sesionAsientoService)
        {
            _sesionAsientoService = sesionAsientoService;
        }

        [HttpGet("{id}")]
        public ActionResult<List<SesionAsiento>> GetSesionAsientosByAsiento(int asientoId)
        {
            var sesionAsientos = _sesionAsientoService.GetSesionAsientosByAsiento(asientoId);
            return Ok(sesionAsientos);
        }

        [HttpGet]
        public ActionResult<List<SesionAsiento>> GetSesionAsientosBySesion(int sesionId)
        {
            var sesionAsientos = _sesionAsientoService.GetSesionAsientosBySesion(sesionId);
            return Ok(sesionAsientos);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSesionAsiento(SesionAsiento sesionAsiento)
        {
            // if (id != sesionAsiento.SesionId)
            // {
            //     return BadRequest();
            // }

            // _sesionAsientoService.UpdateSesionAsiento(sesionAsiento);
            return NoContent();
        }

    }
}
