using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface ICompraRepository
    {
        void AddCompra(Compra compra);

       
        Compra GetCompra(int compraId);
        
        List<Compra> GetComprasBySesion(int obraId);
        List<Compra> GetComprasByUsuario(int usuarioId);
        void UpdateCompra(Compra compra);
        void AddDetallesCompra(DetallesCompra detallesCompra);


        void SaveChanges();
        List<Compra> GetCompras();
    }
}