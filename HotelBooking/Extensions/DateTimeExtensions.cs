namespace HotelBooking.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToSQLFormat(this DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
    }
}
