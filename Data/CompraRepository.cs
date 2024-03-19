using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;

namespace TeatroApi.Data
{
    public class CompraRepository : ICompraRepository
    {

        private readonly TeatroContext _context;
        public CompraRepository(TeatroContext context)
        {
            _context = context;
        }

        public void AddCompra(Compra compra)
        {
            try
            {
                _context.Compras.Add(compra);
                SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                throw;
            }


        }

        public void AddDetallesCompra(DetallesCompra compra)
        {
            _context.DetallesCompras.Add(compra);
            SaveChanges();


        }


        public List<Compra> GetCompras()
        {
            return _context.Compras.ToList();
        }

        public List<Compra> GetComprasBySesion(int sesionId)
        {
            var compras = _context.Compras
                            .Where(compra => compra.SesionId == sesionId)
                            .ToList();

            return compras;
        }

        public List<Compra> GetComprasByUsuario(int usuarioId)
        {
            var compras = _context.Compras
                            .Where(compra => compra.UsuarioId == usuarioId)
                            .ToList();

            return compras;
        }
        public void UpdateCompra(Compra compra)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(compra).State = EntityState.Modified;
        }



        public Compra GetCompra(int compraId)
        {
            return _context.Compras.FirstOrDefault(c => c.CompraId == compraId);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}