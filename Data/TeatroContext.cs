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
                new Sala { SalaId = 1 },
                new Sala { SalaId = 2 },
                new Sala { SalaId = 3 }

            );


            modelBuilder.Entity<Obra>().HasData(
                new Obra { ObraId = 1, NombreObra = "Hamlet", DescripcionObra = "Una tragedia clásica", RutaFotoObra = "ruta/foto/hamlet.jpg" },
                new Obra { ObraId = 2, NombreObra = "La Casa de Bernarda Alba", DescripcionObra = "Un drama familiar", RutaFotoObra = "ruta/foto/bernarda_alba.jpg" },
                new Obra { ObraId = 3, NombreObra = "Romeo y Julieta", DescripcionObra = "Amor prohibido entre dos familias rivales", RutaFotoObra = "ruta/foto/romeo_julieta.jpg" },
                new Obra { ObraId = 4, NombreObra = "El Fantasma de la Ópera", DescripcionObra = "Una historia de amor y tragedia en la Ópera de París", RutaFotoObra = "ruta/foto/fantasma_opera.jpg" },
                new Obra { ObraId = 5, NombreObra = "Esperando a Godot", DescripcionObra = "Dos personajes esperan a alguien que nunca llega", RutaFotoObra = "ruta/foto/esperando_godot.jpg" },
                new Obra { ObraId = 6, NombreObra = "Macbeth", DescripcionObra = "Una tragedia sobre ambición y traición", RutaFotoObra = "ruta/foto/macbeth.jpg" },
                new Obra { ObraId = 7, NombreObra = "Los Miserables", DescripcionObra = "La historia de Jean Valjean y su redención", RutaFotoObra = "ruta/foto/los_miserables.jpg" },
                new Obra { ObraId = 8, NombreObra = "Otelo", DescripcionObra = "Celos y traición en la Venecia del siglo XVI", RutaFotoObra = "ruta/foto/otelo.jpg" },
                new Obra { ObraId = 9, NombreObra = "La Gaviota", DescripcionObra = "Drama de amor y desilusión en la sociedad rusa del siglo XIX", RutaFotoObra = "ruta/foto/la_gaviota.jpg" },
                new Obra { ObraId = 10, NombreObra = "La Opera de los Tres Centavos", DescripcionObra = "Una ópera sobre el crimen y la pobreza en Londres", RutaFotoObra = "ruta/foto/Fopera_tres_centavos.jpg" }
            );

            modelBuilder.Entity<Asiento>().HasData(
                new Asiento { AsientoId = 1, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 2, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 3, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 4, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 5, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 6, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 7, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 8, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 9, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 10, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 11, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 12, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 13, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 14, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 15, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 16, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 17, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 18, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 19, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 20, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 21, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 22, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 23, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 24, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 25, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 26, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 27, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 28, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 29, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 30, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 31, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 32, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 33, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 34, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 35, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 36, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 37, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 38, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 39, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 40, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 41, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 42, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 43, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 44, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 45, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 46, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 47, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 48, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 49, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 50, SalaId = 1, TipoAsiento = 1 },
                new Asiento { AsientoId = 51, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 52, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 53, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 54, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 55, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 56, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 57, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 58, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 59, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 60, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 61, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 62, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 63, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 64, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 65, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 66, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 67, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 68, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 69, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 70, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 71, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 72, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 73, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 74, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 75, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 76, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 77, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 78, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 79, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 80, SalaId = 2, TipoAsiento = 1 },
                new Asiento { AsientoId = 81, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 82, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 83, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 84, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 85, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 86, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 87, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 88, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 89, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 90, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 91, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 92, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 93, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 94, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 95, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 96, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 97, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 98, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 99, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 100, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 101, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 102, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 103, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 104, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 105, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 106, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 107, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 108, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 109, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 110, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 111, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 112, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 113, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 114, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 115, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 116, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 117, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 118, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 119, SalaId = 3, TipoAsiento = 1 },
                new Asiento { AsientoId = 120, SalaId = 3, TipoAsiento = 1 }
            );


            modelBuilder.Entity<Sesion>().HasData(
                new Sesion { SesionId = 1, ObraId = 1, FechaHora = new DateTime(2024, 4, 1, 18, 0, 0), SalaId = 1 }, 
                new Sesion { SesionId = 2, ObraId = 2, FechaHora = new DateTime(2024, 4, 2, 19, 0, 0), SalaId = 2 }, 
                new Sesion { SesionId = 3, ObraId = 1, FechaHora = new DateTime(2024, 4, 3, 20, 0, 0), SalaId = 3 }, 
                new Sesion { SesionId = 4, ObraId = 1, FechaHora = new DateTime(2024, 4, 4, 17, 30, 0), SalaId = 1 }, 
                new Sesion { SesionId = 5, ObraId = 3, FechaHora = new DateTime(2024, 4, 5, 18, 0, 0), SalaId = 2 }, 
                new Sesion { SesionId = 6, ObraId = 3, FechaHora = new DateTime(2024, 4, 6, 19, 30, 0), SalaId = 3 }, 
                new Sesion { SesionId = 7, ObraId = 4, FechaHora = new DateTime(2024, 4, 7, 20, 0, 0), SalaId = 1 }, 
                new Sesion { SesionId = 8, ObraId = 4, FechaHora = new DateTime(2024, 4, 8, 17, 0, 0), SalaId = 2 }, 
                new Sesion { SesionId = 9, ObraId = 5, FechaHora = new DateTime(2024, 4, 9, 18, 30, 0), SalaId = 3 }, 
                new Sesion { SesionId = 10, ObraId = 5, FechaHora = new DateTime(2024, 4, 10, 19, 0, 0), SalaId = 1 }, 
                new Sesion { SesionId = 11, ObraId = 6, FechaHora = new DateTime(2024, 4, 11, 20, 0, 0), SalaId = 2 }, 
                new Sesion { SesionId = 12, ObraId = 6, FechaHora = new DateTime(2024, 4, 12, 17, 30, 0), SalaId = 3 }, 
                new Sesion { SesionId = 13, ObraId = 7, FechaHora = new DateTime(2024, 4, 13, 18, 0, 0), SalaId = 1 }, 
                new Sesion { SesionId = 14, ObraId = 7, FechaHora = new DateTime(2024, 4, 14, 19, 30, 0), SalaId = 2 }, 
                new Sesion { SesionId = 15, ObraId = 8, FechaHora = new DateTime(2024, 4, 15, 20, 0, 0), SalaId = 3 }, 
                new Sesion { SesionId = 16, ObraId = 8, FechaHora = new DateTime(2024, 4, 16, 17, 0, 0), SalaId = 1 }, 
                new Sesion { SesionId = 17, ObraId = 9, FechaHora = new DateTime(2024, 4, 17, 18, 30, 0), SalaId = 2 },
                new Sesion { SesionId = 18, ObraId = 9, FechaHora = new DateTime(2024, 4, 18, 19, 0, 0), SalaId = 3 }, 
                new Sesion { SesionId = 19, ObraId = 10, FechaHora = new DateTime(2024, 4, 19, 20, 0, 0), SalaId = 1 },
                new Sesion { SesionId = 20, ObraId = 10, FechaHora = new DateTime(2024, 4, 20, 17, 0, 0), SalaId = 2 } 
            );


            modelBuilder.Entity<Compra>().HasData(
                new Compra { AsientoId = 1, SesionId = 1, UsuarioId = 1 },
                new Compra { AsientoId = 2, SesionId = 1, UsuarioId = 2 }
            );



            // Relación entre Sesion y Sala
            modelBuilder.Entity<Sesion>()
                .HasOne(s => s.Sala)
                .WithMany(sala => sala.Sesiones)
                .HasForeignKey(s => s.SalaId)
                .IsRequired(); // Esto asegura que el SalaId sea obligatorio en la relación

            modelBuilder.Entity<Sesion>()
                .Property(s => s.SalaId)
                .IsRequired(); // Esto también asegura que el SalaId sea obligatorio en la tabla Sesion

            //Tabla intermedia de compras
            modelBuilder.Entity<Compra>()
                .HasKey(pi => new { pi.SesionId, pi.AsientoId, pi.UsuarioId });

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.Compras)
                .HasForeignKey(c => c.UsuarioId);

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Sesion)
                .WithMany(s => s.Compras)
                .HasForeignKey(c => c.SesionId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Asiento)
                .WithMany(s => s.Compras)
                .HasForeignKey(c => c.AsientoId);

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
