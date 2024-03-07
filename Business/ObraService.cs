using System.Collections.Generic;
using TeatroApi.Models;
using TeatroApi.Data;

namespace TeatroApi.Business
{
    public class ObraService : IObraService
    {
        private readonly IObraRepository _obraRepository;

        public ObraService(IObraRepository obraRepository)
        {
            _obraRepository = obraRepository;
        }

        public List<ObraGetDTO> GetObras()
        {
            return _obraRepository.GetObras();
        }

        // public List<Obra> GetObrasByCategoria(int categoriaId){
        //     List<Obra> obrasByCategoria = new List<Obra>();

        //     List<Obra> obras = _obraRepository.GetObras();

        //     foreach (var obra in obras)
        //     {
        //         if(obra.CategoriaId == categoriaId){
        //             obrasByCategoria.Add(obra);
        //         }
        //     }

        //     return obrasByCategoria;
        // }

        public ObraGetSesionDTO GetObra(int obraId)
        {
            return _obraRepository.GetObraDTO(obraId);
        }

        public Obra GetObraById(int obraId)
        {
            return _obraRepository.GetObra(obraId);
        }

        public int AddObra(Obra obra)
        {
            _obraRepository.AddObra(obra);
            _obraRepository.SaveChanges();
            return obra.ObraId;
        }

        public void UpdateObra(Obra obra)
        {
            _obraRepository.UpdateObra(obra);
            _obraRepository.SaveChanges();
        }

        public void DeleteObra(int obraId)
        {
            _obraRepository.RemoveObra(obraId);
            _obraRepository.SaveChanges();
        }



    }
}
