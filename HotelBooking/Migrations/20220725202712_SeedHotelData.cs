using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Migrations
{
    public partial class SeedHotelData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "The Grand" },
                    { 2, "The Grand Hotel" },
                    { 3, "Belton Woods" },
                    { 4, "The Dorchester" },
                    { 5, "Fawlty Towers" }
                });

            migrationBuilder.InsertData(
                table: "HotelRoom",
                columns: new[] { "ID", "HotelID", "RoomTypeID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 3, 1, 2 },
                    { 4, 1, 2 },
                    { 5, 1, 3 },
                    { 6, 1, 3 },
                    { 7, 2, 1 },
                    { 8, 2, 2 },
                    { 9, 2, 2 },
                    { 10, 2, 3 },
                    { 11, 2, 3 },
                    { 12, 2, 3 },
                    { 13, 3, 1 },
                    { 14, 3, 1 },
                    { 15, 3, 2 },
                    { 16, 3, 3 },
                    { 17, 3, 3 },
                    { 18, 3, 3 },
                    { 19, 4, 2 },
                    { 20, 4, 3 },
                    { 21, 4, 3 },
                    { 22, 4, 3 },
                    { 23, 4, 3 },
                    { 24, 4, 3 },
                    { 25, 5, 1 },
                    { 26, 5, 1 },
                    { 27, 5, 1 },
                    { 28, 5, 1 },
                    { 29, 5, 2 },
                    { 30, 5, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "HotelRoom",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotel",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
