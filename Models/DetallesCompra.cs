using System.ComponentModel.DataAnnotations.Schema;

namespace TeatroApi.Models
{
    public class DetallesCompra
    {

        [ForeignKey("CompraId")]
        public int CompraId { get; set; }

        [ForeignKey("SesionId")]
        public int SesionId { get; set; }

        public int AsientoId { get; set; }

        public DetallesCompra(){
            
        }
    }
}