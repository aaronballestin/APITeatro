namespace TeatroApi.Models
{
    public class SesionGetDTO{
        public int _sesionId { get; set; }
        public string _dia {get; set;}
        public string _hora {get; set;}
        public SesionGetDTO(){

        }

        public SesionGetDTO(int id, DateTime date){
            _sesionId = id;
            _dia = date.Day+"/"+date.Month;
            _hora = "" + date.Hour + ":"+date.Minute;
        }
    }
}