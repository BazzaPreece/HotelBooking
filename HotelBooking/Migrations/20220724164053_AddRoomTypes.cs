using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Migrations
{
    public partial class AddRoomTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxNumberOfPeople = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "ID", "Description", "MaxNumberOfPeople" },
                values: new object[] { 1, "Single", 1 });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "ID", "Description", "MaxNumberOfPeople" },
                values: new object[] { 2, "Double", 2 });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "ID", "Description", "MaxNumberOfPeople" },
                values: new object[] { 3, "Deluxe", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}
