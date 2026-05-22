using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFilmes.Migrations
{
    /// <inheritdoc />
    public partial class SessionAndMovieUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_movies_MovieId",
                table: "Sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions");

            migrationBuilder.RenameTable(
                name: "Sessions",
                newName: "session");

            migrationBuilder.RenameIndex(
                name: "IX_Sessions_MovieId",
                table: "session",
                newName: "IX_session_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_session",
                table: "session",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_session_movies_MovieId",
                table: "session",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_session_movies_MovieId",
                table: "session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_session",
                table: "session");

            migrationBuilder.RenameTable(
                name: "session",
                newName: "Sessions");

            migrationBuilder.RenameIndex(
                name: "IX_session_MovieId",
                table: "Sessions",
                newName: "IX_Sessions_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_movies_MovieId",
                table: "Sessions",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
