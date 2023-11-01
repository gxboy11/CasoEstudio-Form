using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasoEstudio_Form.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class pruebaPublicaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publicaciones_Publicaciones_idParent",
                table: "Publicaciones");

            migrationBuilder.AlterColumn<int>(
                name: "idParent",
                table: "Publicaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Publicaciones_Publicaciones_idParent",
                table: "Publicaciones",
                column: "idParent",
                principalTable: "Publicaciones",
                principalColumn: "idComentario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Publicaciones_Publicaciones_idParent",
                table: "Publicaciones");

            migrationBuilder.AlterColumn<int>(
                name: "idParent",
                table: "Publicaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Publicaciones_Publicaciones_idParent",
                table: "Publicaciones",
                column: "idParent",
                principalTable: "Publicaciones",
                principalColumn: "idComentario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
