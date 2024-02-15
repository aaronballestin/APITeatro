using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeatroApi.Models
{
    public class DetalleAsiento{

        
        public int AsientoId {get; set;}

        public int ObraId {get; set;}

        public Boolean Ocupado {get; set;}

        public string NombreCliente {get; set;}

        [ForeignKey("AsientoId")]
        public Asiento Asiento {get; set;}

        [ForeignKey("ObraId")]
        public Obra Obra {get; set;}

        public DetalleAsiento (){

        }
    }
}