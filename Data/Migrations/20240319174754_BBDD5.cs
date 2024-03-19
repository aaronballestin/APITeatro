using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "SesionId", "CompraId" },
                values: new object[,]
                {
                    { 9, 1, 10 },
                    { 10, 1, 6 },
                    { 11, 1, 6 },
                    { 17, 1, 4 },
                    { 25, 1, 5 },
                    { 27, 1, 4 },
                    { 35, 1, 6 },
                    { 37, 1, 9 },
                    { 45, 1, 7 },
                    { 47, 1, 8 }
                });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 47, 54, 315, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 1,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 2,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 3,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 4,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 5,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 6,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 7,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 8,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 9,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 10,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 11,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 12,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 13,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 14,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 15,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 16,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 17,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 18,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 19,
                column: "Precio",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 20,
                column: "Precio",
                value: 50.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 25, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 27, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 37, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 45, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 47, 1 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 42, 49, 760, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 1,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 2,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 3,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 4,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 5,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 6,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 7,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 8,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 9,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 10,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 11,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 12,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 13,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 14,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 15,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 16,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 17,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 18,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 19,
                column: "Precio",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 20,
                column: "Precio",
                value: 0.0);
        }
    }
}
