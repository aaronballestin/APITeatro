using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Asientos_AsientoId",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Sesiones_SesionId",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Sesiones_Salas_SalaId",
                table: "Sesiones");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Asientos_AsientoId",
                table: "Compras",
                column: "AsientoId",
                principalTable: "Asientos",
                principalColumn: "AsientoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Sesiones_SesionId",
                table: "Compras",
                column: "SesionId",
                principalTable: "Sesiones",
                principalColumn: "SesionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sesiones_Salas_SalaId",
                table: "Sesiones",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "SalaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Asientos_AsientoId",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Sesiones_SesionId",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Sesiones_Salas_SalaId",
                table: "Sesiones");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Asientos_AsientoId",
                table: "Compras",
                column: "AsientoId",
                principalTable: "Asientos",
                principalColumn: "AsientoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Sesiones_SesionId",
                table: "Compras",
                column: "SesionId",
                principalTable: "Sesiones",
                principalColumn: "SesionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sesiones_Salas_SalaId",
                table: "Sesiones",
                column: "SalaId",
                principalTable: "Salas",
                principalColumn: "SalaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
