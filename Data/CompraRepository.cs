using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;
using Microsoft.Extensions.Logging;

namespace TeatroApi.Data
{
    public class CompraRepository : ICompraRepository
    {

        private readonly TeatroContext _context;
        private readonly ILogger<SesionRepository> _logger;

        public CompraRepository(TeatroContext context)
        {
            _context = context;
        }

        public int AddCompra(CompraPostDTO compraDTO)
        {
            try
            {
                
                var asientosCompra = new AsientoRepository(_context);
                var sesion = new SesionRepository( _logger, _context);

                double sumatorio = 0;
                foreach (var asientoId in compraDTO.asientos)
                {
                    sumatorio =+ asientosCompra.GetAsientos().FirstOrDefault(a => a.id == asientoId).suplemento;
                    
                }
                sumatorio =+ sesion.GetSesionDTO(compraDTO.sesionId).precio;
                var compra = new Compra{SesionId = compraDTO.sesionId, FechaCompra = DateTime.Now, PrecioCompra = sumatorio, UsuarioId = compraDTO.usuarioId};
                _context.Compras.Add(compra);

                return compra.CompraId;
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