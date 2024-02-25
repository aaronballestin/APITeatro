using TeatroApi.Models;


namespace TeatroApi.Business
{
    public interface ISesionService
    {
        public List<Sesion> GetSesiones();
        public Sesion GetSesion(int id);
        public int AddSesion(Sesion sesion);
        public void UpdateSesion(Sesion sesion);
        public void DeleteSesion(int id);

    }
}
