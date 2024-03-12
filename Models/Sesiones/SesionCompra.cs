namespace TeatroApi.Models
{
    public class SesionCompra
    {
        public int salaId { get; set; }
        public int obraId { get; set; }
        public string nombreObra { get; set; }
        public DateTime date { get; set; }
        public double precio { get; set; }

        public SesionCompra(){
            
        }
    }
}