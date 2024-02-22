using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class Compra{

        public int EntradaId {get; set;}
        
        [ForeignKey("AsientoId")]
        public int AsientoId {get; set;}
        
        [ForeignKey("SesionId")]
        public int SesionId {get; set;}

        [ForeignKey("UsuarioId")]
        public int UsuarioId {get; set;}



        public Asiento Asiento {get; set;}

        public Sesion Sesion {get; set;}

        public Usuario Usuario {get; set;}


        public Compra(){

        }
    }
}