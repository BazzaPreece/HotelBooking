using HotelBooking.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBookingTestToolsController : ControllerBase
    {
        private readonly HotelBookingContext _context;

        public HotelBookingTestToolsController(HotelBookingContext context)
        {
            _context = context;
        }

        // RISK: Not something that should be exposed when moving to production. Also, marked it as a PUT even though there isn't
        // a payload coming through as it is in effect doing two things - a delete and then a seed. Separating these two doesn't
        // feel right as it would leave the data in an unusable state.

        /// <summary>
        /// Delete existing test data and seed with fresh test data
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> ResetData()
        {
            await _context.Database.EnsureDeletedAsync();            
            
            await _context.Database.MigrateAsync();

            return NoContent();
        }
    }
}
