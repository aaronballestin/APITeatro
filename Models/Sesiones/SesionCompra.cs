namespace TeatroApi.Models
{
    public class SesionCompra
    {
        public int salaId { get; set; }
        public string nombreObra { get; set; }
        public DateTime date { get; set; }

        public SesionCompra(){

        }

        public SesionCompra(int salaId, string nombreObra, DateTime date)
        {
            this.salaId = salaId;
            this.nombreObra = nombreObra;
            this.date = date;
        }
    }
}