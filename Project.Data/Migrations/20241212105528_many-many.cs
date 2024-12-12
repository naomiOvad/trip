using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class manymany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistersTrip",
                columns: table => new
                {
                    registersid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tripscode = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistersTrip", x => new { x.registersid, x.tripscode });
                    table.ForeignKey(
                        name: "FK_RegistersTrip_registers_registersid",
                        column: x => x.registersid,
                        principalTable: "registers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistersTrip_trips_tripscode",
                        column: x => x.tripscode,
                        principalTable: "trips",
                        principalColumn: "code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistersTrip_tripscode",
                table: "RegistersTrip",
                column: "tripscode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistersTrip");
        }
    }
}
