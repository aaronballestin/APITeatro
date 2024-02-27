namespace TeatroApi.Models
{
    public class ObraGetDTO
    {
        public int _id { get; set; }

        public string _nombre { get; set; }

        public string _descripcion { get; set; }

        public string _rutaFoto { get; set; }

        public ObraGetDTO()
        {

        }

        public ObraGetDTO(int id, string nombre, string descripcion, string rutaFoto)
        {
            this._id = id;
            this._nombre = nombre;
            this._descripcion = descripcion;
            this._rutaFoto = rutaFoto;
        }
    }

    public class ObraGetSesionDTO
    {
        public int _id { get; set; }

        public string _nombre { get; set; }

        public string _descripcion { get; set; }

        public string _rutaFoto { get; set; }

        public List<SesionGetDTO> _sesiones {get; set;}
    }
}