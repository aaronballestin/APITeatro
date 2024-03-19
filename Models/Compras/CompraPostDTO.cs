namespace TeatroApi.Models
{
    public class CompraPostDTO{
        public int sesionId { get; set;}

        public List<int> asientos {get; set;}

        public int usuarioId {get; set;}

        public int precioTotal {get; set;}

        public CompraPostDTO(){

        }


    }
}