namespace HotelBooking.Models
{
    public class RoomType
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int MaxNumberOfPeople { get; set; }

        public ICollection<HotelRoom> HotelRooms { get; set; }
    }
}
