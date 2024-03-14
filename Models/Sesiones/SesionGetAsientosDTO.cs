namespace TeatroApi.Models
{
    public class SesionGetAsientosDTO{
        public int id {get; set;}

        public int salaId {get; set;}

        public int obraId {get; set;}

        public string nombreObra {get; set;}

        public DateTime date{get; set;}
        
        public double precio {get; set;} 

        public SalaSesionDTO sala {get; set;}

        public List<AsientoGetDTO> asientos {get; set;}
        public SesionGetAsientosDTO(){

        }

        public SesionGetAsientosDTO(int id, int salaId, int obraId, string nombreObra, DateTime date, double precio){
            this.id = id;
            this.salaId = salaId;
            this.obraId = obraId;
            this.nombreObra = nombreObra;
            this.date = date;
            this.precio = precio;
        }
    }
}