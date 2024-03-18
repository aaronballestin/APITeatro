using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Asientos_AsientoId",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compras",
                table: "Compras");

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumns: new[] { "AsientoId", "SesionId", "UsuarioId" },
                keyValues: new object[] { 1, 1, 1 });

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumns: new[] { "AsientoId", "SesionId", "UsuarioId" },
                keyValues: new object[] { 2, 1, 2 });

            migrationBuilder.AlterColumn<int>(
                name: "AsientoId",
                table: "Compras",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CompraId",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCompra",
                table: "Compras",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PrecioCompra",
                table: "Compras",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compras",
                table: "Compras",
                columns: new[] { "SesionId", "UsuarioId" });

            migrationBuilder.CreateTable(
                name: "DetallesCompras",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "int", nullable: false),
                    AsientoId = table.Column<int>(type: "int", nullable: false),
                    SesionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesCompras", x => new { x.CompraId, x.AsientoId });
                });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "SesionId", "UsuarioId", "AsientoId", "CompraId", "FechaCompra", "PrecioCompra" },
                values: new object[,]
                {
                    { 1, 1, null, 1, null, 0.0 },
                    { 1, 2, null, 2, null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "CompraId", "SesionId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 2, 2, 2 },
                    { 7, 2, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Asientos_AsientoId",
                table: "Compras",
                column: "AsientoId",
                principalTable: "Asientos",
                principalColumn: "AsientoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Asientos_AsientoId",
                table: "Compras");

            migrationBuilder.DropTable(
                name: "DetallesCompras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compras",
                table: "Compras");

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumns: new[] { "SesionId", "UsuarioId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumns: new[] { "SesionId", "UsuarioId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DropColumn(
                name: "CompraId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "FechaCompra",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "PrecioCompra",
                table: "Compras");

            migrationBuilder.AlterColumn<int>(
                name: "AsientoId",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compras",
                table: "Compras",
                columns: new[] { "SesionId", "AsientoId", "UsuarioId" });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "AsientoId", "SesionId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Asientos_AsientoId",
                table: "Compras",
                column: "AsientoId",
                principalTable: "Asientos",
                principalColumn: "AsientoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
