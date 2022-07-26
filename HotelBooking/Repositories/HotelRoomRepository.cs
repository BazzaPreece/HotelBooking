using HotelBooking.Data;
using HotelBooking.Extensions;
using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Repositories
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly HotelBookingContext _context;

        public HotelRoomRepository(HotelBookingContext context)
        {
            _context = context;
        }

        // TODO: Implement booking creation
        public Task<HotelRoom> CreateBooking(HotelRoom hotelRoom)
        {
            throw new NotImplementedException();
        }
        
        public async Task<IEnumerable<HotelRoom>> Search(int numberOfGuests, DateTime bookInTime, DateTime bookOutTime)
        {
            return await _context.HotelRooms.FromSqlRaw(
                $"EXECUTE HotelRoomSearch " +
                $"@numberOfPeople = {numberOfGuests}, " +
                $"@bookIn = '{bookInTime.ToSQLFormat()}', " +
                $"@bookOut = '{bookOutTime.ToSQLFormat()}'").ToListAsync();                        
        }
    }
}
