using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;

namespace TeatroApi.Data
{
    public class SesionRepository : ISesionRepository
    {

        private readonly TeatroContext _context;
        public SesionRepository(TeatroContext context)
        {
            _context = context;
        }

        public void AddSesion(Sesion sesion)
        {
            _context.Sesiones.Add(sesion);
        }

        public Sesion GetSesion(int sesionId)
        {
            return _context.Sesiones.FirstOrDefault(sesion => sesion.SesionId == sesionId);
        }

        public SesionGetAsientosDTO GetSesionDTO (int sesionId){
            var sesion = _context.Sesiones.FirstOrDefault(sesion => sesion.SesionId == sesionId);
            var obra = _context.Obras.FirstOrDefault(obra => obra.ObraId == sesion.ObraId);

            var sesionDTO = new SesionGetAsientosDTO(sesion.SesionId, sesion.SalaId, sesion.ObraId, obra.NombreObra, sesion.FechaHora, sesion.Precio);


            var asientos = new List<Asiento>();
            
            sesionDTO.asientos = _context.Asientos.Where(o => o.SalaId == sesion.SalaId)
                                                    .Select(o => new AsientoGetDTO(o.AsientoId, o.TipoAsiento, o.Suplemento))
                                                    .ToList();

            
            
            return sesionDTO;
        }

        public List<SesionIntranetDTO> GetSesiones()
        {
            var sesiones = _context.Sesiones.ToList();
            var obras = _context.Obras.ToList();

            var sesionesDTO = new List<SesionIntranetDTO>();

            foreach (var sesion in sesiones)
            {
                string nombreObra = obras.FirstOrDefault(o => o.ObraId == sesion.ObraId).NombreObra;
                SesionIntranetDTO sesionIntranetDTO = new SesionIntranetDTO (sesion.SesionId, sesion.ObraId, sesion.SalaId, sesion.FechaHora, nombreObra, sesion.Precio); 

                sesionesDTO.Add(sesionIntranetDTO);
            }

            return sesionesDTO;
        }

        public void UpdateSesion(Sesion sesionId)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(sesionId).State = EntityState.Modified;
        }

        public void RemoveSesion(int sesionId)
        {
            var account = GetSesion(sesionId);
            if (account is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Sesiones.Remove(account);
            SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}