using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeatroApi.Models
{
    public class Obra
    {
        [Key]
        public int ObraId { get; set; }

        [Required]
        public string NombreObra { get; set; }
        
        [Required]
        public string DescripcionObra { get; set; }

        [Required]
        public string RutaFotoObra {get; set;}

        public Obra(){

        }
    }
}