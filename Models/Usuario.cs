using System.ComponentModel.DataAnnotations;
using System.Text;


namespace TeatroApi.Models{
    
    public class Usuario{

        [Key]
        public int UsuarioId {get; set;}

        [Required]
        public string NombreUsuario {get; set;}

        [Required]
        public string EmailUsuario {get; set;}

        [Required]
        public string PasswordUsuario {get; set;}

        [Required]
        public string Rol {get; set;}

        public List<Entrada> Entradas {get; set;}

        public Usuario(){

        }
    }
}