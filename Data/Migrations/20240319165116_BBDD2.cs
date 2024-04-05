using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesCompras",
                table: "DetallesCompras");

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "CompraId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "CompraId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "CompraId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "CompraId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesCompras",
                table: "DetallesCompras",
                columns: new[] { "SesionId", "AsientoId" });

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "SesionId", "CompraId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 7, 1, 2 },
                    { 2, 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(209), "Admin", "Una de las obras más famosas de William Shakespeare, Hamlet es una tragedia que narra la historia del príncipe Hamlet de Dinamarca, quien busca vengar la muerte de su padre a manos de su tío Claudio, que luego se convierte en rey. La obra explora temas como la venganza, la locura, la traición y la corrupción. Hamlet es conocida por su profundidad psicológica y sus famosos soliloquios, incluyendo el famoso 'Ser o no ser, esa es la cuestión'.", 180 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(261), "Admin", "La Casa de Bernarda Alba es una obra de teatro escrita por el dramaturgo español Federico García Lorca. Ambientada en un pueblo de Andalucía, la obra narra la historia de Bernarda Alba, una viuda adinerada y autoritaria que impone un luto riguroso a sus cinco hijas. La obra explora temas como la opresión, la represión sexual y la lucha por la libertad personal en un entorno dominado por las normas sociales y las expectativas culturales.", 150 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(263), "Admin", "Romeo y Julieta es una de las tragedias más conocidas de William Shakespeare. La obra cuenta la historia de dos jóvenes amantes cuyas familias, los Montesco y los Capuleto, están enfrentadas. A pesar de los obstáculos que enfrentan, Romeo y Julieta se enamoran apasionadamente y se casan en secreto. Sin embargo, el destino trágico les aguarda. La obra explora temas como el amor, el odio, el destino y el sacrificio.", 160 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(265), "Admin", "El Fantasma de la Ópera es un musical de Andrew Lloyd Webber basado en la novela homónima de Gaston Leroux. La historia se desarrolla en la Ópera de París, donde un misterioso fantasma aterroriza a la compañía y se enamora de Christine, una joven cantante. La obra combina romance, tragedia y horror en un ambiente gótico y emocionante.", 200 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(267), "Admin", "Esperando a Godot es una obra de teatro escrita por Samuel Beckett. La obra sigue a dos personajes, Vladimir y Estragón, que esperan la llegada de alguien llamado Godot, pero nunca llega. Mientras esperan, pasan el tiempo conversando, discutiendo y realizando actividades triviales. La obra es conocida por su estilo absurdo y sus temas existenciales.", 120 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(269), "Admin", "Macbeth es una tragedia escrita por William Shakespeare. La obra narra la historia de Macbeth, un noble escocés que, incitado por la profecía de tres brujas, asesina al rey Duncan y se convierte en rey de Escocia. Sin embargo, su sed de poder lo lleva a cometer más crímenes, lo que finalmente conduce a su propia destrucción. Macbeth es conocida por su exploración de temas como la ambición, la culpa y el destino.", 170 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(271), "Admin", "Los Miserables es un musical basado en la novela homónima de Victor Hugo. La historia sigue las vidas entrelazadas de varios personajes, incluido Jean Valjean, un exconvicto que busca redención; Javert, un inspector de policía obsesionado con atraparlo; y Cosette, la hija adoptiva de Valjean. La obra aborda temas como la justicia, la redención y la lucha por la libertad durante la Revolución Francesa.", 210 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(273), "Admin", "Otelo es una tragedia escrita por William Shakespeare. La obra cuenta la historia del moro Otelo, un general veneciano que se casa con Desdémona, una joven veneciana. Sin embargo, su matrimonio es amenazado por la manipulación de Yago, un subordinado celoso de Otelo, que alimenta los celos de Otelo y lo lleva a cometer un acto trágico de violencia. Otelo explora temas como los celos, la traición y la tragedia del malentendido.", 190 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(275), "Admin", "La Gaviota es una obra de teatro escrita por el dramaturgo ruso Anton Chejov. Ambientada en una finca rural en Rusia, la obra sigue las vidas entrelazadas de varios personajes, incluida la famosa actriz Irina Arkádina, su amante Boris Trigorin y el aspirante a escritor Konstantín Tréplev. La Gaviota explora temas como el arte, el amor, la creatividad y la insatisfacción personal.", 180 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(279), "Admin", "La Opera de los Tres Centavos es una ópera escrita por el dramaturgo alemán Bertolt Brecht, con música de Kurt Weill. Basada en la ópera del siglo XVIII El mendigo ladrón, la obra satiriza la sociedad capitalista y sigue las aventuras del criminal Mackie Messer, también conocido como Mack the Knife. La Opera de los Tres Centavos explora temas como la corrupción, la pobreza y la moralidad en la sociedad urbana.", 200 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "EmailUsuario", "NombreUsuario" },
                values: new object[] { "default@example.com", "Default" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesCompras",
                table: "DetallesCompras");

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesCompras",
                table: "DetallesCompras",
                columns: new[] { "CompraId", "AsientoId" });

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "CompraId", "SesionId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 2, 2, 2 },
                    { 7, 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "Una tragedia clásica", 0 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "Un drama familiar", 0 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "Amor prohibido entre dos familias rivales", 0 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "Una historia de amor y tragedia en la Ópera de París", 0 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "Dos personajes esperan a alguien que nunca llega", 0 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "Una tragedia sobre ambición y traición", 0 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "La historia de Jean Valjean y su redención", 0 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "Celos y traición en la Venecia del siglo XVI", 0 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "Drama de amor y desilusión en la sociedad rusa del siglo XIX", 0 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra" },
                values: new object[] { null, null, "Una ópera sobre el crimen y la pobreza en Londres", 0 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "EmailUsuario", "NombreUsuario" },
                values: new object[] { "juan@example.com", "Juan" });
        }
    }
}
