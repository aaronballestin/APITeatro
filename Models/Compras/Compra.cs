using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class Compra{

        [Key]
        public int CompraId {get; set;}
        [ForeignKey("SesionId")]
        public int SesionId {get; set;}
        [ForeignKey("UsuarioId")]
        public int UsuarioId {get; set;}
        [ForeignKey("AsientoId")]
        public int AsientoId {get; set;}
        public DateTime? FechaCompra {get; set;}
        public double PrecioCompra {get; set;}


        public Asiento Asiento {get; set;}

        public Sesion Sesion {get; set;}

        public Usuario Usuario {get; set;}


        public Compra(){

        }
    }
}