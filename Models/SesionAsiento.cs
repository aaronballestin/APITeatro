using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class SesionAsiento
    {
        
        public int SesionId { get; set; }
        public int AsientoId {get; set;}
        public Boolean Ocupado {get; set;}

        [ForeignKey("SesionId")]
        public Sesion Sesion {get; set;}

        public Asiento Asiento {get; set;}

        public SesionAsiento(){

        }
    }
}