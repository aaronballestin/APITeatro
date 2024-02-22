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
        public List<Compra> Compras {get; set;}
        public DateTime FechaHora {get; set;}
        public List<SesionAsiento> SesionAsientos {get; set;} 
        
    
        public Obra Obra {get; set;}
        

        public Sesion(){

        }

    }
}