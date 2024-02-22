using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mulaton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asientos",
                columns: table => new
                {
                    AsientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fila = table.Column<int>(type: "int", nullable: false),
                    Columna = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asientos", x => x.AsientoId);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Obras",
                columns: table => new
                {
                    ObraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    NombreObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RutaFotoObra = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obras", x => x.ObraId);
                    table.ForeignKey(
                        name: "FK_Obras_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sesiones",
                columns: table => new
                {
                    SesionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObraId = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesiones", x => x.SesionId);
                    table.ForeignKey(
                        name: "FK_Sesiones_Obras_ObraId",
                        column: x => x.ObraId,
                        principalTable: "Obras",
                        principalColumn: "ObraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    AsientoId = table.Column<int>(type: "int", nullable: false),
                    SesionId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    EntradaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => new { x.SesionId, x.AsientoId, x.UsuarioId });
                    table.ForeignKey(
                        name: "FK_Compras_Asientos_AsientoId",
                        column: x => x.AsientoId,
                        principalTable: "Asientos",
                        principalColumn: "AsientoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Sesiones_SesionId",
                        column: x => x.SesionId,
                        principalTable: "Sesiones",
                        principalColumn: "SesionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SesionAsientos",
                columns: table => new
                {
                    SesionId = table.Column<int>(type: "int", nullable: false),
                    AsientoId = table.Column<int>(type: "int", nullable: false),
                    Ocupado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SesionAsientos", x => new { x.SesionId, x.AsientoId });
                    table.ForeignKey(
                        name: "FK_SesionAsientos_Asientos_AsientoId",
                        column: x => x.AsientoId,
                        principalTable: "Asientos",
                        principalColumn: "AsientoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SesionAsientos_Sesiones_SesionId",
                        column: x => x.SesionId,
                        principalTable: "Sesiones",
                        principalColumn: "SesionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Asientos",
                columns: new[] { "AsientoId", "Columna", "Fila" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 1, 2 },
                    { 4, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "NombreCategoria" },
                values: new object[,]
                {
                    { 1, "Drama" },
                    { 2, "Comedia" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "EmailUsuario", "NombreUsuario", "PasswordUsuario", "Rol" },
                values: new object[,]
                {
                    { 1, "juan@example.com", "Juan", "1234", "Guest" },
                    { 2, "maria@example.com", "María", "1234", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "ObraId", "CategoriaId", "DescripcionObra", "NombreObra", "RutaFotoObra" },
                values: new object[,]
                {
                    { 1, 1, "Una tragedia clásica", "Hamlet", "ruta/foto/hamlet.jpg" },
                    { 2, 2, "Un drama familiar", "La Casa de Bernarda Alba", "ruta/foto/bernarda_alba.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Sesiones",
                columns: new[] { "SesionId", "FechaHora", "ObraId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 29, 20, 38, 45, 949, DateTimeKind.Local).AddTicks(4096), 1 },
                    { 2, new DateTime(2024, 3, 7, 20, 38, 45, 949, DateTimeKind.Local).AddTicks(4150), 2 }
                });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "AsientoId", "SesionId", "UsuarioId", "EntradaId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "SesionAsientos",
                columns: new[] { "AsientoId", "SesionId", "Ocupado" },
                values: new object[,]
                {
                    { 1, 1, true },
                    { 2, 1, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_AsientoId",
                table: "Compras",
                column: "AsientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_UsuarioId",
                table: "Compras",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Obras_CategoriaId",
                table: "Obras",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_SesionAsientos_AsientoId",
                table: "SesionAsientos",
                column: "AsientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesiones_ObraId",
                table: "Sesiones",
                column: "ObraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "SesionAsientos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Asientos");

            migrationBuilder.DropTable(
                name: "Sesiones");

            migrationBuilder.DropTable(
                name: "Obras");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
