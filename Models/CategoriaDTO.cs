namespace TeatroApi.Models
{
    public class CategoriaGetDTO{
        public int id {get; set;}
        public string nombre {get; set;}
        public List<ObraGetDTO> obras {get; set;}

        public CategoriaGetDTO(){
            obras = new List<ObraGetDTO>();
        }

        public CategoriaGetDTO(int id, string nombre, List<ObraGetDTO> obras){
            this.id = id;
            this.nombre = nombre;
            this.obras = obras;
        }  
    }
}