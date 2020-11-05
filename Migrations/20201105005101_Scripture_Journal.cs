using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Scripture_Journal.Migrations
{
    public partial class Scripture_Journal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scripture",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Collection = table.Column<string>(maxLength: 100, nullable: true),
                    Book = table.Column<string>(maxLength: 60, nullable: true),
                    Chapter = table.Column<int>(nullable: false),
                    Verse = table.Column<int>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scripture", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scripture");
        }
    }
}
