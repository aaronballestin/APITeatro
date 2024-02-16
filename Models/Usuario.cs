using System.ComponentModel.DataAnnotations;
using System.Text;


namespace TeatroApi.Models{
    
    public class Usuario{

        public int UsuarioId {get; set;}

        public string NombreUsuario {get; set;}

        public string EmailUsuario {get; set;}

        public string PasswordUsuario {get; set;}

        public Usuario(){

        }
    }
}