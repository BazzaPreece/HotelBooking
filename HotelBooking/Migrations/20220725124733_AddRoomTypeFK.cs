using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Migrations
{
    public partial class AddRoomTypeFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_HotelRoom_RoomTypeID",
                table: "HotelRoom",
                column: "RoomTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRoom_RoomType_RoomTypeID",
                table: "HotelRoom",
                column: "RoomTypeID",
                principalTable: "RoomType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRoom_RoomType_RoomTypeID",
                table: "HotelRoom");

            migrationBuilder.DropIndex(
                name: "IX_HotelRoom_RoomTypeID",
                table: "HotelRoom");
        }
    }
}
