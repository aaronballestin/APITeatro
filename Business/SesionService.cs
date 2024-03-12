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

        public List<SesionIntranetDTO> GetSesiones()
        {
            return _repository.GetSesiones();
        }

        public Sesion GetSesion(int id)
        {
            return _repository.GetSesion(id);
        }

        public SesionGetAsientosDTO GetSesionDTO(int id)
        {
            return _repository.GetSesionDTO(id);
        }

        public int AddSesion(Sesion sesion)
        {
            _repository.AddSesion(sesion);
            return sesion.ObraId;
        }

        public void UpdateSesion(Sesion sesion)
        {
            _repository.UpdateSesion(sesion);
        }

        public void DeleteSesion(int id)
        {
            _repository.RemoveSesion(id);
        }

    }
}
