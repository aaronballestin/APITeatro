using TeatroApi.Models;


namespace TeatroApi.Business
{
    public interface ISesionService
    {
        public List<SesionIntranetDTO> GetSesiones();
        public Sesion GetSesion(int id);
        public SesionGetAsientosDTO GetSesionDTO(int id);

        public void AddSesion(SesionPostDTO sesion);
        public void UpdateSesion(Sesion sesion);
        public void DeleteSesion(int id);

    }
}
