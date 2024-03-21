using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface ISesionRepository
    {
        void AddSesion(SesionPostDTO asiento);
        Sesion GetSesion(int asientoId);
        SesionGetAsientosDTO GetSesionDTO(int asientoId);

        void UpdateSesion(Sesion asiento);
        void RemoveSesion(int asientoId);
        void SaveChanges();
        List<SesionIntranetDTO> GetSesiones();

    }
}
