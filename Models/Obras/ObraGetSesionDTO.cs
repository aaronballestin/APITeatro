namespace TeatroApi.Models
{
    public class ObraGetSesionDTO
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string rutaFoto { get; set; }

        public int duracion {get; set;}

        public List<SesionGetDTO> sesiones { get; set; }
    }
}