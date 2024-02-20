using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;

namespace TeatroApi.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly TeatroContext _context;
        public UsuarioRepository(TeatroContext context)
        {
            _context = context;
        }

        public void AddUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }

        public Usuario GetUsuario(int usuarioId)
        {
            return _context.Usuarios.FirstOrDefault(usuario => usuario.UsuarioId == usuarioId);
        }

        public Usuario GetUsuario(string emailUsuario, string passwordUsuario){
            return _context.Usuarios.FirstOrDefault(usuario => (usuario.EmailUsuario == emailUsuario && usuario.PasswordUsuario == passwordUsuario));
        }

        public List<Usuario> GetUsuarios()
        {
            return _context.Usuarios.ToList();
        }

        public void UpdateUsuario(Usuario usuario)
        {
            // En EF Core, si el objeto ya está siendo rastreado, actualizar sus propiedades
            // y llamar a SaveChanges() es suficiente para actualizarlo en la base de datos.
            // Asegúrate de que el estado del objeto sea 'Modified' si es necesario.
            _context.Entry(usuario).State = EntityState.Modified;
        }

        public void RemoveUsuario(int usuarioId)
        {
            var account = GetUsuario(usuarioId);
            if (account is null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            _context.Usuarios.Remove(account);
            SaveChanges();

        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
