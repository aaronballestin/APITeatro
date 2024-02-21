using Microsoft.EntityFrameworkCore;
using TeatroApi.Models;
using Microsoft.Extensions.Configuration;

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
                new Usuario { UsuarioId = 1 }
            );
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { CategoriaId = 1 }
            );
            modelBuilder.Entity<Obra>().HasData(
                new Obra { ObraId = 1 }
            );
            modelBuilder.Entity<Asiento>().HasData(
                new Asiento { AsientoId = 1, Fila = 1, Columna = 1 }
            );

            //Tabla intermedia de compras
            modelBuilder.Entity<Compra>()
                .HasKey(pi => new { pi.SesionId, pi.AsientoId, pi.UsuarioId });

            modelBuilder.Entity<Compra>()
                .HasOne(pi => pi.Sesion)
                .WithMany(p => p.Compras)
                .HasForeignKey(pi => pi.SesionId);

            modelBuilder.Entity<Compra>()
                .HasOne(pi => pi.Asiento)
                .WithMany(p => p.Compras)
                .HasForeignKey(pi => pi.AsientoId);

            modelBuilder.Entity<Compra>()
                .HasOne(pi => pi.Usuario)
                .WithMany(p => p.Compras)
                .HasForeignKey(pi => pi.UsuarioId);
        }



        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Asiento> Asientos { get; set; }




    }
}

