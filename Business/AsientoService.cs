using TeatroApi.Data;
using TeatroApi.Models;

namespace TeatroApi.Business
{
    public class AsientoService : IAsientoService
    {
        private readonly IAsientoRepository _repository;

        public AsientoService(IAsientoRepository repository)
        {
            _repository = repository;
        }

        
    }
}
