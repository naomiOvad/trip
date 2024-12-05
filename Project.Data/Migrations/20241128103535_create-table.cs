using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class createtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "guides",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "registers",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    codeTrip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "trips",
                columns: table => new
                {
                    code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    numRegisters = table.Column<int>(type: "int", nullable: false),
                    idGuide = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trips", x => x.code);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "guides");

            migrationBuilder.DropTable(
                name: "registers");

            migrationBuilder.DropTable(
                name: "trips");
        }
    }
}
