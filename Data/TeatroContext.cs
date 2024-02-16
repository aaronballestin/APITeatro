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
            modelBuilder.Entity<Entrada>().HasData(
                new Entrada { EntradaId = 1 }
            );
            modelBuilder.Entity<Obra>().HasData(
                new Obra { ObraId = 1 }
            );
            modelBuilder.Entity<Asiento>().HasData(
                new Asiento { AsientoId = 1}
            );





        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Asiento> Asientos { get; set; }




    }
}

