using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;

namespace TeatroApi.Data
{
    public class EntradaRepository : IEntradaRepository
    {

        private readonly TeatroContext _context;
        public EntradaRepository(TeatroContext context)
        {
            _context = context;
        }

        public void AddEntrada(Entrada entrada)
        {
            _context.Entradas.Add(entrada);
        }

        public Entrada GetEntrada(int entradaId)
        {
            return _context.Entradas.FirstOrDefault(entrada => entrada.EntradaId == entradaId);
        }

        public List<Entrada> GetEntradas()
        {
            return _context.Entradas.ToList();
        }

        public void UpdateEntrada(Entrada entrada)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(entrada).State = EntityState.Modified;
        }

        public void RemoveEntrada(int categoriaId)
        {
            var account = GetEntrada(categoriaId);
            if (account is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Entradas.Remove(account);
            SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}