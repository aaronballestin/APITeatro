using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeatroApi.Models
{
    public class Asiento{
        
        [Key]
        public int AsientoId {get; set;}

        [Required]
        public int Fila {get; set;}

        [Required]
        public int Columna {get; set;}

        public List<Compra> Compras {get; set;}
        public List<SesionAsiento> SesionAsientos {get; set;}

        public Asiento (){

        }
    }
}