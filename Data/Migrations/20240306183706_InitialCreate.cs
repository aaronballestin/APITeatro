using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TeatroApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Asientos",
                columns: new[] { "AsientoId", "SalaId", "TipoAsiento" },
                values: new object[,]
                {
                    { 5, 1, 1 },
                    { 6, 1, 1 },
                    { 7, 1, 1 },
                    { 8, 1, 1 },
                    { 9, 1, 1 },
                    { 10, 1, 1 },
                    { 11, 1, 1 },
                    { 12, 1, 1 },
                    { 13, 1, 1 },
                    { 14, 1, 1 },
                    { 15, 1, 1 },
                    { 16, 1, 1 },
                    { 17, 1, 1 },
                    { 18, 1, 1 },
                    { 19, 1, 1 },
                    { 20, 1, 1 },
                    { 21, 1, 1 },
                    { 22, 1, 1 },
                    { 23, 1, 1 },
                    { 24, 1, 1 },
                    { 25, 1, 1 },
                    { 26, 1, 1 },
                    { 27, 1, 1 },
                    { 28, 1, 1 },
                    { 29, 1, 1 },
                    { 30, 1, 1 },
                    { 31, 1, 1 },
                    { 32, 1, 1 },
                    { 33, 1, 1 },
                    { 34, 1, 1 },
                    { 35, 1, 1 },
                    { 36, 1, 1 },
                    { 37, 1, 1 },
                    { 38, 1, 1 },
                    { 39, 1, 1 },
                    { 40, 1, 1 },
                    { 41, 1, 1 },
                    { 42, 1, 1 },
                    { 43, 1, 1 },
                    { 44, 1, 1 },
                    { 45, 1, 1 },
                    { 46, 1, 1 },
                    { 47, 1, 1 },
                    { 48, 1, 1 },
                    { 49, 1, 1 },
                    { 50, 1, 1 },
                    { 51, 2, 1 },
                    { 52, 2, 1 },
                    { 53, 2, 1 },
                    { 54, 2, 1 },
                    { 55, 2, 1 },
                    { 56, 2, 1 },
                    { 57, 2, 1 },
                    { 58, 2, 1 },
                    { 59, 2, 1 },
                    { 60, 2, 1 },
                    { 61, 2, 1 },
                    { 62, 2, 1 },
                    { 63, 2, 1 },
                    { 64, 2, 1 },
                    { 65, 2, 1 },
                    { 66, 2, 1 },
                    { 67, 2, 1 },
                    { 68, 2, 1 },
                    { 69, 2, 1 },
                    { 70, 2, 1 },
                    { 71, 2, 1 },
                    { 72, 2, 1 },
                    { 73, 2, 1 },
                    { 74, 2, 1 },
                    { 75, 2, 1 },
                    { 76, 2, 1 },
                    { 77, 2, 1 },
                    { 78, 2, 1 },
                    { 79, 2, 1 },
                    { 80, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "NombreCategoria" },
                values: new object[] { 3, "Romantica" });

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "ObraId", "CategoriaId", "DescripcionObra", "NombreObra", "RutaFotoObra" },
                values: new object[,]
                {
                    { 3, 1, "Amor prohibido entre dos familias rivales", "Romeo y Julieta", "ruta/foto/romeo_julieta.jpg" },
                    { 5, 2, "Dos personajes esperan a alguien que nunca llega", "Esperando a Godot", "ruta/foto/esperando_godot.jpg" },
                    { 6, 1, "Una tragedia sobre ambición y traición", "Macbeth", "ruta/foto/macbeth.jpg" },
                    { 8, 1, "Celos y traición en la Venecia del siglo XVI", "Otelo", "ruta/foto/otelo.jpg" },
                    { 9, 2, "Drama de amor y desilusión en la sociedad rusa del siglo XIX", "La Gaviota", "ruta/foto/la_gaviota.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                column: "SalaId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2024, 4, 1, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 2,
                columns: new[] { "FechaHora", "SalaId" },
                values: new object[] { new DateTime(2024, 4, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 3,
                columns: new[] { "FechaHora", "SalaId" },
                values: new object[] { new DateTime(2024, 4, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 4,
                column: "FechaHora",
                value: new DateTime(2024, 4, 4, 17, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "EmailUsuario", "NombreUsuario", "PasswordUsuario", "Rol" },
                values: new object[,]
                {
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
                columns: new[] { "AsientoId", "SalaId", "TipoAsiento" },
                values: new object[,]
                {
                    { 81, 3, 1 },
                    { 82, 3, 1 },
                    { 83, 3, 1 },
                    { 84, 3, 1 },
                    { 85, 3, 1 },
                    { 86, 3, 1 },
                    { 87, 3, 1 },
                    { 88, 3, 1 },
                    { 89, 3, 1 },
                    { 90, 3, 1 },
                    { 91, 3, 1 },
                    { 92, 3, 1 },
                    { 93, 3, 1 },
                    { 94, 3, 1 },
                    { 95, 3, 1 },
                    { 96, 3, 1 },
                    { 97, 3, 1 },
                    { 98, 3, 1 },
                    { 99, 3, 1 },
                    { 100, 3, 1 },
                    { 101, 3, 1 },
                    { 102, 3, 1 },
                    { 103, 3, 1 },
                    { 104, 3, 1 },
                    { 105, 3, 1 },
                    { 106, 3, 1 },
                    { 107, 3, 1 },
                    { 108, 3, 1 },
                    { 109, 3, 1 },
                    { 110, 3, 1 },
                    { 111, 3, 1 },
                    { 112, 3, 1 },
                    { 113, 3, 1 },
                    { 114, 3, 1 },
                    { 115, 3, 1 },
                    { 116, 3, 1 },
                    { 117, 3, 1 },
                    { 118, 3, 1 },
                    { 119, 3, 1 },
                    { 120, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "ObraId", "CategoriaId", "DescripcionObra", "NombreObra", "RutaFotoObra" },
                values: new object[,]
                {
                    { 4, 3, "Una historia de amor y tragedia en la Ópera de París", "El Fantasma de la Ópera", "ruta/foto/fantasma_opera.jpg" },
                    { 7, 3, "La historia de Jean Valjean y su redención", "Los Miserables", "ruta/foto/los_miserables.jpg" },
                    { 10, 3, "Una ópera sobre el crimen y la pobreza en Londres", "La Opera de los Tres Centavos", "ruta/foto/Fopera_tres_centavos.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Sesiones",
                columns: new[] { "SesionId", "FechaHora", "ObraId", "SalaId" },
                values: new object[,]
                {
                    { 5, new DateTime(2024, 4, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 6, new DateTime(2024, 4, 6, 19, 30, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 9, new DateTime(2024, 4, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 5, 3 },
                    { 10, new DateTime(2024, 4, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 11, new DateTime(2024, 4, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 12, new DateTime(2024, 4, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), 6, 3 },
                    { 15, new DateTime(2024, 4, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 16, new DateTime(2024, 4, 16, 17, 0, 0, 0, DateTimeKind.Unspecified), 8, 1 },
                    { 17, new DateTime(2024, 4, 17, 18, 30, 0, 0, DateTimeKind.Unspecified), 9, 2 },
                    { 18, new DateTime(2024, 4, 18, 19, 0, 0, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 7, new DateTime(2024, 4, 7, 20, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 8, new DateTime(2024, 4, 8, 17, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 13, new DateTime(2024, 4, 13, 18, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 14, new DateTime(2024, 4, 14, 19, 30, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 19, new DateTime(2024, 4, 19, 20, 0, 0, 0, DateTimeKind.Unspecified), 10, 1 },
                    { 20, new DateTime(2024, 4, 20, 17, 0, 0, 0, DateTimeKind.Unspecified), 10, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Asientos",
                keyColumn: "AsientoId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Obras",
                keyColumn: "ObraId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Salas",
                keyColumn: "SalaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2024, 3, 7, 19, 59, 15, 748, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 2,
                columns: new[] { "FechaHora", "SalaId" },
                values: new object[] { new DateTime(2024, 3, 14, 19, 59, 15, 748, DateTimeKind.Local).AddTicks(9945), 1 });

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 3,
                columns: new[] { "FechaHora", "SalaId" },
                values: new object[] { new DateTime(2024, 3, 7, 19, 59, 15, 748, DateTimeKind.Local).AddTicks(9947), 1 });

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "SesionId",
                keyValue: 4,
                column: "FechaHora",
                value: new DateTime(2024, 3, 7, 19, 59, 15, 748, DateTimeKind.Local).AddTicks(9949));
        }
    }
}
