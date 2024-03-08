namespace TeatroApi.Models
{
    public class SesionGetDTO{
        public int sesionId { get; set; }
        public DateTime date {get; set; }

        public double precio {get; set;}
        public SesionGetDTO(){

        }

        public SesionGetDTO(int id, DateTime date, double precio){
            sesionId = id;
            this.date = date; 
            this.precio = precio;
        }
    }
}