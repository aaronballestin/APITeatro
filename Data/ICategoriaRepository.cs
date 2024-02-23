using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface ICategoriaRepository
    {
        void AddCategoria(Categoria categoria);
        Categoria GetCategoria(int categoriaId);
        void UpdateCategoria(Categoria categoria);
        void RemoveCategoria(int categoriaId);
        void SaveChanges();
        List<Categoria> GetCategorias();

        List<Obra> GetObrasByCategoria(int categoriaId);
    }
}