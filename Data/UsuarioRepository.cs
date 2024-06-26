using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;
using Microsoft.Extensions.Logging;


namespace TeatroApi.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly TeatroContext _context;

        private readonly ILogger<UsuarioRepository> _logger;

        public UsuarioRepository(ILogger<UsuarioRepository> logger, TeatroContext context)
        {
            _context = context;
            _logger = logger;
        }

        public void AddUsuario(Usuario usuario)
        {
            try
            {
                _context.Usuarios.Add(usuario);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
            }
        }

        public UsuarioGetDTO GetUsuario(int usuarioId)
        {
            try
            {
                var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.UsuarioId == usuarioId);
                var usuarioGetDTO = new UsuarioGetDTO { id = usuario.UsuarioId, nombre = usuario.NombreUsuario, email = usuario.EmailUsuario, password = usuario.PasswordUsuario, rol = usuario.Rol };

                return usuarioGetDTO;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }

        public List<CompraUsuario> GetUsuarioCompras(int usuarioId)
        {
            try
            {   
                var compras = _context.Compras
                                .Where(c => c.UsuarioId == usuarioId)
                                .Select(c => new CompraUsuario
                                {
                                    id = c.CompraId,
                                    precio = c.PrecioCompra,
                                    sesion = new SesionCompra
                                    {
                                        salaId = c.Sesion.SalaId,
                                        nombreObra = c.Sesion.Obra.NombreObra,
                                        date = c.Sesion.FechaHora
                                    },
                                    asientos = _context.DetallesCompras
                                                .Where(d => d.CompraId == c.CompraId)
                                                .Select(d => d.AsientoId)
                                                .ToList()
                                })
                                .ToList();
                

                return compras;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }




        public UsuarioGetDTO GetUsuario(string emailUsuario, string passwordUsuario)
        {
            try
            {
                var usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.EmailUsuario == emailUsuario && usuario.PasswordUsuario == passwordUsuario);
                var usuarioGetDTO = new UsuarioGetDTO { id = usuario.UsuarioId, nombre = usuario.NombreUsuario, email = usuario.EmailUsuario, password = usuario.PasswordUsuario, rol = usuario.Rol };

                return usuarioGetDTO;
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }

        }

        public List<UsuarioDTO> GetUsuarios()
        {
            try
            {
                return _context.Usuarios.Select(u => new UsuarioDTO { id = u.UsuarioId, email = u.EmailUsuario, nombre = u.NombreUsuario, rol = u.Rol }).ToList();

            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }

        public void UpdateUsuario(Usuario usuario)
        {
            try
            {
                _context.Entry(usuario).State = EntityState.Modified;
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }
        }

        /*public void RemoveUsuario(int usuarioId)
        {
            try
            {
                var account = GetUsuario(usuarioId);
                if (account is null)
                {
                    throw new KeyNotFoundException("Account not found.");
                }
                _context.Usuarios.Remove(account);
                SaveChanges();
            }
            catch (Exception e)
            {
                _logger.LogInformation($"Mensaje: {e.Message}");
                _logger.LogError($"StackTrace: {e.StackTrace}");
                throw;
            }


        }*/

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
