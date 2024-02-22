﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeatroApi.Data;

#nullable disable

namespace TeatroApi.Data.Migrations
{
    [DbContext(typeof(TeatroContext))]
    [Migration("20240222191921_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeatroApi.Models.Asiento", b =>
                {
                    b.Property<int>("AsientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AsientoId"));

                    b.Property<int>("Columna")
                        .HasColumnType("int");

                    b.Property<int>("Fila")
                        .HasColumnType("int");

                    b.HasKey("AsientoId");

                    b.ToTable("Asientos");

                    b.HasData(
                        new
                        {
                            AsientoId = 1,
                            Columna = 1,
                            Fila = 1
                        },
                        new
                        {
                            AsientoId = 2,
                            Columna = 2,
                            Fila = 1
                        },
                        new
                        {
                            AsientoId = 3,
                            Columna = 1,
                            Fila = 2
                        },
                        new
                        {
                            AsientoId = 4,
                            Columna = 2,
                            Fila = 2
                        });
                });

            modelBuilder.Entity("TeatroApi.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("NombreCategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            NombreCategoria = "Drama"
                        },
                        new
                        {
                            CategoriaId = 2,
                            NombreCategoria = "Comedia"
                        });
                });

            modelBuilder.Entity("TeatroApi.Models.Compra", b =>
                {
                    b.Property<int>("SesionId")
                        .HasColumnType("int");

                    b.Property<int>("AsientoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("EntradaId")
                        .HasColumnType("int");

                    b.HasKey("SesionId", "AsientoId", "UsuarioId");

                    b.HasIndex("AsientoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Compras");

                    b.HasData(
                        new
                        {
                            SesionId = 1,
                            AsientoId = 1,
                            UsuarioId = 1,
                            EntradaId = 1
                        },
                        new
                        {
                            SesionId = 1,
                            AsientoId = 2,
                            UsuarioId = 2,
                            EntradaId = 2
                        });
                });

            modelBuilder.Entity("TeatroApi.Models.Obra", b =>
                {
                    b.Property<int>("ObraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObraId"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("DescripcionObra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreObra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RutaFotoObra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObraId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Obras");

                    b.HasData(
                        new
                        {
                            ObraId = 1,
                            CategoriaId = 1,
                            DescripcionObra = "Una tragedia clásica",
                            NombreObra = "Hamlet",
                            RutaFotoObra = "ruta/foto/hamlet.jpg"
                        },
                        new
                        {
                            ObraId = 2,
                            CategoriaId = 2,
                            DescripcionObra = "Un drama familiar",
                            NombreObra = "La Casa de Bernarda Alba",
                            RutaFotoObra = "ruta/foto/bernarda_alba.jpg"
                        });
                });

            modelBuilder.Entity("TeatroApi.Models.Sesion", b =>
                {
                    b.Property<int>("SesionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SesionId"));

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("ObraId")
                        .HasColumnType("int");

                    b.HasKey("SesionId");

                    b.HasIndex("ObraId");

                    b.ToTable("Sesiones");

                    b.HasData(
                        new
                        {
                            SesionId = 1,
                            FechaHora = new DateTime(2024, 2, 29, 20, 19, 21, 828, DateTimeKind.Local).AddTicks(23),
                            ObraId = 1
                        },
                        new
                        {
                            SesionId = 2,
                            FechaHora = new DateTime(2024, 3, 7, 20, 19, 21, 828, DateTimeKind.Local).AddTicks(74),
                            ObraId = 2
                        });
                });

            modelBuilder.Entity("TeatroApi.Models.SesionAsiento", b =>
                {
                    b.Property<int>("SesionId")
                        .HasColumnType("int");

                    b.Property<int>("AsientoId")
                        .HasColumnType("int");

                    b.Property<bool>("Ocupado")
                        .HasColumnType("bit");

                    b.HasKey("SesionId", "AsientoId");

                    b.HasIndex("AsientoId");

                    b.ToTable("SesionAsientos");

                    b.HasData(
                        new
                        {
                            SesionId = 1,
                            AsientoId = 1,
                            Ocupado = true
                        },
                        new
                        {
                            SesionId = 1,
                            AsientoId = 2,
                            Ocupado = false
                        });
                });

            modelBuilder.Entity("TeatroApi.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            EmailUsuario = "juan@example.com",
                            NombreUsuario = "Juan",
                            PasswordUsuario = "1234",
                            Rol = "Guest"
                        },
                        new
                        {
                            UsuarioId = 2,
                            EmailUsuario = "maria@example.com",
                            NombreUsuario = "María",
                            PasswordUsuario = "1234",
                            Rol = "Admin"
                        });
                });

            modelBuilder.Entity("TeatroApi.Models.Compra", b =>
                {
                    b.HasOne("TeatroApi.Models.Asiento", "Asiento")
                        .WithMany("Compras")
                        .HasForeignKey("AsientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeatroApi.Models.Sesion", "Sesion")
                        .WithMany("Compras")
                        .HasForeignKey("SesionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeatroApi.Models.Usuario", "Usuario")
                        .WithMany("Compras")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asiento");

                    b.Navigation("Sesion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TeatroApi.Models.Obra", b =>
                {
                    b.HasOne("TeatroApi.Models.Categoria", "Categoria")
                        .WithMany("Obras")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("TeatroApi.Models.Sesion", b =>
                {
                    b.HasOne("TeatroApi.Models.Obra", "Obra")
                        .WithMany("Sesiones")
                        .HasForeignKey("ObraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Obra");
                });

            modelBuilder.Entity("TeatroApi.Models.SesionAsiento", b =>
                {
                    b.HasOne("TeatroApi.Models.Asiento", "Asiento")
                        .WithMany("SesionAsientos")
                        .HasForeignKey("AsientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeatroApi.Models.Sesion", "Sesion")
                        .WithMany("SesionAsientos")
                        .HasForeignKey("SesionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asiento");

                    b.Navigation("Sesion");
                });

            modelBuilder.Entity("TeatroApi.Models.Asiento", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("SesionAsientos");
                });

            modelBuilder.Entity("TeatroApi.Models.Categoria", b =>
                {
                    b.Navigation("Obras");
                });

            modelBuilder.Entity("TeatroApi.Models.Obra", b =>
                {
                    b.Navigation("Sesiones");
                });

            modelBuilder.Entity("TeatroApi.Models.Sesion", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("SesionAsientos");
                });

            modelBuilder.Entity("TeatroApi.Models.Usuario", b =>
                {
                    b.Navigation("Compras");
                });
#pragma warning restore 612, 618
        }
    }
}
