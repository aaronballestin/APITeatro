using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 1,
                column: "PrecioCompra",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 2,
                column: "PrecioCompra",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 3,
                column: "PrecioCompra",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 4,
                column: "PrecioCompra",
                value: 100.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 5,
                column: "PrecioCompra",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 6,
                column: "PrecioCompra",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 7,
                column: "PrecioCompra",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 8,
                column: "PrecioCompra",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 9,
                column: "PrecioCompra",
                value: 50.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 10,
                column: "PrecioCompra",
                value: 50.0);

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "CompraId", "AsientoId", "FechaCompra", "PrecioCompra", "SesionId", "UsuarioId" },
                values: new object[,]
                {
                    { 11, null, null, 50.0, 2, 1 },
                    { 12, null, null, 50.0, 2, 1 },
                    { 13, null, null, 50.0, 2, 1 },
                    { 14, null, null, 50.0, 2, 1 },
                    { 15, null, null, 50.0, 2, 1 },
                    { 16, null, null, 50.0, 2, 1 },
                    { 17, null, null, 50.0, 2, 1 },
                    { 18, null, null, 50.0, 2, 1 },
                    { 19, null, null, 50.0, 2, 1 },
                    { 20, null, null, 50.0, 2, 1 },
                    { 21, null, null, 50.0, 3, 1 },
                    { 22, null, null, 50.0, 3, 1 },
                    { 23, null, null, 50.0, 3, 1 },
                    { 24, null, null, 50.0, 3, 1 },
                    { 25, null, null, 50.0, 3, 1 },
                    { 26, null, null, 50.0, 3, 1 },
                    { 27, null, null, 50.0, 3, 1 },
                    { 28, null, null, 50.0, 3, 1 },
                    { 29, null, null, 50.0, 3, 1 },
                    { 30, null, null, 50.0, 3, 1 }
                });

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
                    { 72, 2, 12 },
                    { 82, 2, 22 }
                });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 21, 22, 42, 10, 250, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "EmailUsuario",
                value: "admin@example.com");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 30);

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
                keyValues: new object[] { 72, 2 });

            migrationBuilder.DeleteData(
                table: "DetallesCompras",
                keyColumns: new[] { "AsientoId", "SesionId" },
                keyValues: new object[] { 82, 2 });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 1,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 2,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 3,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 4,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 5,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 6,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 7,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 8,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 9,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "CompraId",
                keyValue: 10,
                column: "PrecioCompra",
                value: 0.0);

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "SesionId", "CompraId" },
                values: new object[] { 9, 1, 10 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 49, 28, 726, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "EmailUsuario",
                value: "maria@example.com");
        }
    }
}
