using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models
{
    public class HotelRoom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int HotelID { get; set; }
        public int RoomTypeID { get; set; }

        ICollection<Booking> Bookings { get; set; }
    }
}
