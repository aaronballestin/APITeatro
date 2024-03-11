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

        public ObraGetSesionDTO GetObraDTO(int obraId)
        {
            var obra = _context.Obras.FirstOrDefault(obra => obra.ObraId == obraId);
            _context.Sesiones.ToList();

            var sesiones = _context.Sesiones.Where(o => o.ObraId == obraId)
                                        .Select(o => new SesionGetDTO(o.SesionId, o.FechaHora, o.Precio))
                                        .ToList(); 
            return new ObraGetSesionDTO
            {
                id = obra.ObraId,
                nombre = obra.NombreObra,
                descripcion = obra.DescripcionObra,
                rutaFoto = obra.RutaFotoObra,
                duracion = obra.DuracionObra,
                sesiones = sesiones
            };
        }

        /*public List<Obra> GetObras()
        {
            var obras = _context.Obras.ToList();
            return obras;
        }*/

        public List<ObraGetDTO> GetObras(){
            var obras =_context.Obras.ToList();
            var obrasDTO = new List<ObraGetDTO>();
            foreach (var obra in obras)
            {
                var obraDTO = new ObraGetDTO {
                    id = obra.ObraId,
                    nombre = obra.NombreObra,
                    descripcion = obra.DescripcionObra,
                    rutaFoto = obra.RutaFotoObra,
                    duracion = obra.DuracionObra
                };
                obrasDTO.Add(obraDTO);
            }
            return obrasDTO;
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
            _context.Sesiones.Where(s => s.ObraId == obraId)
                            .ToList();

            _context.Obras.Remove(account);
            SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}