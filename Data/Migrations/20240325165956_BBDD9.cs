using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8785), "/src/assets/images/hamlet.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8832), "/src/assets/images/LaCasaDeBernardaAlba.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8834), "/src/assets/images/RomeoyJulieta.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8864), "/src/assets/images/ElFantasmaDeLaOpera.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8866), "/src/assets/images/EsperandoAGodot.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8869), "/src/assets/images/Macbeth.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8871), "/src/assets/images/LosMiserables.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8873), "/src/assets/images/Otelo.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8875), "/src/assets/images/LaGaviota.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 59, 55, 943, DateTimeKind.Local).AddTicks(8877), "/src/assets/images/LaOperaDeLosTresCentavos.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8239), "../../assets/images/hamlet.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8287), "../../assets/images/LaCasaDeBernardaAlba.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8289), "../../assets/images/RomeoyJulieta.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8291), "../../assets/images/ElFantasmaDeLaOpera.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8293), "../../assets/images/EsperandoAGodot.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8295), "../../assets/images/Macbeth.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8299), "../../assets/images/LosMiserables.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8301), "../../assets/images/Otelo.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8303), "../../assets/images/LaGaviota.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 25, 17, 53, 12, 861, DateTimeKind.Local).AddTicks(8304), "../../assets/images/LaOperaDeLosTresCentavos.jpg" });
        }
    }
}
