using TeatroApi.Data;
using TeatroApi.Models;

namespace TeatroApi.Business
{
    public class EntradaService : IEntradaService
    {
        private readonly IEntradaRepository _repository;

        public EntradaService(IEntradaRepository repository)
        {
            _repository = repository;
        }

        public List<Entrada> GetEntradasByObra(int obraId){
            return _repository.GetEntradasByObra(obraId);
        }

        
        public List<Entrada> GetEntradasByUsuario(int usuarioId){
            return _repository.GetEntradasByObra(usuarioId);
        }

    }
}
