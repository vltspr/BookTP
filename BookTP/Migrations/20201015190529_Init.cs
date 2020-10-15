using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookTP.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shelves",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Authors = table.Column<string>(nullable: true),
                    Publisher = table.Column<string>(nullable: true),
                    PublishedDate = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PageCount = table.Column<int>(nullable: false),
                    PrintType = table.Column<string>(nullable: true),
                    AverageRating = table.Column<int>(nullable: false),
                    RatingsCount = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    PreviewLink = table.Column<string>(nullable: true),
                    InfoLink = table.Column<string>(nullable: true),
                    ShelveId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Shelves_ShelveId",
                        column: x => x.ShelveId,
                        principalTable: "Shelves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_ShelveId",
                table: "Books",
                column: "ShelveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Shelves");
        }
    }
}
