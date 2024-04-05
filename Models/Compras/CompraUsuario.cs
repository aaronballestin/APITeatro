namespace TeatroApi.Models
{
    public class CompraUsuario
    {
        public int id { get; set; }
        public double precio { get; set; }
        public List<int> asientos { get; set; }

        public SesionCompra sesion { get; set; }


        public CompraUsuario(){

        }

        public CompraUsuario(int id, double precio, List<int> asientos)
        {
            this.id = id;
            this.precio = precio;
            this.asientos = asientos;
        }

    }
}