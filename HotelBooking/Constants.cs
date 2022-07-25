namespace HotelBooking
{
    public static partial class Constants
    {
        public static partial class TableNames
        {
            public static string Hotel = "Hotel";
            public static string HotelRoom = "HotelRoom";
            public static string RoomType = "RoomType";
            public static string Booking = "Booking";
        }

        public static partial class BookingDetails
        {
            public static TimeOnly BookInTime = TimeOnly.Parse("3:00 PM");
            public static TimeOnly BookOutTime = TimeOnly.Parse("10:00 AM");
        }
    }
}
