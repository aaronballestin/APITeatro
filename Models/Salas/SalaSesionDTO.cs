namespace TeatroApi.Models
{
    public class SalaSesionDTO{
        public int asientosMinusvalidos {get; set;}
        public int asientosVip {get; set;}
        public int asientosNormales {get; set;}

        public SalaSesionDTO(){

        }

        public SalaSesionDTO(int asientosMinusvalidos, int asientosVip, int asientosNormales){
            this.asientosMinusvalidos = asientosMinusvalidos;
            this.asientosVip = asientosVip;
            this.asientosNormales = this.asientosNormales;
        }
    }
}