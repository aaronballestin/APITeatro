using TeatroApi.Models;

namespace TeatroApi.Business
{
    public interface IObraService
    {
        public List<Obra> GetObras();

        public Obra GetObra(int obraId);

        public void UpdateObra(Obra obra);

        public void DeleteObra(int obraId);
        
    }
}
