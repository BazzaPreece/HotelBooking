using HotelBooking.Models;

namespace HotelBooking.Repositories
{
    public interface IHotelRoomRepository
    {
        Task<IEnumerable<HotelRoom>> Search(int numberOfGuests, DateTime bookInTime, DateTime bookOutTime);
        Task<HotelRoom> CreateBooking(HotelRoom hotelRoom);
    }
}
