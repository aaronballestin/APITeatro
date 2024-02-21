using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;

namespace TeatroApi.Data
{
    public class SesionAsientoRepository : ISesionAsientoRepository
    {

        private readonly TeatroContext _context;
        public SesionAsientoRepository(TeatroContext context)
        {
            _context = context;
        }

        public void AddSesionAsiento(SesionAsiento sesionAsiento)
        {
            _context.SesionAsientos.Add(sesionAsiento);
        }

        //De momento hacemos que no salga la compra por id porque no tiene PK        
        /*public Entrada GetCompra(int compraId)
        {
            return _context.Entradas.FirstOrDefault(compra => compra.compraId == compraId);
        }*/

        public List<SesionAsiento> GetSesionAsientos()
        {
            return _context.SesionAsientos.ToList();
        }

        public List<SesionAsiento> GetSesionAsientosBySesion(int sesionId)
        {
            var sesionAsientos = _context.SesionAsientos
                            .Where(sesionAsiento => sesionAsiento.SesionId == sesionId)
                            .ToList();

            return sesionAsientos;
        }

        public List<SesionAsiento> GetSesionAsientosByAsiento(int asientoId)
        {
            var sesionAsientos = _context.SesionAsientos
                            .Where(sesionAsiento => sesionAsiento.AsientoId == asientoId)
                            .ToList();

            return sesionAsientos;
        }
        public void UpdateSesionAsiento(SesionAsiento sesionAsiento)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(sesionAsiento).State = EntityState.Modified;
        }


        //De momento no hago este porque Compra no tiene Id

        /*public void RemoveCompra( )
        {
            var account = GetEntrada();
            if (account is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Entradas.Remove(account);
            SaveChanges();

        }*/

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}