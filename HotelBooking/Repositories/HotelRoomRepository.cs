using HotelBooking.Data;
using HotelBooking.Models;

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

        // TODO: Implement search
        public async Task<IEnumerable<HotelRoom>> Search(int numberOfGuests, DateTime bookInTime, DateTime bookOutTime)
        {
            throw new NotImplementedException();
        }
    }
}
