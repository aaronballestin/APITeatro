namespace TeatroApi.Models
{
    public class SesionIntranetDTO{
        public int id {get; set;}
        public int salaId {get; set;}
        public int obraId {get; set;}
        public string nombreObra {get; set;}
        public DateTime date {get; set;}
        public double precio {get; set;}

        public SesionIntranetDTO(int sesion, int obra, int sala, DateTime horario, string nombreObra, double precio){
            this.id = sesion;
            this.obraId = obra;
            this.salaId = sala;
            this.date = horario;
            this.nombreObra = nombreObra;
        }
    }
}