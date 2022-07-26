using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Migrations
{
    public partial class CreateSearchStoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE HotelRoomSearch 	
						@numberOfPeople int, 
						@bookIn datetime,
						@bookOut datetime
					AS
					BEGIN	
						SET NOCOUNT ON;
    
						SELECT hr.ID, hr.HotelID, hr.RoomTypeID FROM HotelRoom hr
						INNER JOIN RoomType ON hr.RoomTypeID = RoomType.ID
						WHERE RoomType.MaxNumberOfPeople >= @numberOfPeople
						AND NOT EXISTS
						(
							SELECT * FROM Booking
							WHERE HotelRoomID = hr.ID
							AND (StartDate <= @bookIn AND EndDate >= @bookOut)
						)
						AND NOT EXISTS
						(
							SELECT * FROM Booking
							WHERE HotelRoomID = hr.ID
							AND (StartDate >= @bookIn AND EndDate <= @bookOut)
						)
						END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
			var dropSP = @"DROP PROCEDURE dbo.HotelRoomSearch";

			migrationBuilder.Sql(dropSP);
		}
    }
}
