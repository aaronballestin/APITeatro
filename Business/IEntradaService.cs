using TeatroApi.Models;

namespace TeatroApi.Business
{
    public interface IEntradaService
    {
        public List<Entrada> GetEntradasByUsuario(int usuarioId); 
        public List<Entrada> GetEntradasByObra(int obraId);       

    }
}
