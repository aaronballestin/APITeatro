using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface ISesionAsientoRepository
    {
        void AddSesionAsiento(SesionAsiento sesionAsiento);


        List<SesionAsiento> GetSesionAsientosByAsiento(int asientoId);
        List<SesionAsiento> GetSesionAsientosBySesion(int sesionId);
        void UpdateSesionAsiento(SesionAsiento sesionAsiento);


        void SaveChanges();
        List<SesionAsiento> GetSesionAsientos();
    }
}