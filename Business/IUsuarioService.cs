using TeatroApi.Models;

namespace TeatroApi.Business
{
    public interface IUsuarioService
    {
        public Usuario GetUsuario(string emailUsuario, string passwordUsuario);
        public Usuario GetUsuario(int usuarioId);
        


    }
}
