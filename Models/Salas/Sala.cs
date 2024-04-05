namespace TeatroApi.Models
{
    public class Sala{
        public int SalaId;

        public int AsientosNormales {get; set;}
        public int AsientosVip {get; set;}
        public int AsientosMinusvalidos {get; set;}


        public List<Sesion> Sesiones {get; set;}

        public Sala(){
            
        }

        
    }
}