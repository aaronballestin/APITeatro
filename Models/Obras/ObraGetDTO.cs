namespace TeatroApi.Models
{
    public class ObraGetDTO
    {
        public int id { get; set; }

        public string nombre { get; set; }

        public string descripcion { get; set; }

        public string rutaFoto { get; set; }

        public ObraGetDTO()
        {

        }

        public ObraGetDTO(int id, string nombre, string descripcion, string rutaFoto)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.rutaFoto = rutaFoto;
        }
    }


}