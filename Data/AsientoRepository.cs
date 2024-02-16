using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;

namespace TeatroApi.Data
{
    public class AsientoRepository : IAsientoRepository
    {

        private readonly TeatroContext _context;
        public AsientoRepository(TeatroContext context)
        {
            _context = context;
        }

        public void AddAsiento(Asiento asiento)
        {
            _context.Asientos.Add(asiento);
        }

        public Asiento GetAsiento(int asientoId)
        {
            return _context.Asientos.FirstOrDefault(asiento => asiento.AsientoId == asientoId);
        }

        // public List<Asiento> GetAsientos()
        // {
        //     return _context.Asientos;
        // }

        public void UpdateAsiento(Asiento asiento)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(asiento).State = EntityState.Modified;
        }

        public void RemoveAsiento(int asientoId)
        {
            var account = GetAsiento(asientoId);
            if (account is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Asientos.Remove(account);
            SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}