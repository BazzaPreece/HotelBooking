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

        // RISK: Date string not set in the correct format
        // RISK: Dates could be entered the wrong way round with the book in date after the book out date

        /// <summary>
        /// Search for rooms with number of people, booking in and booking out times
        /// </summary>
        /// <param name="numberOfGuests">Maximum number of guests: 2</param>
        /// <param name="bookInDay">Date format yyyy-MM-dd required</param>
        /// <param name="bookOutDay">Date format yyyy-MM-dd required</param>
        /// <returns>List of available hotel rooms available for the whole duration of the stay for the specified number of people</returns>
        [HttpGet]
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
