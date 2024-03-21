using TeatroApi.Data;
using TeatroApi.Models;

namespace TeatroApi.Business
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public UsuarioGetDTO GetUsuario(string emailUsuario, string passwordUsuario)
        {
            return _repository.GetUsuario(emailUsuario, passwordUsuario);
        }

        public List<UsuarioDTO> GetUsuarios()
        {
            return _repository.GetUsuarios();
        }

        public UsuarioGetCompras GetUsuario(int usuarioId)
        {
            return _repository.GetUsuarioCompras(usuarioId);
        }

        public int AddUsuario(Usuario usuario)
        {
            _repository.AddUsuario(usuario);
            return usuario.UsuarioId;
        }

        public void UpdateUsuario(Usuario usuario)
        {
            _repository.UpdateUsuario(usuario);
        }
    }
}
