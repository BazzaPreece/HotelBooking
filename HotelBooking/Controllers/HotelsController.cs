using HotelBooking.Models;
using HotelBooking.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelRepository _repository;

        public HotelsController(IHotelRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Search hotels by name
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>List of hotels with search string contained in the name</returns>
        [HttpGet("{searchString}")]
        public async Task<ActionResult<IEnumerable<Hotel>>> Search(string searchString)
        {
            var hotels = await _repository.Search(searchString);

            if (hotels == null || !hotels.Any())
            {
                return NotFound();
            }

            return new List<Hotel>(hotels);
        }
    }
}
