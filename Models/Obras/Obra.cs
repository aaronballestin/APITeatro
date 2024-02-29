using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class Obra
    {
        [Key]
        public int ObraId { get; set; }
        
        [ForeignKey("CategoriaId")]
        public int CategoriaId { get; set; }

        [Required]
        public string NombreObra { get; set; }
        
        [Required]
        public string DescripcionObra { get; set; }

        [Required]
        public string RutaFotoObra {get; set;}

        public List<Sesion>? Sesiones {get; set;}

        public Categoria? Categoria {get; set;}

        public Obra(){
            Sesiones = new List<Sesion>();
        }
    }
}