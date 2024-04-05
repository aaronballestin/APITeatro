using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 1,
                columns: new[] { "AsientosMinusvalidos", "AsientosVip" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3,
                columns: new[] { "AsientosMinusvalidos", "AsientosNormales", "AsientosVip" },
                values: new object[] { 10, 30, 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 1,
                columns: new[] { "AsientosMinusvalidos", "AsientosVip" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3,
                columns: new[] { "AsientosMinusvalidos", "AsientosNormales", "AsientosVip" },
                values: new object[] { 0, 0, 30 });
        }
    }
}
