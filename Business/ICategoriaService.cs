using TeatroApi.Models;

namespace TeatroApi.Business
{
    public interface ICategoriaService
    {
        public List<Categoria> GetCategorias();
        public Categoria GetCategoria(int categoriaId);
        public CategoriaGetDTO GetCategoriaDTO(int categoriaId);

        public List<Obra> GetObrasByCategoria(int categoriaId);
        public void UpdateCategoria(Categoria categoria);
        public void RemoveCategoria(int categoriaId);

        public void AddCategoria(Categoria categoria);

    }
}
