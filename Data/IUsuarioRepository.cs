using TeatroApi.Models;

namespace TeatroApi.Data
{
    public interface IUsuarioRepository
    {
        void AddUsuario(Usuario usuario);
        List<CompraUsuario> GetUsuarioCompras(int usuarioId);
        UsuarioGetDTO GetUsuario(string emailUsuario, string passwordUsuario);
        void UpdateUsuario(Usuario usuario); 

        List<UsuarioDTO> GetUsuarios();

        void SaveChanges();

    }
}