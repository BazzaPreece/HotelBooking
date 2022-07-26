namespace HotelBooking
{
    public static partial class Helpers
    {
        public static string GenerateBookingReference()
        {
            // Generate a booking id made up in the format HBnnnnnnnn
            long i = 1, j = -1;

            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }
            foreach (byte b in Guid.NewGuid().ToByteArray())
            {
                j *= ((int)b + 1);
            }
            var str1 = string.Format("{0:d}", (i - DateTime.Now.Millisecond));
            var str2 = string.Format("{0:d}", (j - DateTime.Now.Millisecond));

            return $"HB{str1.Substring(1, 5)}{str2.Substring(str2.Length / 2, 4)}";
        }
    }
}
