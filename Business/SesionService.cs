using TeatroApi.Data;
using TeatroApi.Models;

namespace TeatroApi.Business
{
    public class SesionService : ISesionService
    {
        private readonly ISesionRepository _repository;

        public SesionService(ISesionRepository repository)
        {
            _repository = repository;
        }

        
    }
}
