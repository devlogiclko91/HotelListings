using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListings.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 1, "United States", "US" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 2, "India", "IND" });

            migrationBuilder.InsertData(
                table: "countries",
                columns: new[] { "Id", "Name", "ShortName" },
                values: new object[] { 3, "Bhamas", "BHS" });

            migrationBuilder.InsertData(
                table: "hotles",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Califonia", 1, "Caaan", 4.5 },
                    { 2, "Califonia", 1, "KAJI", 5.0 },
                    { 3, "Lucknow", 2, "Jakana", 4.0 },
                    { 4, "Lucknow", 2, "Hotel San", 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "hotles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "hotles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hotles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "hotles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "countries",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
