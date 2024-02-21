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

        public List<Obra> GetObras()
        {
            return _obraRepository.GetObras();
        }

        public Obra GetObra(int obraId)
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
