using TeatroApi.Models;

namespace TeatroApi.Business
{
    public interface ICompraService
    {
        public List<Compra> GetComprasByUsuario(int usuarioId); 
        public List<Compra> GetComprasBySesion(int sesionId);       

    }
}
