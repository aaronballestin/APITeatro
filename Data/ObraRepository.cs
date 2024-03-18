using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using TeatroApi.Models;

namespace TeatroApi.Data
{
    public class ObraRepository : IObraRepository
    {

        private readonly TeatroContext _context;
        private readonly ILogger<ObraRepository> _logger;

        public ObraRepository(ILogger<ObraRepository> logger, TeatroContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void AddObra(Obra obra)
        {

            try
            {
                _context.Obras.Add(obra);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }
        }

        public Obra GetObra(int obraId)
        {
            try
            {
                return _context.Obras.FirstOrDefault(obra => obra.ObraId == obraId);

            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }

        public ObraGetSesionDTO GetObraDTO(int obraId)
        {
            try
            {
                var obra = _context.Obras.FirstOrDefault(o => o.ObraId == obraId);

                var sesiones = _context.Sesiones.Where(s => s.ObraId == obraId)
                                                .Select(s => new SesionGetDTO(s.SesionId, s.FechaHora, s.Precio, s.SalaId))
                                                .ToList();

                var obraDTO = new ObraGetSesionDTO
                {
                    id = obra.ObraId,
                    nombre = obra.NombreObra,
                    descripcion = obra.DescripcionObra,
                    rutaFoto = obra.RutaFotoObra,
                    duracion = obra.DuracionObra,
                    sesiones = sesiones
                };

                foreach (var sesion in sesiones)
                {
                    int asientosTotales = 0;

                    var asientosOcupados = _context.DetallesCompras
                                                  .Where(d => d.SesionId == sesion.sesionId)
                                                  .Select(d => d.AsientoId)
                                                  .Distinct()
                                                  .Count();

                    var sala = _context.Salas.FirstOrDefault(s => s.SalaId == sesion.salaId);
                    if (sala != null)
                    {
                        asientosTotales += sala.AsientosNormales;
                        asientosTotales += sala.AsientosVip;
                        asientosTotales += sala.AsientosMinusvalidos;
                    }

                    sesion.asientosDisponibles = asientosTotales - asientosOcupados;
                }

                return obraDTO;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }


        /*public List<Obra> GetObras()
        {
            var obras = _context.Obras.ToList();
            return obras;
        }*/

        public List<ObraGetDTO> GetObras()
        {
            try
            {
                var obras = _context.Obras.ToList();
                var obrasDTO = new List<ObraGetDTO>();
                foreach (var obra in obras)
                {
                    var obraDTO = new ObraGetDTO
                    {
                        id = obra.ObraId,
                        nombre = obra.NombreObra,
                        descripcion = obra.DescripcionObra,
                        rutaFoto = obra.RutaFotoObra,
                        duracion = obra.DuracionObra
                    };
                    obrasDTO.Add(obraDTO);
                }
                return obrasDTO;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }

        public void UpdateObra(Obra obra)
        {
            try
            {
                _context.Entry(obra).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }

        public void RemoveObra(int obraId)
        {
            try
            {
                var account = GetObra(obraId);
                if (account is null)
                {
                    throw new KeyNotFoundException("Account not found.");
                }
                _context.Sesiones.Where(s => s.ObraId == obraId)
                                .ToList();

                _context.Obras.Remove(account);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }


        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}