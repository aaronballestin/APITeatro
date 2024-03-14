namespace TeatroApi.Models
{
    public class CompraUsuario
    {
        public int id { get; set; }
        public double precio { get; set; }
        public int asiento { get; set; }

        public SesionCompra sesion { get; set; }


        public CompraUsuario(){

        }

        public CompraUsuario(int id, double precio, int asiento)
        {
            this.id = id;
            this.precio = precio;
            this.asiento = asiento;
        }

    }
}