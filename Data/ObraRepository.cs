using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;

namespace TeatroApi.Data
{
    public class ObraRepository : IObraRepository
    {

        private readonly TeatroContext _context;
        public ObraRepository(TeatroContext context)
        {
            _context = context;
        }

        public void AddObra(Obra obra)
        {
            //Recuperamos la categoria
            // CategoriaRepository categoriaRepository = new CategoriaRepository(_context);
            // obra.Categoria = categoriaRepository.GetCategoria(obra.CategoriaId);

            _context.Obras.Add(obra);
        }
        public Obra GetObra(int obraId)
        {
            return _context.Obras.FirstOrDefault(obra => obra.ObraId == obraId);
        }

        public List<Obra> GetObras()
        {
            var obras = _context.Obras.ToList(); 
            return obras;
        }

        public void UpdateObra(Obra obra)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(obra).State = EntityState.Modified;
        }

        public void RemoveObra(int obraId)
        {
            var account = GetObra(obraId);
            if (account is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Obras.Remove(account);
            SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}