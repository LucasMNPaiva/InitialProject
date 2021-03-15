using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventProject.Migrations
{
    public partial class ProAgilProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    NmrPeoples = table.Column<int>(nullable: false),
                    LotPurchase = table.Column<string>(nullable: true),
                    EventUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
