namespace TeatroApi.Models
{
    public class SesionPostDTO{
        public int obraId {get; set;}
        public DateTime horario {get; set;}
        public int salaId {get; set;}

        public double precio {get; set;}

        public string auditoriaUsuario {get; set;}

        public SesionPostDTO(){
            
        }

    }
}