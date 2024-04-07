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
                name: "DetallesCompras",
                columns: table => new
                {
                    SesionId = table.Column<int>(type: "int", nullable: false),
                    AsientoId = table.Column<int>(type: "int", nullable: false),
                    CompraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesCompras", x => new { x.SesionId, x.AsientoId });
                });

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
                    CompraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SesionId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    FechaCompra = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PrecioCompra = table.Column<double>(type: "float", nullable: false),
                    AsientoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Compras_Asientos_AsientoId",
                        column: x => x.AsientoId,
                        principalTable: "Asientos",
                        principalColumn: "AsientoId");
                    table.ForeignKey(
                        name: "FK_Compras_Sesiones_SesionId",
                        column: x => x.SesionId,
                        principalTable: "Sesiones",
                        principalColumn: "SesionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DetallesCompras",
                columns: new[] { "AsientoId", "SesionId", "CompraId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 7, 1, 3 },
                    { 10, 1, 6 },
                    { 11, 1, 6 },
                    { 17, 1, 4 },
                    { 25, 1, 5 },
                    { 27, 1, 4 },
                    { 35, 1, 6 },
                    { 37, 1, 9 },
                    { 45, 1, 7 },
                    { 47, 1, 8 },
                    { 51, 2, 11 },
                    { 52, 2, 11 },
                    { 55, 2, 16 },
                    { 56, 2, 18 },
                    { 57, 2, 19 },
                    { 59, 2, 10 },
                    { 61, 2, 16 },
                    { 62, 2, 2 },
                    { 67, 2, 13 },
                    { 72, 2, 12 },
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

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "ObraId", "AuditoriaHorario", "AuditoriaUsuario", "DescripcionObra", "DuracionObra", "NombreObra", "RutaFotoObra" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7389), "Admin", "Una de las obras más famosas de William Shakespeare, Hamlet es una tragedia que narra la historia del príncipe Hamlet de Dinamarca, quien busca vengar la muerte de su padre a manos de su tío Claudio, que luego se convierte en rey.", 180, "Hamlet", "/src/assets/images/hamlet.jpg" },
                    { 2, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7449), "Admin", "La Casa de Bernarda Alba es una obra de teatro escrita por el dramaturgo español Federico García Lorca. Ambientada en un pueblo de Andalucía, la obra narra la historia de Bernarda Alba, una viuda adinerada y autoritaria que impone un luto riguroso a sus cinco hijas.", 150, "La Casa de Bernarda Alba", "/src/assets/images/LaCasaDeBernardaAlba.jpg" },
                    { 3, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7453), "Admin", "Romeo y Julieta es una de las tragedias más conocidas de William Shakespeare. La obra cuenta la historia de dos jóvenes amantes cuyas familias, los Montesco y los Capuleto, están enfrentadas.", 160, "Romeo y Julieta", "/src/assets/images/RomeoyJulieta.jpg" },
                    { 4, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7457), "Admin", "El Fantasma de la Ópera es un musical de Andrew Lloyd Webber basado en la novela homónima de Gaston Leroux. La historia se desarrolla en la Ópera de París, donde un misterioso fantasma aterroriza a la compañía y se enamora de Christine, una joven cantante.", 200, "El Fantasma de la Ópera", "/src/assets/images/ElFantasmaDeLaOpera.jpg" },
                    { 5, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7460), "Admin", "Esperando a Godot es una obra de teatro escrita por Samuel Beckett. La obra sigue a dos personajes, Vladimir y Estragón, que esperan la llegada de alguien llamado Godot, pero nunca llega.", 120, "Esperando a Godot", "/src/assets/images/EsperandoAGodot.jpg" },
                    { 6, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7464), "Admin", "Macbeth es una tragedia escrita por William Shakespeare. La obra narra la historia de Macbeth, un noble escocés que, incitado por la profecía de tres brujas, asesina al rey Duncan y se convierte en rey de Escocia. ", 170, "Macbeth", "/src/assets/images/Macbeth.jpg" },
                    { 7, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7467), "Admin", "Los Miserables es un musical basado en la novela homónima de Victor Hugo. La historia sigue las vidas entrelazadas de varios personajes, incluido Jean Valjean, un exconvicto que busca redención; Javert, un inspector de policía obsesionado con atraparlo; y Cosette, la hija adoptiva de Valjean.", 210, "Los Miserables", "/src/assets/images/LosMiserables.jpg" },
                    { 8, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7470), "Admin", "Otelo es una tragedia escrita por William Shakespeare. La obra cuenta la historia del moro Otelo, un general veneciano que se casa con Desdémona, una joven veneciana. ", 190, "Otelo", "/src/assets/images/Otelo.jpg" },
                    { 9, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7473), "Admin", "La Gaviota es una obra de teatro escrita por el dramaturgo ruso Anton Chejov. Ambientada en una finca rural en Rusia, la obra sigue las vidas entrelazadas de varios personajes, incluida la famosa actriz Irina Arkádina, su amante Boris Trigorin y el aspirante a escritor Konstantín Tréplev.", 180, "La Gaviota", "/src/assets/images/LaGaviota.jpg" },
                    { 10, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7476), "Admin", "La Opera de los Tres Centavos es una ópera escrita por el dramaturgo alemán Bertolt Brecht, con música de Kurt Weill.", 200, "La Opera de los Tres Centavos", "/src/assets/images/LaOperaDeLosTresCentavos.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "SalaId", "AsientosMinusvalidos", "AsientosNormales", "AsientosVip" },
                values: new object[,]
                {
                    { 1, 0, 50, 0 },
                    { 2, 0, 0, 30 },
                    { 3, 10, 20, 10 }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "EmailUsuario", "NombreUsuario", "PasswordUsuario", "Rol" },
                values: new object[,]
                {
                    { 1, "default@example.com", "Default", "1234", "Guest" },
                    { 2, "admin@example.com", "María", "1234", "Admin" },
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
                    { 1, 1, -10.0, 1 },
                    { 2, 1, -10.0, 1 },
                    { 3, 1, -10.0, 1 },
                    { 4, 1, -10.0, 1 },
                    { 5, 1, -10.0, 1 },
                    { 6, 1, -10.0, 1 },
                    { 7, 1, -10.0, 1 },
                    { 8, 1, -10.0, 1 },
                    { 9, 1, -10.0, 1 },
                    { 10, 1, -10.0, 1 },
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
                    { 51, 2, 40.0, 2 },
                    { 52, 2, 40.0, 2 },
                    { 53, 2, 40.0, 2 },
                    { 54, 2, 40.0, 2 },
                    { 55, 2, 40.0, 2 },
                    { 56, 2, 40.0, 2 },
                    { 57, 2, 40.0, 2 },
                    { 58, 2, 40.0, 2 },
                    { 59, 2, 40.0, 2 },
                    { 60, 2, 40.0, 2 },
                    { 61, 2, 40.0, 2 },
                    { 62, 2, 40.0, 2 },
                    { 63, 2, 40.0, 2 },
                    { 64, 2, 40.0, 2 },
                    { 65, 2, 40.0, 2 },
                    { 66, 2, 40.0, 2 },
                    { 67, 2, 40.0, 2 },
                    { 68, 2, 40.0, 2 },
                    { 69, 2, 40.0, 2 },
                    { 70, 2, 40.0, 2 },
                    { 71, 2, 40.0, 2 },
                    { 72, 2, 40.0, 2 },
                    { 73, 2, 40.0, 2 },
                    { 74, 2, 40.0, 2 },
                    { 75, 2, 40.0, 2 },
                    { 76, 2, 40.0, 2 },
                    { 77, 2, 40.0, 2 },
                    { 78, 2, 40.0, 2 },
                    { 79, 2, 40.0, 2 },
                    { 80, 2, 40.0, 2 },
                    { 81, 3, -30.0, 3 },
                    { 82, 3, -30.0, 3 },
                    { 83, 3, -30.0, 3 },
                    { 84, 3, -30.0, 3 },
                    { 85, 3, -30.0, 3 },
                    { 86, 3, -30.0, 3 },
                    { 87, 3, -30.0, 3 },
                    { 88, 3, -30.0, 3 },
                    { 89, 3, -30.0, 3 },
                    { 90, 3, -30.0, 3 },
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
                    { 111, 3, 40.0, 2 },
                    { 112, 3, 40.0, 2 },
                    { 113, 3, 40.0, 2 },
                    { 114, 3, 40.0, 2 },
                    { 115, 3, 40.0, 2 },
                    { 116, 3, 40.0, 2 },
                    { 117, 3, 40.0, 2 },
                    { 118, 3, 40.0, 2 },
                    { 119, 3, 40.0, 2 },
                    { 120, 3, 40.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Sesiones",
                columns: new[] { "SesionId", "AuditoriaHorario", "AuditoriaUsuario", "FechaHora", "ObraId", "Precio", "SalaId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2024, 4, 7, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 50.0, 1 },
                    { 2, null, null, new DateTime(2024, 4, 8, 19, 0, 0, 0, DateTimeKind.Unspecified), 2, 50.0, 2 },
                    { 3, null, null, new DateTime(2024, 4, 8, 20, 0, 0, 0, DateTimeKind.Unspecified), 1, 50.0, 3 },
                    { 4, null, null, new DateTime(2024, 4, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), 1, 50.0, 1 },
                    { 5, null, null, new DateTime(2024, 4, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, 50.0, 2 },
                    { 6, null, null, new DateTime(2024, 4, 11, 19, 30, 0, 0, DateTimeKind.Unspecified), 3, 50.0, 3 },
                    { 7, null, null, new DateTime(2024, 4, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 4, 50.0, 1 },
                    { 8, null, null, new DateTime(2024, 4, 13, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 50.0, 2 },
                    { 9, null, null, new DateTime(2024, 4, 14, 18, 30, 0, 0, DateTimeKind.Unspecified), 5, 50.0, 3 },
                    { 10, null, null, new DateTime(2024, 4, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), 5, 50.0, 1 },
                    { 11, null, null, new DateTime(2024, 4, 16, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, 50.0, 2 },
                    { 12, null, null, new DateTime(2024, 4, 17, 17, 30, 0, 0, DateTimeKind.Unspecified), 6, 50.0, 3 },
                    { 13, null, null, new DateTime(2024, 4, 18, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, 50.0, 1 },
                    { 14, null, null, new DateTime(2024, 4, 19, 19, 30, 0, 0, DateTimeKind.Unspecified), 7, 50.0, 2 },
                    { 15, null, null, new DateTime(2024, 4, 20, 20, 0, 0, 0, DateTimeKind.Unspecified), 8, 50.0, 3 },
                    { 16, null, null, new DateTime(2024, 4, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 8, 50.0, 1 },
                    { 17, null, null, new DateTime(2024, 4, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), 9, 50.0, 2 },
                    { 18, null, null, new DateTime(2024, 4, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), 9, 50.0, 3 },
                    { 19, null, null, new DateTime(2024, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 10, 50.0, 1 },
                    { 20, null, null, new DateTime(2024, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, 50.0, 2 }
                });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "CompraId", "AsientoId", "FechaCompra", "PrecioCompra", "SesionId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7710), 100.0, 1, 1 },
                    { 2, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7714), 50.0, 1, 3 },
                    { 3, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7717), 50.0, 1, 4 },
                    { 4, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7720), 100.0, 1, 5 },
                    { 5, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7722), 50.0, 1, 1 },
                    { 6, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7725), 50.0, 1, 3 },
                    { 7, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7727), 50.0, 1, 4 },
                    { 8, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7729), 50.0, 1, 5 },
                    { 9, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7732), 50.0, 1, 1 },
                    { 10, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7736), 50.0, 1, 3 },
                    { 11, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7738), 50.0, 2, 4 },
                    { 12, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7740), 50.0, 2, 5 },
                    { 13, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7742), 50.0, 2, 1 },
                    { 14, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7744), 50.0, 2, 3 },
                    { 15, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7745), 50.0, 2, 4 },
                    { 16, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7747), 50.0, 2, 5 },
                    { 17, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7749), 50.0, 2, 1 },
                    { 18, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7751), 50.0, 2, 1 },
                    { 19, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7753), 50.0, 2, 5 },
                    { 20, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7755), 50.0, 2, 4 },
                    { 21, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7756), 50.0, 3, 3 },
                    { 22, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7758), 50.0, 3, 2 },
                    { 23, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7760), 50.0, 3, 3 },
                    { 24, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7762), 50.0, 3, 4 },
                    { 25, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7763), 50.0, 3, 5 },
                    { 26, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7766), 50.0, 3, 6 },
                    { 27, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7768), 50.0, 3, 7 },
                    { 28, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7770), 50.0, 3, 8 },
                    { 29, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7771), 50.0, 3, 9 },
                    { 30, null, new DateTime(2024, 4, 4, 23, 28, 51, 410, DateTimeKind.Local).AddTicks(7773), 50.0, 3, 12 }
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
                name: "IX_Compras_SesionId",
                table: "Compras",
                column: "SesionId");

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
                name: "DetallesCompras");

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
