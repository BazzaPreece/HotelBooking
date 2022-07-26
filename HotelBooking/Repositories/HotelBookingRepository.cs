using HotelBooking.Data;
using HotelBooking.Extensions;
using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Repositories
{
    public class HotelBookingRepository : IHotelBookingRepository
    {
        private readonly HotelBookingContext _context;

        public HotelBookingRepository(HotelBookingContext context)
        {
            _context = context;
        }

        #region Hotels

        public async Task<IEnumerable<Hotel>> SearchHotels(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
                return new List<Hotel>();

            return _context.Hotels
                           .Where(s => s.Name.Contains(searchString));
        }

        #endregion

        #region Hotel Rooms

        public async Task<IEnumerable<HotelRoom>> SearchHotelRooms(int numberOfGuests, DateTime bookInTime, DateTime bookOutTime)
        {
            return await _context.HotelRooms.FromSqlRaw(
                $"EXECUTE HotelRoomSearch " +
                $"@numberOfPeople = {numberOfGuests}, " +
                $"@bookIn = '{bookInTime.ToSQLFormat()}', " +
                $"@bookOut = '{bookOutTime.ToSQLFormat()}'").ToListAsync();
        }

        #endregion

        #region Bookings

        public async Task<Booking> GetBookingWithReference(string reference)
        {
            if (_context.Bookings == null)
            {
                return null;
            }

            var booking = await _context.Bookings.Where(b => b.Reference.ToUpper() == reference.ToUpper()).SingleOrDefaultAsync();

            if (booking == null)
            {
                return null;
            }

            return booking;
        }

        public async Task<Booking> CreateBooking(int hotelRoomID, DateTime bookInDay, DateTime bookOutDay, int numberOfGuests)
        {
            if (_context.Bookings == null)
            {
                return null;
            }

            var booking = new Booking
            {
                Reference = Helpers.GenerateBookingReference(),
                HotelRoomID = hotelRoomID,
                StartDate = bookInDay,
                EndDate = bookOutDay,
                NumberOfGuests = numberOfGuests
            };            

            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            return booking;
        }

        #endregion
    }
}
