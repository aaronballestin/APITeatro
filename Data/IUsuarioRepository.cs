using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface IUsuarioRepository
    {
        void AddUsuario(Usuario usuario);
        UsuarioGetDTO GetUsuario(int usuarioId);
        UsuarioGetDTO GetUsuario(string emailUsuario, string passwordUsuario);

        void SaveChanges();

    }
}