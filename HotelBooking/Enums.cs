namespace HotelBooking
{
    public static partial class Enums
    {
        // RISK: Setting the ID values like this could cause issues if the IDs of the table have already been set
        public enum RoomTypes
        {
            Single = 1, Double = 2, Deluxe = 3
        }
    }
}
