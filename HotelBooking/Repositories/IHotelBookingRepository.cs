using HotelBooking.Models;

namespace HotelBooking.Repositories
{
    public interface IHotelBookingRepository
    {
        Task<IEnumerable<Hotel>> SearchHotels(string searchString);
        Task<IEnumerable<HotelRoom>> SearchHotelRooms(int numberOfGuests, DateTime bookInTime, DateTime bookOutTime);
        Task<HotelRoom> CreateBooking(HotelRoom hotelRoom);
    }
}
