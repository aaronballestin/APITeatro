namespace TeatroApi.Models
{
    public class SesionPostDTO{
        public DateTime horario {get; set;}
        public int salaId {get; set;}
        public string nombreObra{get; set;}
        public double precio {get; set;}

        public string auditoriaUsuario {get; set;}

        public SesionPostDTO(){
            
        }

    }
}