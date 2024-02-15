using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeatroApi.Models
{
    public class Categoria{

        [Key]
        public int CategoriaId {get; set;}

        [Required]
        public string Nombre {get; set;}
        public List<Obra> Obras {get; set;}
        public Categoria(){

        }

        
    }
}