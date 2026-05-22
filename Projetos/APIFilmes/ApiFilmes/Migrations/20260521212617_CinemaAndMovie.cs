using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiFilmes.Migrations
{
    /// <inheritdoc />
    public partial class CinemaAndMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_session_cinema_CinemaId",
                table: "session");

            migrationBuilder.DropForeignKey(
                name: "FK_session_movies_MovieId",
                table: "session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_session",
                table: "session");

            migrationBuilder.DropIndex(
                name: "IX_session_MovieId",
                table: "session");

            migrationBuilder.DropColumn(
                name: "Id",
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

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "session",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_session",
                table: "session",
                columns: new[] { "MovieId", "CinemaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_session_cinema_CinemaId",
                table: "session",
                column: "CinemaId",
                principalTable: "cinema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_session_cinema_CinemaId",
                table: "session");

            migrationBuilder.DropForeignKey(
                name: "FK_session_movies_MovieId",
                table: "session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_session",
                table: "session");

            migrationBuilder.AlterColumn<int>(
                name: "CinemaId",
                table: "session",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "session",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "session",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_session",
                table: "session",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_session_MovieId",
                table: "session",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_session_cinema_CinemaId",
                table: "session",
                column: "CinemaId",
                principalTable: "cinema",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_session_movies_MovieId",
                table: "session",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "Id");
        }
    }
}
