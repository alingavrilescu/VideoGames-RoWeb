using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoGames.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Games_GamesId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_GamesId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "GamesId",
                table: "Review");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Review");

            migrationBuilder.AddColumn<int>(
                name: "GamesId",
                table: "Review",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_GamesId",
                table: "Review",
                column: "GamesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Games_GamesId",
                table: "Review",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id");
        }
    }
}
