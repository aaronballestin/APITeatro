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
                new Usuario { UsuarioId = 2, NombreUsuario = "María", EmailUsuario = "maria@example.com", PasswordUsuario = "1234", Rol = "Admin" }
            );

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { CategoriaId = 1, NombreCategoria = "Drama" },
                new Categoria { CategoriaId = 2, NombreCategoria = "Comedia" }
            );

            modelBuilder.Entity<Obra>().HasData(
                new Obra { ObraId = 1, CategoriaId = 1, NombreObra = "Hamlet", DescripcionObra = "Una tragedia clásica", RutaFotoObra = "ruta/foto/hamlet.jpg" },
                new Obra { ObraId = 2, CategoriaId = 2, NombreObra = "La Casa de Bernarda Alba", DescripcionObra = "Un drama familiar", RutaFotoObra = "ruta/foto/bernarda_alba.jpg" }
            );

            modelBuilder.Entity<Asiento>().HasData(
                new Asiento { AsientoId = 1, Fila = 1, Columna = 1 },
                new Asiento { AsientoId = 2, Fila = 1, Columna = 2 },
                new Asiento { AsientoId = 3, Fila = 2, Columna = 1 },
                new Asiento { AsientoId = 4, Fila = 2, Columna = 2 }
            );

            modelBuilder.Entity<Sesion>().HasData(
                new Sesion { SesionId = 1, ObraId = 1, FechaHora = DateTime.Now.AddDays(7) },
                new Sesion { SesionId = 2, ObraId = 2, FechaHora = DateTime.Now.AddDays(14) }
            );

            modelBuilder.Entity<Compra>().HasData(
                new Compra { EntradaId = 1, AsientoId = 1, SesionId = 1, UsuarioId = 1 },
                new Compra { EntradaId = 2, AsientoId = 2, SesionId = 1, UsuarioId = 2 }
            );

            modelBuilder.Entity<SesionAsiento>().HasData(
                new SesionAsiento { SesionId = 1, AsientoId = 1, Ocupado = true },
                new SesionAsiento { SesionId = 1, AsientoId = 2, Ocupado = false }
            );


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
                .HasForeignKey(c => c.SesionId);

            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Asiento)
                .WithMany(s => s.Compras)
                .HasForeignKey(c => c.AsientoId);

            //Tabla intermedia de sesionAsientos
            modelBuilder.Entity<SesionAsiento>()
                .HasKey(pi => new { pi.SesionId, pi.AsientoId });

            modelBuilder.Entity<SesionAsiento>()
                .HasOne(pi => pi.Sesion)
                .WithMany(p => p.SesionAsientos)
                .HasForeignKey(pi => pi.SesionId);

            modelBuilder.Entity<SesionAsiento>()
                .HasOne(pi => pi.Asiento)
                .WithMany(p => p.SesionAsientos)
                .HasForeignKey(pi => pi.AsientoId);

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<SesionAsiento> SesionAsientos { get; set; }
    }
}
