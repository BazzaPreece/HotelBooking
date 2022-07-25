using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBooking.Models
{
    public class Hotel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<HotelRoom> Rooms { get; set; }
    }
}
