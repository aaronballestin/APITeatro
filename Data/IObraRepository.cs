using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface IObraRepository
    {
        void AddObra(Obra obra);
        Obra GetObra(int obraId);
        ObraGetSesionDTO GetObraDTO(int obraId);

        void UpdateObra(Obra obra);
        void RemoveObra(int asientoId);
        void SaveChanges();
        List<ObraGetDTO> GetObras();
        List<ObraGetDTO> GetObrasIntranet();


    }
}