using TeatroApi.Models;

namespace TeatroApi.Business
{
    public interface IUsuarioService
    {
        public UsuarioGetDTO GetUsuario(string emailUsuario, string passwordUsuario);
        public UsuarioGetDTO GetUsuario(int usuarioId);
        public int AddUsuario(Usuario usuario);


    }
}
