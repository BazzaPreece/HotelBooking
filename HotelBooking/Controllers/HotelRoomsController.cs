using HotelBooking.Models;
using HotelBooking.Repositories;
using Microsoft.AspNetCore.Mvc;
using static HotelBooking.Constants;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelRoomsController : ControllerBase
    {
        private readonly IHotelRoomRepository _repository;

        public HotelRoomsController(IHotelRoomRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Search for rooms with number of people, booking in and booking out times
        /// </summary>
        /// <param name="numberOfGuests"></param>
        /// <param name="bookInDay"></param>
        /// <param name="bookOutDay"></param>
        /// <returns></returns>
        [HttpGet("{numberOfGuests}/{bookInDay}/{bookOutDay}")]
        public async Task<ActionResult<IEnumerable<HotelRoom>>> Search(int numberOfGuests, 
                                                                string bookInDay, 
                                                                string bookOutDay)
        {            
            var hotelRooms = await _repository.Search(numberOfGuests, 
                                                        DateOnly.Parse(bookInDay).ToDateTime(BookingDetails.BookInTime),
                                                        DateOnly.Parse(bookOutDay).ToDateTime(BookingDetails.BookOutTime));

            if (hotelRooms == null || !hotelRooms.Any())
            {
                return NotFound();
            }

            return new List<HotelRoom>(hotelRooms);
        }
    }
}
