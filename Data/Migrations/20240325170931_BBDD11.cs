using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 51,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 20.0, 2 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 51,
                columns: new[] { "Suplemento", "TipoAsiento" },
                values: new object[] { 0.0, 1 });

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 104, DateTimeKind.Local).AddTicks(9975));

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
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(33));

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
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(40));

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
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(44));

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
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 25, 18, 8, 5, 105, DateTimeKind.Local).AddTicks(48));
        }
    }
}
