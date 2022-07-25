using HotelBooking.Models;

namespace HotelBooking.Repositories
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotel>> Search(string searchString);
    }
}
