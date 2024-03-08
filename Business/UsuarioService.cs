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

        public UsuarioGetDTO GetUsuario(string emailUsuario, string passwordUsuario ){
            return _repository.GetUsuario(emailUsuario, passwordUsuario);
        }

        public Usuario GetUsuario(int usuarioId ){
            return _repository.GetUsuario(usuarioId);
        }

        public int AddUsuario(Usuario usuario)
        {
            _repository.AddUsuario(usuario);
            _repository.SaveChanges();
            return usuario.UsuarioId;
        }
    }
}
