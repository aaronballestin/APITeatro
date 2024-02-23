using TeatroApi.Models;

namespace TeatroApi.Business
{
    public interface ISesionAsientoService
    {
        public List<SesionAsiento> GetSesionAsientosByAsiento(int asientoId); 
        public List<SesionAsiento> GetSesionAsientosBySesion(int sesionId);       

    }
}
