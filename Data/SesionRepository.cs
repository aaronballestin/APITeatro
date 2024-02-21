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

        public List<Sesion> GetSesion()
        {
            return _context.Sesiones.ToList();
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