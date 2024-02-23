using TeatroApi.Data;
using TeatroApi.Models;

namespace TeatroApi.Business
{
    public class SesionAsientoService : ISesionAsientoService
    {
        private readonly ISesionAsientoRepository _repository;

        public SesionAsientoService(ISesionAsientoRepository repository)
        {
            _repository = repository;
        }

        public List<SesionAsiento> GetSesionAsientosBySesion(int sesionId){
            return _repository.GetSesionAsientosBySesion(sesionId);
        }

        
        public List<SesionAsiento> GetSesionAsientosByAsiento(int asientoId){
            return _repository.GetSesionAsientosByAsiento(asientoId);
        }

    }
}