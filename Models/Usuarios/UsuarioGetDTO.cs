namespace TeatroApi.Models
{
    public class UsuarioGetDTO{
        public int id {get; set;}
        public string email {get; set;}
        public string password {get; set;}
        public string nombre {get; set;}
        public string rol {get; set;}

        public UsuarioGetDTO(){
            
        }
    }
}