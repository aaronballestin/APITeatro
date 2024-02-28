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

        public CategoriaGetDTO GetCategoriaDTO(int categoriaId)
        {
            var categoria = _context.Categorias.FirstOrDefault(c => c.CategoriaId == categoriaId);
            if (categoria == null) return null; 

            var obras = _context.Obras.Where(o => o.CategoriaId == categoriaId)
                                        .Select(o => new ObraGetDTO(o.ObraId, o.NombreObra, o.DescripcionObra, o.RutaFotoObra))
                                        .ToList(); 

            return new CategoriaGetDTO
            {
                id = categoria.CategoriaId,
                nombre = categoria.NombreCategoria,
                obras = obras
            };
        }


        public List<Categoria> GetCategorias()
        {
            return _context.Categorias.ToList();
        }

        /*public List<Categoria> GetCategorias()
        {
            return _context.Categorias.ToList();
        }*/

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

        public List<Obra> GetObrasByCategoria(int categoriaId){
            List<Obra> obrasTodas = _context.Obras.ToList();
            List<Obra> obrasCategoria = new List<Obra>();

            foreach (var obra in obrasCategoria)
            {
                if(obra.CategoriaId == categoriaId){
                    obrasCategoria.Add(obra);
                }
            }

            return obrasCategoria;

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }
}