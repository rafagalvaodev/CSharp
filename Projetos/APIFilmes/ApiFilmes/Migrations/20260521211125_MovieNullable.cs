using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFilmes.Migrations
{
    /// <inheritdoc />
    public partial class MovieNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_session_movies_MovieId",
                table: "session");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "session",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_session_movies_MovieId",
                table: "session",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_session_movies_MovieId",
                table: "session");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "session",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_session_movies_MovieId",
                table: "session",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
