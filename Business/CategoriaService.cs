using TeatroApi.Data;
using TeatroApi.Models;

namespace TeatroApi.Business
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public Categoria GetCategoria(int categoriaId){
           return  _repository.GetCategoria(categoriaId);
        }

        
    }
}
