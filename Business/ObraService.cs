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

        public List<ObraGetDTO> GetObraBuscador(string nombre)
        {
            return _obraRepository.GetObras().Where(o => o.nombre.ToUpper().StartsWith(nombre.ToUpper())).ToList();
        }


        public Obra GetObraById(int obraId)
        {
            return _obraRepository.GetObra(obraId);
        }

        public int AddObra(Obra obra)
        {
            _obraRepository.AddObra(obra);
            return obra.ObraId;
        }

        public void UpdateObra(Obra obra)
        {
            _obraRepository.UpdateObra(obra);
        }

        public void DeleteObra(int obraId)
        {
            _obraRepository.RemoveObra(obraId);
        }



    }
}
