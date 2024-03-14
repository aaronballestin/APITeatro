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
            _context.Compras.Add(compra);
            
        }

        //De momento hacemos que no salga la compra por id porque no tiene PK        
        /*public Entrada GetCompra(int compraId)
        {
            return _context.Entradas.FirstOrDefault(compra => compra.compraId == compraId);
        }*/

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