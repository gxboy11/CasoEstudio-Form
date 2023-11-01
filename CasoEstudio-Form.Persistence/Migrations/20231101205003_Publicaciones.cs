using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasoEstudio_Form.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Publicaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    idComentario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idUsuario = table.Column<int>(type: "int", nullable: false),
                    textComentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaComentario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idParent = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.idComentario);
                    table.ForeignKey(
                        name: "FK_Publicaciones_Publicaciones_idParent",
                        column: x => x.idParent,
                        principalTable: "Publicaciones",
                        principalColumn: "idComentario");
                    table.ForeignKey(
                        name: "FK_Publicaciones_Usuarios_idUsuario",
                        column: x => x.idUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "idUsuario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_idParent",
                table: "Publicaciones",
                column: "idParent");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_idUsuario",
                table: "Publicaciones",
                column: "idUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publicaciones");
        }
    }
}
