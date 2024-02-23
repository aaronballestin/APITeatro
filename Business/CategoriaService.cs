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


        public void AddCategoria(Categoria categoria)
        {
            _repository.AddCategoria(categoria);
        }

        public List<Categoria> GetCategorias()
        {
            return _repository.GetCategorias();
        }

        public void UpdateCategoria(Categoria categoria)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _repository.UpdateCategoria(categoria);
        }

        public void RemoveCategoria(int categoriaId)
        {
            _repository.RemoveCategoria(categoriaId);

        }
        public void SaveChanges()
        {
            _repository.SaveChanges();
        }

        public List<Obra> GetObrasByCategoria(int categoriaId){
            return _repository.GetObrasByCategoria(categoriaId);
        }
    }

        
    
}
