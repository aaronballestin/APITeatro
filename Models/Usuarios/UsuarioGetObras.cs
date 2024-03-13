namespace TeatroApi.Models
{
    public class UsuarioGetObras
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }

        public CompraDTO compras {get; set;}

        public UsuarioGetObras(){

        } 
    }
}