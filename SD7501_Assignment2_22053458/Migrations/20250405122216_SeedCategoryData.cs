using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SD7501_Assignment2_22053458.Migrations
{
    /// <inheritdoc />
    public partial class SeedParkingSlotsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ParkingSlots",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Inside of the car", "Interior" },
                    { 2, "Outside of the car", "Exterior" },
                    { 3, "Headlights and LED", "Lighting" },
                    { 4, "To stop the car", "Brakes & Suspension" },
                    { 5, "Waste coming out of the car", "Exhaust" },
                    { 6, "Make the car runs", "Engines" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ParkingSlots",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
