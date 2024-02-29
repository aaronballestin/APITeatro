namespace TeatroApi.Models
{
    public class SesionGetDTO{
        public int sesionId { get; set; }
        public DateTime date {get; set; }
        public SesionGetDTO(){

        }

        public SesionGetDTO(int id, DateTime date){
            sesionId = id;
            this.date = date; 
        }
    }
}