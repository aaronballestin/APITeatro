using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;

namespace TeatroApi.Data
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private readonly TeatroContext _context;
        public CategoriaRepository(TeatroContext context)
        {
            _context = context;
        }

        public void AddCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
        }

        public Categoria GetCategoria(int categoriaId)
        {
            return _context.Categorias.FirstOrDefault(categoria => categoria.CategoriaId == categoriaId);
        }

        public List<Categoria> GetCategorias()
        {
            return _context.Categorias.ToList();
        }

        public void UpdateCategoria(Categoria categoria)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(categoria).State = EntityState.Modified;
        }

        public void RemoveCategoria(int categoriaId)
        {
            var account = GetCategoria(categoriaId);
            if (account is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Categorias.Remove(account);
            SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}