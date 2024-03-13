using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;
using Microsoft.Extensions.Logging;


namespace TeatroApi.Data
{
    public class SesionRepository : ISesionRepository
    {

        private readonly TeatroContext _context;

        private readonly ILogger<SesionRepository> _logger;

        public SesionRepository(ILogger<SesionRepository> logger, TeatroContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void AddSesion(Sesion sesion)
        {
            try
            {
                _context.Sesiones.Add(sesion);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }
        }

        public Sesion GetSesion(int sesionId)
        {
            try
            {
                return _context.Sesiones.FirstOrDefault(sesion => sesion.SesionId == sesionId);

            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }

        public SesionGetAsientosDTO GetSesionDTO(int sesionId)
        {
            try
            {
                var sesion = _context.Sesiones.FirstOrDefault(sesion => sesion.SesionId == sesionId);
                var obra = _context.Obras.FirstOrDefault(obra => obra.ObraId == sesion.ObraId);

                var sesionDTO = new SesionGetAsientosDTO(sesion.SesionId, sesion.SalaId, sesion.ObraId, obra.NombreObra, sesion.FechaHora, sesion.Precio);

                var sala = _context.Salas.FirstOrDefault(sala => sala.SalaId == sesion.SalaId);
                sesionDTO.sala = new SalaSesionDTO {asientosMinusvalidos = sala.AsientosMinusvalidos, asientosVip = sala.AsientosVip, asientosNormales = sala.AsientosNormales};

                return sesionDTO;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }


        }

        public List<SesionIntranetDTO> GetSesiones()
        {
            try
            {
                var sesiones = _context.Sesiones.ToList();
                var obras = _context.Obras.ToList();

                var sesionesDTO = new List<SesionIntranetDTO>();

                foreach (var sesion in sesiones)
                {
                    string nombreObra = obras.FirstOrDefault(o => o.ObraId == sesion.ObraId).NombreObra;
                    SesionIntranetDTO sesionIntranetDTO = new SesionIntranetDTO(sesion.SesionId, sesion.ObraId, sesion.SalaId, sesion.FechaHora, nombreObra, sesion.Precio);

                    sesionesDTO.Add(sesionIntranetDTO);
                }

                return sesionesDTO;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }


        }

        public void UpdateSesion(Sesion sesionId)
        {
            try
            {
                _context.Entry(sesionId).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }

        }

        public void RemoveSesion(int sesionId)
        {
            try
            {
                var account = GetSesion(sesionId);
                if (account is null)
                {
                    throw new KeyNotFoundException("Account not found.");
                }
                _context.Sesiones.Remove(account);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }


        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}