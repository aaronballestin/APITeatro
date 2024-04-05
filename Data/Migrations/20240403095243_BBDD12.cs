using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 51, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 55, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 56, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 59, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 61, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 67, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 73, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 75, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 77, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 79, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 80, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 81, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 83, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 85, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 86, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 97, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 98, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 100, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 101, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 102, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 107, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 115, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 119, 1 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "SesionId", "CompraId" },
                values: new object[,]
                {
                    { 51, 2, 11 },
                    { 52, 2, 11 },
                    { 55, 2, 16 },
                    { 56, 2, 18 },
                    { 57, 2, 19 },
                    { 59, 2, 10 },
                    { 61, 2, 16 },
                    { 67, 2, 13 },
                    { 73, 2, 17 },
                    { 75, 2, 15 },
                    { 77, 2, 14 },
                    { 79, 2, 20 },
                    { 80, 2, 16 },
                    { 81, 3, 26 },
                    { 82, 3, 22 },
                    { 83, 3, 27 },
                    { 85, 3, 26 },
                    { 86, 3, 28 },
                    { 97, 3, 23 },
                    { 98, 3, 29 },
                    { 100, 3, 26 },
                    { 101, 3, 21 },
                    { 102, 3, 21 },
                    { 107, 3, 24 },
                    { 115, 3, 25 },
                    { 119, 3, 30 }
                });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 4, 3, 11, 52, 43, 235, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3,
                column: "AsientosNormales",
                value: 20);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 51, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 52, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 55, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 57, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 59, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 61, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 67, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 73, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 75, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 77, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 79, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 80, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 81, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 82, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 83, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 85, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 86, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 97, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 98, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 100, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 101, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 102, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 107, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 115, 3 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 119, 3 });

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "SesionId", "CompraId" },
                values: new object[,]
                {
                    { 51, 1, 11 },
                    { 52, 1, 11 },
                    { 55, 1, 16 },
                    { 56, 1, 18 },
                    { 57, 1, 19 },
                    { 59, 1, 10 },
                    { 61, 1, 16 },
                    { 67, 1, 13 },
                    { 73, 1, 17 },
                    { 75, 1, 15 },
                    { 77, 1, 14 },
                    { 79, 1, 20 },
                    { 80, 1, 16 },
                    { 81, 1, 26 },
                    { 83, 1, 27 },
                    { 85, 1, 26 },
                    { 86, 1, 28 },
                    { 97, 1, 23 },
                    { 98, 1, 29 },
                    { 100, 1, 26 },
                    { 101, 1, 21 },
                    { 102, 1, 21 },
                    { 107, 1, 24 },
                    { 115, 1, 25 },
                    { 119, 1, 30 },
                    { 82, 2, 22 }
                });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9573));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 9, 30, 990, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3,
                column: "AsientosNormales",
                value: 30);
        }
    }
}
