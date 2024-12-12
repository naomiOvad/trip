using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class onemany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "guideId",
                table: "trips",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_trips_guideId",
                table: "trips",
                column: "guideId");

            migrationBuilder.AddForeignKey(
                name: "FK_trips_guides_guideId",
                table: "trips",
                column: "guideId",
                principalTable: "guides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trips_guides_guideId",
                table: "trips");

            migrationBuilder.DropIndex(
                name: "IX_trips_guideId",
                table: "trips");

            migrationBuilder.DropColumn(
                name: "guideId",
                table: "trips");
        }
    }
}
