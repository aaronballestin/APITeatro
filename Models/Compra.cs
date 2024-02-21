using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class Compra{

        public int EntradaId {get; set;}
        public int AsientoId {get; set;}
        public int SesionId {get; set;}
        public int UsuarioId {get; set;}



        [ForeignKey("AsientoId")]
        public Asiento Asiento {get; set;}

        [ForeignKey("SesionId")]
        public Sesion Sesion {get; set;}

        [ForeignKey("UsuarioId")]
        public Usuario Usuario {get; set;}


        public Compra(){

        }
    }
}