namespace TeatroApi.Models
{
    public class AsientoGetDTO{
        public int id {get; set;}
        public int tipoAsiento{get; set;}

        public AsientoGetDTO(){

        }

        public AsientoGetDTO(int id, int tipoAsiento){
            this.id = id;
            this.tipoAsiento = tipoAsiento;
            
        }
    }
}