namespace TeatroApi.Models
{
    public class UsuarioGetCompras
    {
        public int id { get; set; }
        public string nombre { get; set;}
        public string email {get; set;}
        public string password {get; set;}

        public List<CompraUsuario> compras {get; set;}

        public UsuarioGetCompras(int id, string nombre, string email, string password)
        {
            this.id = id;
            this.nombre = nombre;
            this.email = email;
            this.password = password;
        }

        public UsuarioGetCompras(){

        }

    }
}