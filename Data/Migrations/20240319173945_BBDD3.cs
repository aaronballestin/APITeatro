using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 52,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 53,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 54,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 55,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 56,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 57,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 58,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 59,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 60,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 61,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 62,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 63,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 64,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 65,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 66,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 67,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 68,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 69,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 70,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 71,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 72,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 73,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 74,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 75,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 76,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 77,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 78,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 79,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 80,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 81,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 82,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 83,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 84,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 85,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 86,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 87,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 88,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 89,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 90,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { -10.0, 3 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 111,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 112,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 113,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 114,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 115,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 116,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 117,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 118,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 119,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 120,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 2,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "CompraId", "AsientoId", "FechaCompra", "PrecioCompra", "SesionId", "UsuarioId" },
                values: new object[,]
                {
                    { 3, null, null, 0.0, 1, 1 },
                    { 4, null, null, 0.0, 1, 1 },
                    { 5, null, null, 0.0, 1, 1 },
                    { 6, null, null, 0.0, 1, 1 },
                    { 7, null, null, 0.0, 1, 1 },
                    { 8, null, null, 0.0, 1, 1 },
                    { 9, null, null, 0.0, 1, 1 },
                    { 10, null, null, 0.0, 1, 1 }
                });

            migrationBuilder.UpdateData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 7, 1 },
                column: "CompraId",
                value: 3);

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "SesionId", "CompraId" },
                values: new object[] { 62, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5718), "Una de las obras más famosas de William Shakespeare, Hamlet es una tragedia que narra la historia del príncipe Hamlet de Dinamarca, quien busca vengar la muerte de su padre a manos de su tío Claudio, que luego se convierte en rey. La obra explora temas como la venganza, la locura, la traición y la corrupción'." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5767), "La Casa de Bernarda Alba es una obra de teatro escrita por el dramaturgo español Federico García Lorca. Ambientada en un pueblo de Andalucía, la obra narra la historia de Bernarda Alba, una viuda adinerada y autoritaria que impone un luto riguroso a sus cinco hijas." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5769), "Romeo y Julieta es una de las tragedias más conocidas de William Shakespeare. La obra cuenta la historia de dos jóvenes amantes cuyas familias, los Montesco y los Capuleto, están enfrentadas. A pesar de los obstáculos que enfrentan, Romeo y Julieta se enamoran apasionadamente y se casan en secreto." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5771), "El Fantasma de la Ópera es un musical de Andrew Lloyd Webber basado en la novela homónima de Gaston Leroux. La historia se desarrolla en la Ópera de París, donde un misterioso fantasma aterroriza a la compañía y se enamora de Christine, una joven cantante." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5773), "Esperando a Godot es una obra de teatro escrita por Samuel Beckett. La obra sigue a dos personajes, Vladimir y Estragón, que esperan la llegada de alguien llamado Godot, pero nunca llega. Mientras esperan, pasan el tiempo conversando, discutiendo y realizando actividades triviales." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5775), "Macbeth es una tragedia escrita por William Shakespeare. La obra narra la historia de Macbeth, un noble escocés que, incitado por la profecía de tres brujas, asesina al rey Duncan y se convierte en rey de Escocia. Sin embargo, su sed de poder lo lleva a cometer más crímenes, lo que finalmente conduce a su propia destrucción." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5777), "Los Miserables es un musical basado en la novela homónima de Victor Hugo. La historia sigue las vidas entrelazadas de varios personajes, incluido Jean Valjean, un exconvicto que busca redención; Javert, un inspector de policía obsesionado con atraparlo; y Cosette, la hija adoptiva de Valjean." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5779), "Otelo es una tragedia escrita por William Shakespeare. La obra cuenta la historia del moro Otelo, un general veneciano que se casa con Desdémona, una joven veneciana. Sin embargo, su matrimonio es amenazado por la manipulación de Yago, un subordinado celoso de Otelo, que alimenta los celos de Otelo y lo lleva a cometer un acto trágico de violencia. " });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5781), "La Gaviota es una obra de teatro escrita por el dramaturgo ruso Anton Chejov. Ambientada en una finca rural en Rusia, la obra sigue las vidas entrelazadas de varios personajes, incluida la famosa actriz Irina Arkádina, su amante Boris Trigorin y el aspirante a escritor Konstantín Tréplev." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5783), "La Opera de los Tres Centavos es una ópera escrita por el dramaturgo alemán Bertolt Brecht, con música de Kurt Weill. Basada en la ópera del siglo XVIII El mendigo ladrón, la obra satiriza la sociedad capitalista y sigue las aventuras del criminal Mackie Messer, también conocido como Mack the Knife." });

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 2,
                columns: new[] { "AsientosNormales", "AsientosVip" },
                values: new object[] { 0, 30 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 62, 2 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 52,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 53,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 54,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 55,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 56,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 57,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 58,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 59,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 60,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 61,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 62,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 63,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 64,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 65,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 66,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 67,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 68,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 69,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 70,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 71,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 72,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 73,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 74,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 75,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 76,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 77,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 78,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 79,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 80,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 81,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 82,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 83,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 84,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 85,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 86,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 87,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 88,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 89,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 90,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 111,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 112,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 113,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 114,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 115,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 116,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 117,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 118,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 119,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 120,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 2,
                column: "UsuarioId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 7, 1 },
                column: "CompraId",
                value: 2);

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "SesionId", "CompraId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(209), "Una de las obras más famosas de William Shakespeare, Hamlet es una tragedia que narra la historia del príncipe Hamlet de Dinamarca, quien busca vengar la muerte de su padre a manos de su tío Claudio, que luego se convierte en rey. La obra explora temas como la venganza, la locura, la traición y la corrupción. Hamlet es conocida por su profundidad psicológica y sus famosos soliloquios, incluyendo el famoso 'Ser o no ser, esa es la cuestión'." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(261), "La Casa de Bernarda Alba es una obra de teatro escrita por el dramaturgo español Federico García Lorca. Ambientada en un pueblo de Andalucía, la obra narra la historia de Bernarda Alba, una viuda adinerada y autoritaria que impone un luto riguroso a sus cinco hijas. La obra explora temas como la opresión, la represión sexual y la lucha por la libertad personal en un entorno dominado por las normas sociales y las expectativas culturales." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(263), "Romeo y Julieta es una de las tragedias más conocidas de William Shakespeare. La obra cuenta la historia de dos jóvenes amantes cuyas familias, los Montesco y los Capuleto, están enfrentadas. A pesar de los obstáculos que enfrentan, Romeo y Julieta se enamoran apasionadamente y se casan en secreto. Sin embargo, el destino trágico les aguarda. La obra explora temas como el amor, el odio, el destino y el sacrificio." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(265), "El Fantasma de la Ópera es un musical de Andrew Lloyd Webber basado en la novela homónima de Gaston Leroux. La historia se desarrolla en la Ópera de París, donde un misterioso fantasma aterroriza a la compañía y se enamora de Christine, una joven cantante. La obra combina romance, tragedia y horror en un ambiente gótico y emocionante." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(267), "Esperando a Godot es una obra de teatro escrita por Samuel Beckett. La obra sigue a dos personajes, Vladimir y Estragón, que esperan la llegada de alguien llamado Godot, pero nunca llega. Mientras esperan, pasan el tiempo conversando, discutiendo y realizando actividades triviales. La obra es conocida por su estilo absurdo y sus temas existenciales." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(269), "Macbeth es una tragedia escrita por William Shakespeare. La obra narra la historia de Macbeth, un noble escocés que, incitado por la profecía de tres brujas, asesina al rey Duncan y se convierte en rey de Escocia. Sin embargo, su sed de poder lo lleva a cometer más crímenes, lo que finalmente conduce a su propia destrucción. Macbeth es conocida por su exploración de temas como la ambición, la culpa y el destino." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(271), "Los Miserables es un musical basado en la novela homónima de Victor Hugo. La historia sigue las vidas entrelazadas de varios personajes, incluido Jean Valjean, un exconvicto que busca redención; Javert, un inspector de policía obsesionado con atraparlo; y Cosette, la hija adoptiva de Valjean. La obra aborda temas como la justicia, la redención y la lucha por la libertad durante la Revolución Francesa." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(273), "Otelo es una tragedia escrita por William Shakespeare. La obra cuenta la historia del moro Otelo, un general veneciano que se casa con Desdémona, una joven veneciana. Sin embargo, su matrimonio es amenazado por la manipulación de Yago, un subordinado celoso de Otelo, que alimenta los celos de Otelo y lo lleva a cometer un acto trágico de violencia. Otelo explora temas como los celos, la traición y la tragedia del malentendido." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(275), "La Gaviota es una obra de teatro escrita por el dramaturgo ruso Anton Chejov. Ambientada en una finca rural en Rusia, la obra sigue las vidas entrelazadas de varios personajes, incluida la famosa actriz Irina Arkádina, su amante Boris Trigorin y el aspirante a escritor Konstantín Tréplev. La Gaviota explora temas como el arte, el amor, la creatividad y la insatisfacción personal." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 19, 17, 51, 16, 273, DateTimeKind.Local).AddTicks(279), "La Opera de los Tres Centavos es una ópera escrita por el dramaturgo alemán Bertolt Brecht, con música de Kurt Weill. Basada en la ópera del siglo XVIII El mendigo ladrón, la obra satiriza la sociedad capitalista y sigue las aventuras del criminal Mackie Messer, también conocido como Mack the Knife. La Opera de los Tres Centavos explora temas como la corrupción, la pobreza y la moralidad en la sociedad urbana." });

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 2,
                columns: new[] { "AsientosNormales", "AsientosVip" },
                values: new object[] { 100, 0 });
        }
    }
}
