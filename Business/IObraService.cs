using TeatroApi.Models;

namespace TeatroApi.Business
{
    public interface IObraService
    {
        public List<ObraGetDTO> GetObras();
        public ObraGetSesionDTO GetObra(int obraId);
        public Obra GetObraById (int id);
        public void UpdateObra(Obra obra);
        public void DeleteObra(int obraId);

        public int AddObra (Obra obra);
        // public void GetAsientosObra(int obraId);

        //estaria bien añadir que las obras salgan ordenadas según la fecha (supongo que se programa en repository)
        
    }
}
