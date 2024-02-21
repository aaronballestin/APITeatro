using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface ISesionRepository
    {
        void AddSesion(Sesion asiento);
        Sesion GetSesion(int asientoId);
        void UpdateSesion(Sesion asiento);
        void RemoveSesion(int asientoId);
        void SaveChanges();
        List<Sesion> GetSesion();
    }
}
