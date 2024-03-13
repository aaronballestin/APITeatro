using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;
using Microsoft.Extensions.Configuration;
using System;

namespace TeatroApi.Data
{
    public class TeatroContext : DbContext
    {
        public TeatroContext(DbContextOptions<TeatroContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { UsuarioId = 1, NombreUsuario = "Juan", EmailUsuario = "juan@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 2, NombreUsuario = "María", EmailUsuario = "maria@example.com", PasswordUsuario = "1234", Rol = "Admin" },
                new Usuario { UsuarioId = 3, NombreUsuario = "Carlos", EmailUsuario = "carlos@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 4, NombreUsuario = "Laura", EmailUsuario = "laura@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 5, NombreUsuario = "Pedro", EmailUsuario = "pedro@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 6, NombreUsuario = "Ana", EmailUsuario = "ana@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 7, NombreUsuario = "Sofía", EmailUsuario = "sofia@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 8, NombreUsuario = "David", EmailUsuario = "david@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 9, NombreUsuario = "Lucía", EmailUsuario = "lucia@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 10, NombreUsuario = "Diego", EmailUsuario = "diego@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 11, NombreUsuario = "Paula", EmailUsuario = "paula@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 12, NombreUsuario = "Manuel", EmailUsuario = "manuel@example.com", PasswordUsuario = "1234", Rol = "Guest" }

            );

            modelBuilder.Entity<Sala>().HasData(
                new Sala { SalaId = 1, AsientosNormales = 50, AsientoVip = 10, AsientosMinusvalidos = 10 },
                new Sala { SalaId = 2, AsientosNormales = 50, AsientoVip = 10, AsientosMinusvalidos = 10 },
                new Sala { SalaId = 3, AsientosNormales = 50, AsientoVip = 10, AsientosMinusvalidos = 10 }

            );


            modelBuilder.Entity<Obra>().HasData(
                new Obra { ObraId = 1, NombreObra = "Hamlet", DescripcionObra = "Una tragedia clásica", RutaFotoObra = "ruta/foto/hamlet.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120 },
                new Obra { ObraId = 2, NombreObra = "La Casa de Bernarda Alba", DescripcionObra = "Un drama familiar", RutaFotoObra = "ruta/foto/bernarda_alba.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120 },
                new Obra { ObraId = 3, NombreObra = "Romeo y Julieta", DescripcionObra = "Amor prohibido entre dos familias rivales", RutaFotoObra = "ruta/foto/romeo_julieta.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120 },
                new Obra { ObraId = 4, NombreObra = "El Fantasma de la Ópera", DescripcionObra = "Una historia de amor y tragedia en la Ópera de París", RutaFotoObra = "ruta/foto/fantasma_opera.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120 },
                new Obra { ObraId = 5, NombreObra = "Esperando a Godot", DescripcionObra = "Dos personajes esperan a alguien que nunca llega", RutaFotoObra = "ruta/foto/esperando_godot.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120 },
                new Obra { ObraId = 6, NombreObra = "Macbeth", DescripcionObra = "Una tragedia sobre ambición y traición", RutaFotoObra = "ruta/foto/macbeth.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120},
                new Obra { ObraId = 7, NombreObra = "Los Miserables", DescripcionObra = "La historia de Jean Valjean y su redención", RutaFotoObra = "ruta/foto/los_miserables.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120 },
                new Obra { ObraId = 8, NombreObra = "Otelo", DescripcionObra = "Celos y traición en la Venecia del siglo XVI", RutaFotoObra = "ruta/foto/otelo.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120 },
                new Obra { ObraId = 9, NombreObra = "La Gaviota", DescripcionObra = "Drama de amor y desilusión en la sociedad rusa del siglo XIX", RutaFotoObra = "ruta/foto/la_gaviota.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120 },
                new Obra { ObraId = 10, NombreObra = "La Opera de los Tres Centavos", DescripcionObra = "Una ópera sobre el crimen y la pobreza en Londres", RutaFotoObra = "ruta/foto/Fopera_tres_centavos.jpg", AuditoriaUsuario = "ADMIN", DuracionObra = 120 }
            );

            


            modelBuilder.Entity<Sesion>().HasData(
                new Sesion { SesionId = 1, ObraId = 1, FechaHora = new DateTime(2024, 4, 1, 18, 0, 0), SalaId = 1, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 2, ObraId = 2, FechaHora = new DateTime(2024, 4, 2, 19, 0, 0), SalaId = 2, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 3, ObraId = 1, FechaHora = new DateTime(2024, 4, 3, 20, 0, 0), SalaId = 3, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 4, ObraId = 1, FechaHora = new DateTime(2024, 4, 4, 17, 30, 0), SalaId = 1, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 5, ObraId = 3, FechaHora = new DateTime(2024, 4, 5, 18, 0, 0), SalaId = 2, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 6, ObraId = 3, FechaHora = new DateTime(2024, 4, 6, 19, 30, 0), SalaId = 3, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 7, ObraId = 4, FechaHora = new DateTime(2024, 4, 7, 20, 0, 0), SalaId = 1, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 8, ObraId = 4, FechaHora = new DateTime(2024, 4, 8, 17, 0, 0), SalaId = 2, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 9, ObraId = 5, FechaHora = new DateTime(2024, 4, 9, 18, 30, 0), SalaId = 3, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 10, ObraId = 5, FechaHora = new DateTime(2024, 4, 10, 19, 0, 0), SalaId = 1, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 11, ObraId = 6, FechaHora = new DateTime(2024, 4, 11, 20, 0, 0), SalaId = 2, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 12, ObraId = 6, FechaHora = new DateTime(2024, 4, 12, 17, 30, 0), SalaId = 3, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 13, ObraId = 7, FechaHora = new DateTime(2024, 4, 13, 18, 0, 0), SalaId = 1, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 14, ObraId = 7, FechaHora = new DateTime(2024, 4, 14, 19, 30, 0), SalaId = 2, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 15, ObraId = 8, FechaHora = new DateTime(2024, 4, 15, 20, 0, 0), SalaId = 3, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 16, ObraId = 8, FechaHora = new DateTime(2024, 4, 16, 17, 0, 0), SalaId = 1, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 17, ObraId = 9, FechaHora = new DateTime(2024, 4, 17, 18, 30, 0), SalaId = 2, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 18, ObraId = 9, FechaHora = new DateTime(2024, 4, 18, 19, 0, 0), SalaId = 3, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 19, ObraId = 10, FechaHora = new DateTime(2024, 4, 19, 20, 0, 0), SalaId = 1, Precio = 30, AuditoriaUsuario = "ADMIN" },
                new Sesion { SesionId = 20, ObraId = 10, FechaHora = new DateTime(2024, 4, 20, 17, 0, 0), SalaId = 2, Precio = 30, AuditoriaUsuario = "ADMIN" }
            );


            modelBuilder.Entity<Compra>().HasData(
                new Compra {  SesionId = 1, UsuarioId = 1 },
                new Compra {  SesionId = 1, UsuarioId = 2 }
            );



            // Relación entre Sesion y Sala
            modelBuilder.Entity<Sesion>()
                .HasOne(s => s.Sala)
                .WithMany(sala => sala.Sesiones)
                .HasForeignKey(s => s.SalaId)
                .IsRequired() // Esto asegura que el SalaId sea obligatorio en la relación
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Sesion>()
                .Property(s => s.SalaId)
                .IsRequired(); // Esto también asegura que el SalaId sea obligatorio en la tabla Sesion

            //Tabla intermedia de compras


            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Sesion)
                .WithMany(s => s.Compras)
                .HasForeignKey(c => c.SesionId)
                .OnDelete(DeleteBehavior.Cascade);




            modelBuilder.Entity<Sala>()
                   .HasKey(s => s.SalaId);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Sala> Salas { get; set; }
    }
}
