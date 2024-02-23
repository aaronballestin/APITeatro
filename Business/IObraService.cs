using TeatroApi.Models;

namespace TeatroApi.Business
{
    public interface IObraService
    {
        public List<Obra> GetObras();
        public Obra GetObra(int obraId);
        public List<Obra> GetObrasByCategoria(int categoriaId);
        public void UpdateObra(Obra obra);
        public void DeleteObra(int obraId);

        public int AddObra (Obra obra);
        // public void GetAsientosObra(int obraId);

        //estaria bien añadir que las obras salgan ordenadas según la fecha (supongo que se programa en repository)
        
    }
}
