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


    }
}
