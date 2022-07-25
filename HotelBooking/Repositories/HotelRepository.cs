using HotelBooking.Data;
using HotelBooking.Models;

namespace HotelBooking.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelBookingContext _context;

        public HotelRepository(HotelBookingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Hotel>> Search(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
                return new List<Hotel>();

            return _context.Hotels
                           .Where(s => s.Name.Contains(searchString));                           
        }
    }
}
