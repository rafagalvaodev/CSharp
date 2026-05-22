using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFilmes.Migrations
{
    /// <inheritdoc />
    public partial class DeleteRestrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cinema_address_AddressId",
                table: "cinema");

            migrationBuilder.AddForeignKey(
                name: "FK_cinema_address_AddressId",
                table: "cinema",
                column: "AddressId",
                principalTable: "address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cinema_address_AddressId",
                table: "cinema");

            migrationBuilder.AddForeignKey(
                name: "FK_cinema_address_AddressId",
                table: "cinema",
                column: "AddressId",
                principalTable: "address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
