using TeatroApi.Data;
using TeatroApi.Models;

namespace TeatroApi.Business
{
    public class CompraService : ICompraService
    {
        private readonly ICompraRepository _repository;

        public CompraService(ICompraRepository repository)
        {
            _repository = repository;
        }

        public List<Compra> GetComprasBySesion(int sesionId){
            return _repository.GetComprasBySesion(sesionId);
        }

        
        public List<Compra> GetComprasByUsuario(int usuarioId){
            return _repository.GetComprasByUsuario(usuarioId);
        }

    }
}
