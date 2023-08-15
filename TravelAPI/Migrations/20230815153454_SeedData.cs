using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountryName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Review = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "CityName", "CountryName", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Washington DC", "United States", 8, "See important national landmarks" },
                    { 2, "London", "United Kingdom", 9, "Lovely valleys and streams" },
                    { 3, "Atlanta", "United States", 4, "Hot and muggy!" },
                    { 4, "Paris", "France", 9, "Tres bien" },
                    { 5, "New York City", "United States", 9, "Top of the rock" },
                    { 6, "Boston", "United States", 8, "Visit the Green Monster" },
                    { 7, "Cairo", "Egypt", 4, "The pyramids are smaller in real life" },
                    { 8, "Johannesburg", "South Africa", 8, "Swim with white sharks" },
                    { 9, "Tokyo", "Japan", 7, "Extremely lively city" },
                    { 10, "Milan", "Italy", 10, "Visit the duomo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
