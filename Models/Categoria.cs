using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeatroApi.Models
{
    public class Categoria{

        [Key]
        public int CategoriaId {get; set;}

        [Required]
        public string NombreCategoria {get; set;}
        public List<Obra> Obras {get; set;}
        public Categoria(){
            Obras = new List<Obra>();
        }

        
    }
}