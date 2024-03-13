namespace TeatroApi.Models
{
    public class AsientoGetDTO{
        public int id {get; set;}
        public int tipoAsiento{get; set;}
        public double suplemento {get; set;}
        public Boolean ocupado {get; set;}

        public AsientoGetDTO(){

        }

        public AsientoGetDTO(int id, int tipoAsiento, double suplemento){
            this.id = id;
            this.tipoAsiento = tipoAsiento;
            this.suplemento = suplemento;
        }
    }
}