using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class Sesion
    {
        [Key]
        public int SesionId { get; set; }

        [ForeignKey("ObraId")]
        public int ObraId {get; set;}
        public DateTime FechaHora {get; set;}

        [ForeignKey("SalaId")]
        public int SalaId {get; set;} 
        
        public Sala Sala {get; set;}
    
        public Obra Obra {get; set;}
        
        public List<Compra> Compras {get; set;}

        public Sesion(){

        }

    }
}