namespace TeatroApi.Models
{
    public class CompraDTO{
        
        public int asientoId {get; set;}
        
        public SesionCompra sesion {get; set;}

        public CompraDTO(){

        }

        public CompraDTO(int asiento, SesionCompra sesion){
            this.asientoId = asiento;
            this.sesion = sesion;
        }
    }
}