using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface IUsuarioRepository
    {
        void AddUsuario(Usuario usuario);
        Usuario GetUsuario(int usuarioId);
        Usuario GetUsuario(string emailUsuario, string passwordUsuario);
        void UpdateUsuario(Usuario usuario);
        void RemoveUsuario(int asientoId);
        void SaveChanges();
        List<Usuario> GetUsuarios();
    }
}