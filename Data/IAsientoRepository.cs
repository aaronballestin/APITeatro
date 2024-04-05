using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface IAsientoRepository
    {
        void AddAsiento(Asiento asiento);
        Asiento GetAsiento(int asientoId);
        void UpdateAsiento(Asiento asiento);
        void RemoveAsiento(int asientoId);
        void SaveChanges();
        List<AsientoDTO> GetAsientos();
    }
}