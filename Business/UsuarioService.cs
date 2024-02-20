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

        public Usuario GetUsuario(string emailUsuario, string passwordUsuario ){
            return _repository.GetUsuario(emailUsuario, passwordUsuario);
        }

        public Usuario GetUsuario(int usuarioId ){
            return _repository.GetUsuario(usuarioId);
        }

    }
}
