using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class BBDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Obras",
                columns: table => new
                {
                    ObraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescripcionObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RutaFotoObra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DuracionObra = table.Column<int>(type: "int", nullable: false),
                    AuditoriaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditoriaHorario = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obras", x => x.ObraId);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsientosNormales = table.Column<int>(type: "int", nullable: false),
                    AsientosVip = table.Column<int>(type: "int", nullable: false),
                    AsientosMinusvalidos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.SalaId);
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
                name: "Asientos",
                columns: table => new
                {
                    AsientoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalaId = table.Column<int>(type: "int", nullable: false),
                    TipoAsiento = table.Column<int>(type: "int", nullable: false),
                    Suplemento = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asientos", x => x.AsientoId);
                    table.ForeignKey(
                        name: "FK_Asientos_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "SalaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sesiones",
                columns: table => new
                {
                    SesionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObraId = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    AuditoriaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditoriaHorario = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SalaId = table.Column<int>(type: "int", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Sesiones_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "SalaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    SesionId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    AsientoId = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "SesionId");
                    table.ForeignKey(
                        name: "FK_Compras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "ObraId", "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra", "NombreObra", "RutaFotoObra" },
                values: new object[,]
                {
                    { 1, null, null, "Una tragedia clásica", 0, "Hamlet", "ruta/foto/hamlet.jpg" },
                    { 2, null, null, "Un drama familiar", 0, "La Casa de Bernarda Alba", "ruta/foto/bernarda_alba.jpg" },
                    { 3, null, null, "Amor prohibido entre dos familias rivales", 0, "Romeo y Julieta", "ruta/foto/romeo_julieta.jpg" },
                    { 4, null, null, "Una historia de amor y tragedia en la Ópera de París", 0, "El Fantasma de la Ópera", "ruta/foto/fantasma_opera.jpg" },
                    { 5, null, null, "Dos personajes esperan a alguien que nunca llega", 0, "Esperando a Godot", "ruta/foto/esperando_godot.jpg" },
                    { 6, null, null, "Una tragedia sobre ambición y traición", 0, "Macbeth", "ruta/foto/macbeth.jpg" },
                    { 7, null, null, "La historia de Jean Valjean y su redención", 0, "Los Miserables", "ruta/foto/los_miserables.jpg" },
                    { 8, null, null, "Celos y traición en la Venecia del siglo XVI", 0, "Otelo", "ruta/foto/otelo.jpg" },
                    { 9, null, null, "Drama de amor y desilusión en la sociedad rusa del siglo XIX", 0, "La Gaviota", "ruta/foto/la_gaviota.jpg" },
                    { 10, null, null, "Una ópera sobre el crimen y la pobreza en Londres", 0, "La Opera de los Tres Centavos", "ruta/foto/Fopera_tres_centavos.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "SalaId", "AsientosMinusvalidos", "AsientosNormales", "AsientosVip" },
                values: new object[,]
                {
                    { 1, 10, 50, 10 },
                    { 2, 0, 100, 0 },
                    { 3, 0, 0, 30 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "EmailUsuario", "NombreUsuario", "PasswordUsuario", "Rol" },
                values: new object[,]
                {
                    { 1, "juan@example.com", "Juan", "1234", "Guest" },
                    { 2, "maria@example.com", "María", "1234", "Admin" },
                    { 3, "carlos@example.com", "Carlos", "1234", "Guest" },
                    { 4, "laura@example.com", "Laura", "1234", "Guest" },
                    { 5, "pedro@example.com", "Pedro", "1234", "Guest" },
                    { 6, "ana@example.com", "Ana", "1234", "Guest" },
                    { 7, "sofia@example.com", "Sofía", "1234", "Guest" },
                    { 8, "david@example.com", "David", "1234", "Guest" },
                    { 9, "lucia@example.com", "Lucía", "1234", "Guest" },
                    { 10, "diego@example.com", "Diego", "1234", "Guest" },
                    { 11, "paula@example.com", "Paula", "1234", "Guest" },
                    { 12, "manuel@example.com", "Manuel", "1234", "Guest" }
                });

            migrationBuilder.InsertData(
                table: "Asientos",
                columns: new[] { "AsientoId", "SalaId", "Suplemento", "TipoAsiento" },
                values: new object[,]
                {
                    { 1, 1, 0.0, 1 },
                    { 2, 1, 0.0, 1 },
                    { 3, 1, 0.0, 1 },
                    { 4, 1, 0.0, 1 },
                    { 5, 1, 0.0, 1 },
                    { 6, 1, 0.0, 1 },
                    { 7, 1, 0.0, 1 },
                    { 8, 1, 0.0, 1 },
                    { 9, 1, 0.0, 1 },
                    { 10, 1, 0.0, 1 },
                    { 11, 1, 0.0, 1 },
                    { 12, 1, 0.0, 1 },
                    { 13, 1, 0.0, 1 },
                    { 14, 1, 0.0, 1 },
                    { 15, 1, 0.0, 1 },
                    { 16, 1, 0.0, 1 },
                    { 17, 1, 0.0, 1 },
                    { 18, 1, 0.0, 1 },
                    { 19, 1, 0.0, 1 },
                    { 20, 1, 0.0, 1 },
                    { 21, 1, 0.0, 1 },
                    { 22, 1, 0.0, 1 },
                    { 23, 1, 0.0, 1 },
                    { 24, 1, 0.0, 1 },
                    { 25, 1, 0.0, 1 },
                    { 26, 1, 0.0, 1 },
                    { 27, 1, 0.0, 1 },
                    { 28, 1, 0.0, 1 },
                    { 29, 1, 0.0, 1 },
                    { 30, 1, 0.0, 1 },
                    { 31, 1, 0.0, 1 },
                    { 32, 1, 0.0, 1 },
                    { 33, 1, 0.0, 1 },
                    { 34, 1, 0.0, 1 },
                    { 35, 1, 0.0, 1 },
                    { 36, 1, 0.0, 1 },
                    { 37, 1, 0.0, 1 },
                    { 38, 1, 0.0, 1 },
                    { 39, 1, 0.0, 1 },
                    { 40, 1, 0.0, 1 },
                    { 41, 1, 0.0, 1 },
                    { 42, 1, 0.0, 1 },
                    { 43, 1, 0.0, 1 },
                    { 44, 1, 0.0, 1 },
                    { 45, 1, 0.0, 1 },
                    { 46, 1, 0.0, 1 },
                    { 47, 1, 0.0, 1 },
                    { 48, 1, 0.0, 1 },
                    { 49, 1, 0.0, 1 },
                    { 50, 1, 0.0, 1 },
                    { 51, 2, 0.0, 1 },
                    { 52, 2, 0.0, 1 },
                    { 53, 2, 0.0, 1 },
                    { 54, 2, 0.0, 1 },
                    { 55, 2, 0.0, 1 },
                    { 56, 2, 0.0, 1 },
                    { 57, 2, 0.0, 1 },
                    { 58, 2, 0.0, 1 },
                    { 59, 2, 0.0, 1 },
                    { 60, 2, 0.0, 1 },
                    { 61, 2, 0.0, 1 },
                    { 62, 2, 0.0, 1 },
                    { 63, 2, 0.0, 1 },
                    { 64, 2, 0.0, 1 },
                    { 65, 2, 0.0, 1 },
                    { 66, 2, 0.0, 1 },
                    { 67, 2, 0.0, 1 },
                    { 68, 2, 0.0, 1 },
                    { 69, 2, 0.0, 1 },
                    { 70, 2, 0.0, 1 },
                    { 71, 2, 0.0, 1 },
                    { 72, 2, 0.0, 1 },
                    { 73, 2, 0.0, 1 },
                    { 74, 2, 0.0, 1 },
                    { 75, 2, 0.0, 1 },
                    { 76, 2, 0.0, 1 },
                    { 77, 2, 0.0, 1 },
                    { 78, 2, 0.0, 1 },
                    { 79, 2, 0.0, 1 },
                    { 80, 2, 0.0, 1 },
                    { 81, 3, 0.0, 1 },
                    { 82, 3, 0.0, 1 },
                    { 83, 3, 0.0, 1 },
                    { 84, 3, 0.0, 1 },
                    { 85, 3, 0.0, 1 },
                    { 86, 3, 0.0, 1 },
                    { 87, 3, 0.0, 1 },
                    { 88, 3, 0.0, 1 },
                    { 89, 3, 0.0, 1 },
                    { 90, 3, 0.0, 1 },
                    { 91, 3, 0.0, 1 },
                    { 92, 3, 0.0, 1 },
                    { 93, 3, 0.0, 1 },
                    { 94, 3, 0.0, 1 },
                    { 95, 3, 0.0, 1 },
                    { 96, 3, 0.0, 1 },
                    { 97, 3, 0.0, 1 },
                    { 98, 3, 0.0, 1 },
                    { 99, 3, 0.0, 1 },
                    { 100, 3, 0.0, 1 },
                    { 101, 3, 0.0, 1 },
                    { 102, 3, 0.0, 1 },
                    { 103, 3, 0.0, 1 },
                    { 104, 3, 0.0, 1 },
                    { 105, 3, 0.0, 1 },
                    { 106, 3, 0.0, 1 },
                    { 107, 3, 0.0, 1 },
                    { 108, 3, 0.0, 1 },
                    { 109, 3, 0.0, 1 },
                    { 110, 3, 0.0, 1 },
                    { 111, 3, 0.0, 1 },
                    { 112, 3, 0.0, 1 },
                    { 113, 3, 0.0, 1 },
                    { 114, 3, 0.0, 1 },
                    { 115, 3, 0.0, 1 },
                    { 116, 3, 0.0, 1 },
                    { 117, 3, 0.0, 1 },
                    { 118, 3, 0.0, 1 },
                    { 119, 3, 0.0, 1 },
                    { 120, 3, 0.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Sesiones",
                columns: new[] { "SesionId", "AuditoriaHorario", "AuditoriaUsuario", "FechaHora", "ObraId", "Precio", "SalaId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2024, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 0.0, 1 },
                    { 2, null, null, new DateTime(2024, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), 2, 0.0, 2 },
                    { 3, null, null, new DateTime(2024, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, 0.0, 3 },
                    { 4, null, null, new DateTime(2024, 4, 4, 17, 30, 0, 0, DateTimeKind.Unspecified), 1, 0.0, 1 },
                    { 5, null, null, new DateTime(2024, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, 0.0, 2 },
                    { 6, null, null, new DateTime(2024, 4, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 3, 0.0, 3 },
                    { 7, null, null, new DateTime(2024, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), 4, 0.0, 1 },
                    { 8, null, null, new DateTime(2024, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 0.0, 2 },
                    { 9, null, null, new DateTime(2024, 4, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 5, 0.0, 3 },
                    { 10, null, null, new DateTime(2024, 4, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 5, 0.0, 1 },
                    { 11, null, null, new DateTime(2024, 4, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, 0.0, 2 },
                    { 12, null, null, new DateTime(2024, 4, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), 6, 0.0, 3 },
                    { 13, null, null, new DateTime(2024, 4, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, 0.0, 1 },
                    { 14, null, null, new DateTime(2024, 4, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), 7, 0.0, 2 },
                    { 15, null, null, new DateTime(2024, 4, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 8, 0.0, 3 },
                    { 16, null, null, new DateTime(2024, 4, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 8, 0.0, 1 },
                    { 17, null, null, new DateTime(2024, 4, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), 9, 0.0, 2 },
                    { 18, null, null, new DateTime(2024, 4, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), 9, 0.0, 3 },
                    { 19, null, null, new DateTime(2024, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 10, 0.0, 1 },
                    { 20, null, null, new DateTime(2024, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, 0.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "AsientoId", "SesionId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asientos_SalaId",
                table: "Asientos",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_AsientoId",
                table: "Compras",
                column: "AsientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_UsuarioId",
                table: "Compras",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesiones_ObraId",
                table: "Sesiones",
                column: "ObraId");

            migrationBuilder.CreateIndex(
                name: "IX_Sesiones_SalaId",
                table: "Sesiones",
                column: "SalaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Asientos");

            migrationBuilder.DropTable(
                name: "Sesiones");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Obras");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
