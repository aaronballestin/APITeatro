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
                new Usuario { UsuarioId = 1, NombreUsuario = "Default", EmailUsuario = "default@example.com", PasswordUsuario = "1234", Rol = "Guest" },
                new Usuario { UsuarioId = 2, NombreUsuario = "María", EmailUsuario = "admin@example.com", PasswordUsuario = "1234", Rol = "Admin" },
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
                new Sala { SalaId = 1, AsientosNormales = 50, AsientosMinusvalidos = 0, AsientosVip = 0 },
                new Sala { SalaId = 2, AsientosNormales = 0, AsientosMinusvalidos = 0, AsientosVip = 30 },
                new Sala { SalaId = 3, AsientosNormales = 20, AsientosMinusvalidos = 10, AsientosVip = 10 }

            );


            modelBuilder.Entity<Obra>().HasData(
                new Obra
                {
                    ObraId = 1,
                    NombreObra = "Hamlet",
                    DescripcionObra = "Una de las obras más famosas de William Shakespeare, Hamlet es una tragedia que narra la historia del príncipe Hamlet de Dinamarca, quien busca vengar la muerte de su padre a manos de su tío Claudio, que luego se convierte en rey.",
                    RutaFotoObra = "/src/assets/images/hamlet.jpg",
                    DuracionObra = 180,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                },
                new Obra
                {
                    ObraId = 2,
                    NombreObra = "La Casa de Bernarda Alba",
                    DescripcionObra = "La Casa de Bernarda Alba es una obra de teatro escrita por el dramaturgo español Federico García Lorca. Ambientada en un pueblo de Andalucía, la obra narra la historia de Bernarda Alba, una viuda adinerada y autoritaria que impone un luto riguroso a sus cinco hijas.",
                    RutaFotoObra = "/src/assets/images/LaCasaDeBernardaAlba.jpg",
                    DuracionObra = 150,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                },
                new Obra
                {
                    ObraId = 3,
                    NombreObra = "Romeo y Julieta",
                    DescripcionObra = "Romeo y Julieta es una de las tragedias más conocidas de William Shakespeare. La obra cuenta la historia de dos jóvenes amantes cuyas familias, los Montesco y los Capuleto, están enfrentadas.",
                    RutaFotoObra = "/src/assets/images/RomeoyJulieta.jpg",
                    DuracionObra = 160,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                },
                new Obra
                {
                    ObraId = 4,
                    NombreObra = "El Fantasma de la Ópera",
                    DescripcionObra = "El Fantasma de la Ópera es un musical de Andrew Lloyd Webber basado en la novela homónima de Gaston Leroux. La historia se desarrolla en la Ópera de París, donde un misterioso fantasma aterroriza a la compañía y se enamora de Christine, una joven cantante.",
                    RutaFotoObra = "/src/assets/images/ElFantasmaDeLaOpera.jpg",
                    DuracionObra = 200,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                },
                new Obra
                {
                    ObraId = 5,
                    NombreObra = "Esperando a Godot",
                    DescripcionObra = "Esperando a Godot es una obra de teatro escrita por Samuel Beckett. La obra sigue a dos personajes, Vladimir y Estragón, que esperan la llegada de alguien llamado Godot, pero nunca llega.",
                    RutaFotoObra = "/src/assets/images/EsperandoAGodot.jpg",
                    DuracionObra = 120,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                },
                new Obra
                {
                    ObraId = 6,
                    NombreObra = "Macbeth",
                    DescripcionObra = "Macbeth es una tragedia escrita por William Shakespeare. La obra narra la historia de Macbeth, un noble escocés que, incitado por la profecía de tres brujas, asesina al rey Duncan y se convierte en rey de Escocia. ",
                    RutaFotoObra = "/src/assets/images/Macbeth.jpg",
                    DuracionObra = 170,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                },
                new Obra
                {
                    ObraId = 7,
                    NombreObra = "Los Miserables",
                    DescripcionObra = "Los Miserables es un musical basado en la novela homónima de Victor Hugo. La historia sigue las vidas entrelazadas de varios personajes, incluido Jean Valjean, un exconvicto que busca redención; Javert, un inspector de policía obsesionado con atraparlo; y Cosette, la hija adoptiva de Valjean.",
                    RutaFotoObra = "/src/assets/images/LosMiserables.jpg",
                    DuracionObra = 210,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                },
                new Obra
                {
                    ObraId = 8,
                    NombreObra = "Otelo",
                    DescripcionObra = "Otelo es una tragedia escrita por William Shakespeare. La obra cuenta la historia del moro Otelo, un general veneciano que se casa con Desdémona, una joven veneciana. ",
                    RutaFotoObra = "/src/assets/images/Otelo.jpg",
                    DuracionObra = 190,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                },
                new Obra
                {
                    ObraId = 9,
                    NombreObra = "La Gaviota",
                    DescripcionObra = "La Gaviota es una obra de teatro escrita por el dramaturgo ruso Anton Chejov. Ambientada en una finca rural en Rusia, la obra sigue las vidas entrelazadas de varios personajes, incluida la famosa actriz Irina Arkádina, su amante Boris Trigorin y el aspirante a escritor Konstantín Tréplev.",
                    RutaFotoObra = "/src/assets/images/LaGaviota.jpg",
                    DuracionObra = 180,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                },
                new Obra
                {
                    ObraId = 10,
                    NombreObra = "La Opera de los Tres Centavos",
                    DescripcionObra = "La Opera de los Tres Centavos es una ópera escrita por el dramaturgo alemán Bertolt Brecht, con música de Kurt Weill.",
                    RutaFotoObra = "/src/assets/images/LaOperaDeLosTresCentavos.jpg",
                    DuracionObra = 200,
                    AuditoriaUsuario = "Admin",
                    AuditoriaHorario = DateTime.Now
                }
            );


            modelBuilder.Entity<Asiento>().HasData(
                new Asiento { AsientoId = 1, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 2, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 3, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 4, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 5, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 6, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 7, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 8, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 9, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 10, SalaId = 1, TipoAsiento = 1, Suplemento = -10 },
                new Asiento { AsientoId = 11, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 12, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 13, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 14, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 15, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 16, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 17, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 18, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 19, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 20, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 21, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 22, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 23, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 24, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 25, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 26, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 27, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 28, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 29, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 30, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 31, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 32, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 33, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 34, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 35, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 36, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 37, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 38, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 39, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 40, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 41, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 42, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 43, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 44, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 45, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 46, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 47, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 48, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 49, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 50, SalaId = 1, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 51, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 52, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 53, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 54, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 55, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 56, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 57, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 58, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 59, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 60, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 61, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 62, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 63, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 64, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 65, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 66, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 67, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 68, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 69, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 70, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 71, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 72, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 73, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 74, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 75, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 76, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 77, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 78, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 79, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 80, SalaId = 2, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 81, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 82, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 83, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 84, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 85, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 86, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 87, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 88, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 89, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 90, SalaId = 3, TipoAsiento = 3, Suplemento = -30 },
                new Asiento { AsientoId = 91, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 92, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 93, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 94, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 95, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 96, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 97, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 98, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 99, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 100, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 101, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 102, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 103, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 104, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 105, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 106, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 107, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 108, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 109, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 110, SalaId = 3, TipoAsiento = 1, Suplemento = 0 },
                new Asiento { AsientoId = 111, SalaId = 3, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 112, SalaId = 3, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 113, SalaId = 3, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 114, SalaId = 3, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 115, SalaId = 3, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 116, SalaId = 3, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 117, SalaId = 3, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 118, SalaId = 3, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 119, SalaId = 3, TipoAsiento = 2, Suplemento = 40 },
                new Asiento { AsientoId = 120, SalaId = 3, TipoAsiento = 2, Suplemento = 40 }
            );


            modelBuilder.Entity<Sesion>().HasData(
                new Sesion { SesionId = 1, ObraId = 1, FechaHora = new DateTime(2024, 4, 7, 18, 0, 0), SalaId = 1, Precio = 50 },
                new Sesion { SesionId = 2, ObraId = 2, FechaHora = new DateTime(2024, 4, 8, 19, 0, 0), SalaId = 2, Precio = 50 },
                new Sesion { SesionId = 3, ObraId = 1, FechaHora = new DateTime(2024, 4, 8, 20, 0, 0), SalaId = 3, Precio = 50 },
                new Sesion { SesionId = 4, ObraId = 1, FechaHora = new DateTime(2024, 4, 9, 17, 30, 0), SalaId = 1, Precio = 50 },
                new Sesion { SesionId = 5, ObraId = 3, FechaHora = new DateTime(2024, 4, 10, 18, 0, 0), SalaId = 2, Precio = 50 },
                new Sesion { SesionId = 6, ObraId = 3, FechaHora = new DateTime(2024, 4, 11, 19, 30, 0), SalaId = 3, Precio = 50 },
                new Sesion { SesionId = 7, ObraId = 4, FechaHora = new DateTime(2024, 4, 12, 20, 0, 0), SalaId = 1, Precio = 50 },
                new Sesion { SesionId = 8, ObraId = 4, FechaHora = new DateTime(2024, 4, 13, 17, 0, 0), SalaId = 2, Precio = 50 },
                new Sesion { SesionId = 9, ObraId = 5, FechaHora = new DateTime(2024, 4, 14, 18, 30, 0), SalaId = 3, Precio = 50 },
                new Sesion { SesionId = 10, ObraId = 5, FechaHora = new DateTime(2024, 4, 15, 19, 0, 0), SalaId = 1, Precio = 50 },
                new Sesion { SesionId = 11, ObraId = 6, FechaHora = new DateTime(2024, 4, 16, 20, 0, 0), SalaId = 2, Precio = 50 },
                new Sesion { SesionId = 12, ObraId = 6, FechaHora = new DateTime(2024, 4, 17, 17, 30, 0), SalaId = 3, Precio = 50 },
                new Sesion { SesionId = 13, ObraId = 7, FechaHora = new DateTime(2024, 4, 18, 18, 0, 0), SalaId = 1, Precio = 50 },
                new Sesion { SesionId = 14, ObraId = 7, FechaHora = new DateTime(2024, 4, 19, 19, 30, 0), SalaId = 2, Precio = 50 },
                new Sesion { SesionId = 15, ObraId = 8, FechaHora = new DateTime(2024, 4, 20, 20, 0, 0), SalaId = 3, Precio = 50 },
                new Sesion { SesionId = 16, ObraId = 8, FechaHora = new DateTime(2024, 4, 16, 17, 0, 0), SalaId = 1, Precio = 50 },
                new Sesion { SesionId = 17, ObraId = 9, FechaHora = new DateTime(2024, 4, 17, 18, 30, 0), SalaId = 2, Precio = 50 },
                new Sesion { SesionId = 18, ObraId = 9, FechaHora = new DateTime(2024, 4, 18, 19, 0, 0), SalaId = 3, Precio = 50 },
                new Sesion { SesionId = 19, ObraId = 10, FechaHora = new DateTime(2024, 4, 19, 20, 0, 0), SalaId = 1, Precio = 50 },
                new Sesion { SesionId = 20, ObraId = 10, FechaHora = new DateTime(2024, 4, 20, 17, 0, 0), SalaId = 2, Precio = 50 }
            );


            modelBuilder.Entity<Compra>().HasData(
                new Compra { CompraId = 1, SesionId = 1, UsuarioId = 1, PrecioCompra=100, FechaCompra = DateTime.Now },
                new Compra { CompraId = 2, SesionId = 1, UsuarioId = 3, PrecioCompra=50 , FechaCompra = DateTime.Now},
                new Compra { CompraId = 3, SesionId = 1, UsuarioId = 4, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 4, SesionId = 1, UsuarioId = 5, PrecioCompra=100, FechaCompra = DateTime.Now},
                new Compra { CompraId = 5, SesionId = 1, UsuarioId = 1, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 6, SesionId = 1, UsuarioId = 3, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 7, SesionId = 1, UsuarioId = 4, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 8, SesionId = 1, UsuarioId = 5, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 9, SesionId = 1, UsuarioId = 1, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 10, SesionId = 1, UsuarioId = 3, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 11, SesionId = 2, UsuarioId = 4, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 12, SesionId = 2, UsuarioId = 5, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 13, SesionId = 2, UsuarioId = 1, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 14, SesionId = 2, UsuarioId = 3, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 15, SesionId = 2, UsuarioId = 4, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 16, SesionId = 2, UsuarioId = 5, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 17, SesionId = 2, UsuarioId = 1, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 18, SesionId = 2, UsuarioId = 1, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 19, SesionId = 2, UsuarioId = 5, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 20, SesionId = 2, UsuarioId = 4, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 21, SesionId = 3, UsuarioId = 3, PrecioCompra=50,FechaCompra = DateTime.Now },
                new Compra { CompraId = 22, SesionId = 3, UsuarioId = 2, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 23, SesionId = 3, UsuarioId = 3, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 24, SesionId = 3, UsuarioId = 4, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 25, SesionId = 3, UsuarioId = 5, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 26, SesionId = 3, UsuarioId = 6, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 27, SesionId = 3, UsuarioId = 7, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 28, SesionId = 3, UsuarioId = 8, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 29, SesionId = 3, UsuarioId = 9, PrecioCompra=50, FechaCompra = DateTime.Now},
                new Compra { CompraId = 30, SesionId = 3, UsuarioId = 12, PrecioCompra=50, FechaCompra = DateTime.Now}

            );

            modelBuilder.Entity<DetallesCompra>().HasData(
                new DetallesCompra { CompraId = 1, SesionId = 1, AsientoId = 1 },
                new DetallesCompra { CompraId = 1, SesionId = 1, AsientoId = 2 },
                new DetallesCompra { CompraId = 2, SesionId = 2, AsientoId = 62 },
                new DetallesCompra { CompraId = 3, SesionId = 1, AsientoId = 7 },
                new DetallesCompra { CompraId = 4, SesionId = 1, AsientoId = 17 },
                new DetallesCompra { CompraId = 4, SesionId = 1, AsientoId = 27 },
                new DetallesCompra { CompraId = 5, SesionId = 1, AsientoId = 25 },
                new DetallesCompra { CompraId = 6, SesionId = 1, AsientoId = 10 },
                new DetallesCompra { CompraId = 6, SesionId = 1, AsientoId = 11 },
                new DetallesCompra { CompraId = 6, SesionId = 1, AsientoId = 35 },
                new DetallesCompra { CompraId = 7, SesionId = 1, AsientoId = 45 },
                new DetallesCompra { CompraId = 8, SesionId = 1, AsientoId = 47 },
                new DetallesCompra { CompraId = 9, SesionId = 1, AsientoId = 37 },
                new DetallesCompra { CompraId = 10, SesionId = 2, AsientoId = 59 },
                new DetallesCompra { CompraId = 11, SesionId = 2, AsientoId = 51 },
                new DetallesCompra { CompraId = 11, SesionId = 2, AsientoId = 52 },
                new DetallesCompra { CompraId = 12, SesionId = 2, AsientoId = 72 },
                new DetallesCompra { CompraId = 13, SesionId = 2, AsientoId = 67 },
                new DetallesCompra { CompraId = 14, SesionId = 2, AsientoId = 77 },
                new DetallesCompra { CompraId = 15, SesionId = 2, AsientoId = 75 },
                new DetallesCompra { CompraId = 16, SesionId = 2, AsientoId = 80 },
                new DetallesCompra { CompraId = 16, SesionId = 2, AsientoId = 61 },
                new DetallesCompra { CompraId = 16, SesionId = 2, AsientoId = 55 },
                new DetallesCompra { CompraId = 17, SesionId = 2, AsientoId = 73 },
                new DetallesCompra { CompraId = 18, SesionId = 2, AsientoId = 56 },
                new DetallesCompra { CompraId = 19, SesionId = 2, AsientoId = 57 },
                new DetallesCompra { CompraId = 20, SesionId = 2, AsientoId = 79 },
                new DetallesCompra { CompraId = 21, SesionId = 3, AsientoId = 101 },
                new DetallesCompra { CompraId = 21, SesionId = 3, AsientoId = 102 },
                new DetallesCompra { CompraId = 22, SesionId = 3, AsientoId = 82 },
                new DetallesCompra { CompraId = 23, SesionId = 3, AsientoId = 97 },
                new DetallesCompra { CompraId = 24, SesionId = 3, AsientoId = 107 },
                new DetallesCompra { CompraId = 25, SesionId = 3, AsientoId = 115 },
                new DetallesCompra { CompraId = 26, SesionId = 3, AsientoId = 100 },
                new DetallesCompra { CompraId = 26, SesionId = 3, AsientoId = 81 },
                new DetallesCompra { CompraId = 26, SesionId = 3, AsientoId = 85 },
                new DetallesCompra { CompraId = 27, SesionId = 3, AsientoId = 83 },
                new DetallesCompra { CompraId = 28, SesionId = 3, AsientoId = 86 },
                new DetallesCompra { CompraId = 29, SesionId = 3, AsientoId = 98 },
                new DetallesCompra { CompraId = 30, SesionId = 3, AsientoId = 119 }

            );

            // Relación entre Sesion y Sala
            modelBuilder.Entity<Sesion>()
                .HasOne(s => s.Sala)
                .WithMany(sala => sala.Sesiones)
                .HasForeignKey(s => s.SalaId)
                .IsRequired();
            modelBuilder.Entity<Sesion>()
                .Property(s => s.SalaId)
                .IsRequired();

            //Tabla intermedia de compras
            modelBuilder.Entity<Compra>()
                .HasKey(c => c.CompraId);
            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.Compras)
                .HasForeignKey(c => c.UsuarioId);
            modelBuilder.Entity<Compra>()
                .HasOne(c => c.Sesion)
                .WithMany(s => s.Compras)
                .HasForeignKey(c => c.SesionId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Sala>()
                   .HasKey(s => s.SalaId);
            modelBuilder.Entity<DetallesCompra>()
            .HasKey(dc => new { dc.SesionId, dc.AsientoId });

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<DetallesCompra> DetallesCompras { get; set; }

        public DbSet<Sala> Salas { get; set; }
    }
}