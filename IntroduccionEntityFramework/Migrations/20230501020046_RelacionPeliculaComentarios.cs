using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IntroduccionEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPeliculaComentarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaEstreno",
                table: "Peliculas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId",
                table: "Comentario",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comentario_PeliculaId",
                table: "Comentario",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentario_Peliculas_PeliculaId",
                table: "Comentario",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentario_Peliculas_PeliculaId",
                table: "Comentario");

            migrationBuilder.DropIndex(
                name: "IX_Comentario_PeliculaId",
                table: "Comentario");

            migrationBuilder.DropColumn(
                name: "PeliculaId",
                table: "Comentario");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaEstreno",
                table: "Peliculas",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }
    }
}
