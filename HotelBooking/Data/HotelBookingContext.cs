using HotelBooking.Configuration;
using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;
using static HotelBooking.Constants;

namespace HotelBooking.Data
{
    public class HotelBookingContext : DbContext
    {
        public HotelBookingContext(DbContextOptions<HotelBookingContext> options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().ToTable(TableNames.Hotel);
            modelBuilder.Entity<HotelRoom>().ToTable(TableNames.HotelRoom);
            modelBuilder.Entity<RoomType>().ToTable(TableNames.RoomType);
            modelBuilder.Entity<Booking>().ToTable(TableNames.Booking);

            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());
        }
    }
}
