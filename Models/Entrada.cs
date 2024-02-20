using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class Entrada{

        public int EntradaId {get; set;}
        public int AsientoId {get; set;}
        public int ObraId {get; set;}
        public string UsuarioId {get; set;}



        [ForeignKey("AsientoId")]
        public Asiento Asiento {get; set;}

        [ForeignKey("ObraId")]
        public Obra Obra {get; set;}

        [ForeignKey("UsuarioId")]
        public Usuario Usuario {get; set;}


        public Entrada(){

        }
    }
}