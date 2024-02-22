using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2024, 2, 29, 20, 19, 21, 828, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2024, 3, 7, 20, 19, 21, 828, DateTimeKind.Local).AddTicks(74));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2024, 2, 29, 17, 41, 15, 739, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2024, 3, 7, 17, 41, 15, 739, DateTimeKind.Local).AddTicks(1751));
        }
    }
}
