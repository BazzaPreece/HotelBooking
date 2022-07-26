using HotelBooking.Models;
using HotelBooking.Repositories;
using Microsoft.AspNetCore.Mvc;
using static HotelBooking.Constants;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IHotelBookingRepository _repository;

        public BookingsController(IHotelBookingRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Get booking with booking reference
        /// </summary>
        /// <param name="reference"></param>
        /// <returns>Booking object</returns>
        [HttpGet("{reference}")]
        public async Task<ActionResult<Booking>> GetBookingWithReference(string reference)
        {
            var booking = await _repository.GetBookingWithReference(reference);

            if (booking == null)
                return NotFound();

            return await _repository.GetBookingWithReference(reference);
        }

        // RISK: Date string not set in the correct format
        // RISK: Dates could be entered the wrong way round with the book in date after the book out date
        // RISK: No checks for whether the booking is still available so race conditions could be easily hit
        // RISK: On inserting the booking, no handling of possible duplicate booking reference numbers

        /// <summary>
        /// Create hotel booking with room ID, dates and number of guests
        /// </summary>
        /// <param name="hotelRoomID">ID of hotel room</param>
        /// <param name="bookInDay">Date format yyyy-MM-dd required</param>
        /// <param name="bookOutDay">Date format yyyy-MM-dd required</param>
        /// <param name="numberOfGuests">Maximum number of guests: 2</param>
        /// <returns>Created booking object</returns>
        [HttpPost]
        public async Task<ActionResult<Booking>> PostBooking(int hotelRoomID, string bookInDay,
                                                                string bookOutDay, int numberOfGuests)
        {
            var createdBooking = await _repository.CreateBooking(hotelRoomID, 
                                                                    DateOnly.Parse(bookInDay).ToDateTime(BookingDetails.BookInTime),
                                                                    DateOnly.Parse(bookOutDay).ToDateTime(BookingDetails.BookOutTime), 
                                                                    numberOfGuests);

            if (createdBooking == null)
                return Problem("Entity set 'HotelBookingContext.Bookings' is null.");            

            return createdBooking;
        }
    }
}
