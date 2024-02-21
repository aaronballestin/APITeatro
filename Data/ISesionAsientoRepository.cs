using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface ISesionAsientoRepository
    {
        void AddSesionAsiento(SesionAsiento sesionAsiento);

        //De momento hacemos que no salga la compra por id porque no tiene PK        
        // Compra GetCompra(int compraId);
        
        List<SesionAsiento> GetSesionAsientosByAsiento(int asientoId);
        List<SesionAsiento> GetSesionAsientosBySesion(int sesionId);
        void UpdateSesionAsiento(SesionAsiento sesionAsiento);

        //De momento hacemos que no salga la compra por id porque no tiene PK        
        // void RemoveCompra(int compraId);

        void SaveChanges();
        List<SesionAsiento> GetSesionAsientos();
    }
}