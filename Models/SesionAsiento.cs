using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class SesionAsiento
    {
        
        [ForeignKey("SesionId")]
        public int SesionId { get; set; }

        [ForeignKey("AsientoId")]
        public int AsientoId {get; set;}
        public Boolean Ocupado {get; set;}

        public Sesion Sesion {get; set;}

        public Asiento Asiento {get; set;}

        public SesionAsiento(){

        }
    }
}