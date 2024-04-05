using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 8, 5, 104, DateTimeKind.Local).AddTicks(9975), "Una de las obras más famosas de William Shakespeare, Hamlet es una tragedia que narra la historia del príncipe Hamlet de Dinamarca, quien busca vengar la muerte de su padre a manos de su tío Claudio, que luego se convierte en rey." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(33), "Romeo y Julieta es una de las tragedias más conocidas de William Shakespeare. La obra cuenta la historia de dos jóvenes amantes cuyas familias, los Montesco y los Capuleto, están enfrentadas." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(37), "Esperando a Godot es una obra de teatro escrita por Samuel Beckett. La obra sigue a dos personajes, Vladimir y Estragón, que esperan la llegada de alguien llamado Godot, pero nunca llega." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(40), "Macbeth es una tragedia escrita por William Shakespeare. La obra narra la historia de Macbeth, un noble escocés que, incitado por la profecía de tres brujas, asesina al rey Duncan y se convierte en rey de Escocia. " });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(44), "Otelo es una tragedia escrita por William Shakespeare. La obra cuenta la historia del moro Otelo, un general veneciano que se casa con Desdémona, una joven veneciana. " });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(48), "La Opera de los Tres Centavos es una ópera escrita por el dramaturgo alemán Bertolt Brecht, con música de Kurt Weill." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8785), "Una de las obras más famosas de William Shakespeare, Hamlet es una tragedia que narra la historia del príncipe Hamlet de Dinamarca, quien busca vengar la muerte de su padre a manos de su tío Claudio, que luego se convierte en rey. La obra explora temas como la venganza, la locura, la traición y la corrupción'." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8834), "Romeo y Julieta es una de las tragedias más conocidas de William Shakespeare. La obra cuenta la historia de dos jóvenes amantes cuyas familias, los Montesco y los Capuleto, están enfrentadas. A pesar de los obstáculos que enfrentan, Romeo y Julieta se enamoran apasionadamente y se casan en secreto." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8866), "Esperando a Godot es una obra de teatro escrita por Samuel Beckett. La obra sigue a dos personajes, Vladimir y Estragón, que esperan la llegada de alguien llamado Godot, pero nunca llega. Mientras esperan, pasan el tiempo conversando, discutiendo y realizando actividades triviales." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8869), "Macbeth es una tragedia escrita por William Shakespeare. La obra narra la historia de Macbeth, un noble escocés que, incitado por la profecía de tres brujas, asesina al rey Duncan y se convierte en rey de Escocia. Sin embargo, su sed de poder lo lleva a cometer más crímenes, lo que finalmente conduce a su propia destrucción." });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8873), "Otelo es una tragedia escrita por William Shakespeare. La obra cuenta la historia del moro Otelo, un general veneciano que se casa con Desdémona, una joven veneciana. Sin embargo, su matrimonio es amenazado por la manipulación de Yago, un subordinado celoso de Otelo, que alimenta los celos de Otelo y lo lleva a cometer un acto trágico de violencia. " });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "AuditoriaHorario", "DescripcionObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8877), "La Opera de los Tres Centavos es una ópera escrita por el dramaturgo alemán Bertolt Brecht, con música de Kurt Weill. Basada en la ópera del siglo XVIII El mendigo ladrón, la obra satiriza la sociedad capitalista y sigue las aventuras del criminal Mackie Messer, también conocido como Mack the Knife." });
        }
    }
}
