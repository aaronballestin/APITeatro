namespace TeatroApi.Models
{
    public class CategoriaGetDTO{
        public int _id {get; set;}
        public string _nombre {get; set;}
        public List<ObraGetDTO> _obras {get; set;}

        public CategoriaGetDTO(){
            _obras = new List<ObraGetDTO>();
        }

        public CategoriaGetDTO(int id, string nombre, List<ObraGetDTO> obras){
            this._id = id;
            this._nombre = nombre;
            this._obras = obras;
        }  
    }
}