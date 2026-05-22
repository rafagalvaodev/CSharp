using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFilmes.Migrations
{
    /// <inheritdoc />
    public partial class SessionAndCinema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "session",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_session_CinemaId",
                table: "session",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_session_cinema_CinemaId",
                table: "session",
                column: "CinemaId",
                principalTable: "cinema",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_session_cinema_CinemaId",
                table: "session");

            migrationBuilder.DropIndex(
                name: "IX_session_CinemaId",
                table: "session");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "session");
        }
    }
}
