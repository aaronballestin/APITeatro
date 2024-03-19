using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 1,
                column: "Suplemento",
                value: -10.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 2,
                column: "Suplemento",
                value: -10.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 3,
                column: "Suplemento",
                value: -10.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 4,
                column: "Suplemento",
                value: -10.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 5,
                column: "Suplemento",
                value: -10.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 6,
                column: "Suplemento",
                value: -10.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 7,
                column: "Suplemento",
                value: -10.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 8,
                column: "Suplemento",
                value: -10.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 9,
                column: "Suplemento",
                value: -10.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 10,
                column: "Suplemento",
                value: -10.0);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 1,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 2,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 3,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 4,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 5,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 6,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 7,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 8,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 9,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 10,
                column: "Suplemento",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 1,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 2,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10,
                column: "AuditoriaHorario",
                value: new DateTime(2024, 3, 19, 18, 39, 45, 46, DateTimeKind.Local).AddTicks(5783));
        }
    }
}
