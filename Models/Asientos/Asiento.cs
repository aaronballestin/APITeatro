using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class Asiento{
        
        [Key]
        public int AsientoId {get; set;}

        [ForeignKey("SalaId")]
        public int SalaId {get; set;}
        public Sala Sala {get; set;}

        public int TipoAsiento {get; set;}

        public List<Compra> Compras {get; set;}

        public Asiento (){

        }
    }
}