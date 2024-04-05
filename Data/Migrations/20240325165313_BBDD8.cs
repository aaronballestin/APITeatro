using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(7931), "ruta/foto/hamlet.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8006), "ruta/foto/bernarda_alba.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8084), "ruta/foto/romeo_julieta.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8088), "ruta/foto/fantasma_opera.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8091), "ruta/foto/esperando_godot.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8093), "ruta/foto/macbeth.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8096), "ruta/foto/los_miserables.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8099), "ruta/foto/otelo.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8102), "ruta/foto/la_gaviota.jpg" });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                columns: new[] { "AuditoriaHorario", "RutaFotoObra" },
                values: new object[] { new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8104), "ruta/foto/Fopera_tres_centavos.jpg" });
        }
    }
}
