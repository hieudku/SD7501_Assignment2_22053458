using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SD7501_Assignment2_22053458.Migrations
{
    /// <inheritdoc />
    public partial class ParkingBookingTablesCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Category",
                newName: "SlotCode");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Category",
                newName: "Location");

            migrationBuilder.AddColumn<bool>(
                name: "IsVacant",
                table: "Category",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParkingSlotId = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Category_ParkingSlotId",
                        column: x => x.ParkingSlotId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsVacant", "Location", "SlotCode" },
                values: new object[] { true, "Kensington Avenue", "K1" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsVacant", "Location", "SlotCode" },
                values: new object[] { true, "Kensington Avenue", "K2" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsVacant", "Location", "SlotCode" },
                values: new object[] { true, "Kensington Avenue", "K3" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsVacant", "Location", "SlotCode" },
                values: new object[] { true, "Kensington Avenue", "K4" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsVacant", "Location", "SlotCode" },
                values: new object[] { true, "Kensington Avenue", "K5" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsVacant", "Location", "SlotCode" },
                values: new object[] { true, "Kensington Avenue", "K6" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "IsVacant", "Location", "SlotCode" },
                values: new object[,]
                {
                    { 7, true, "Kensington Avenue", "K7" },
                    { 8, true, "Kensington Avenue", "K8" },
                    { 9, true, "Kensington Avenue", "K9" },
                    { 10, true, "Kensington Avenue", "K10" },
                    { 11, true, "Kensington Avenue", "K11" },
                    { 12, true, "Kensington Avenue", "K12" },
                    { 13, true, "Huia Street", "H1" },
                    { 14, true, "Huia Street", "H2" },
                    { 15, true, "Huia Street", "H3" },
                    { 16, true, "Huia Street", "H4" },
                    { 17, true, "Huia Street", "H5" },
                    { 18, true, "Huia Street", "H6" },
                    { 19, true, "Huia Street", "H7" },
                    { 20, true, "Huia Street", "H8" },
                    { 21, true, "Huia Street", "H9" },
                    { 22, true, "Huia Street", "H10" },
                    { 23, true, "Huia Street", "H11" },
                    { 24, true, "Huia Street", "H12" },
                    { 25, true, "Udy Street", "U1" },
                    { 26, true, "Udy Street", "U2" },
                    { 27, true, "Udy Street", "U3" },
                    { 28, true, "Udy Street", "U4" },
                    { 29, true, "Udy Street", "U5" },
                    { 30, true, "Udy Street", "U6" },
                    { 31, true, "Udy Street", "U7" },
                    { 32, true, "Udy Street", "U8" },
                    { 33, true, "Udy Street", "U9" },
                    { 34, true, "Udy Street", "U10" },
                    { 35, true, "Udy Street", "U11" },
                    { 36, true, "Udy Street", "U12" },
                    { 37, true, "Atiawa Street", "A1" },
                    { 38, true, "Atiawa Street", "A2" },
                    { 39, true, "Atiawa Street", "A3" },
                    { 40, true, "Atiawa Street", "A4" },
                    { 41, true, "Atiawa Street", "A5" },
                    { 42, true, "Atiawa Street", "A6" },
                    { 43, true, "Atiawa Street", "A7" },
                    { 44, true, "Atiawa Street", "A8" },
                    { 45, true, "Atiawa Street", "A9" },
                    { 46, true, "Atiawa Street", "A10" },
                    { 47, true, "Atiawa Street", "A11" },
                    { 48, true, "Atiawa Street", "A12" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ParkingSlotId",
                table: "Bookings",
                column: "ParkingSlotId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DropColumn(
                name: "IsVacant",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "SlotCode",
                table: "Category",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Category",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Inside of the car", "Interior" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Outside of the car", "Exterior" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Headlights and LED", "Lighting" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "To stop the car", "Brakes & Suspension" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Waste coming out of the car", "Exhaust" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Make the car runs", "Engines" });
        }
    }
}
