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

        public async Task<IEnumerable<Hotel>> SearchHotels(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
                return new List<Hotel>();

            return _context.Hotels
                           .Where(s => s.Name.Contains(searchString));
        }

        public Task<HotelRoom> CreateBooking(HotelRoom hotelRoom)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<HotelRoom>> SearchHotelRooms(int numberOfGuests, DateTime bookInTime, DateTime bookOutTime)
        {
            return await _context.HotelRooms.FromSqlRaw(
                $"EXECUTE HotelRoomSearch " +
                $"@numberOfPeople = {numberOfGuests}, " +
                $"@bookIn = '{bookInTime.ToSQLFormat()}', " +
                $"@bookOut = '{bookOutTime.ToSQLFormat()}'").ToListAsync();
        }
    }
}
