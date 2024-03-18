using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface ICompraRepository
    {
        void AddCompra(Compra compra);

        //De momento hacemos que no salga la compra por id porque no tiene PK        
        Compra GetCompra(int compraId);
        
        List<Compra> GetComprasBySesion(int obraId);
        List<Compra> GetComprasByUsuario(int usuarioId);
        void UpdateCompra(Compra compra);

        //De momento hacemos que no salga la compra por id porque no tiene PK        
        // void RemoveCompra(int compraId);

        void SaveChanges();
        List<Compra> GetCompras();
    }
}