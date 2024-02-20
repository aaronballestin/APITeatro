using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface IObraRepository
    {
        void AddObra(Obra obra);
        Obra GetObra(int obraId);
        void UpdateObra(Obra obra);
        void RemoveObra(int asientoId);
        void SaveChanges();
        List<Obra> GetObras();
    }
}