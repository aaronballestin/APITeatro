namespace TeatroApi.Models
{
    public class CompraDTO
    {
        public int CompraId {get; set;}
        public int UsuarioId { get; set; }
        public int SesionId { get; set; }
        public double precio {get; set;}

        public DateTime? fecha {get; set;}

    }


}