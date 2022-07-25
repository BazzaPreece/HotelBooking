using HotelBooking.Configuration;
using HotelBooking.Extensions;
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

        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Hotel> Hotels { get; set; }        
        public DbSet <HotelRoom> HotelRooms { get; set; }
        public DbSet <Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hotel>().ToTable(TableNames.Hotel);
            modelBuilder.Entity<HotelRoom>().ToTable(TableNames.HotelRoom);
            modelBuilder.Entity<RoomType>().ToTable(TableNames.RoomType);
            modelBuilder.Entity<Booking>().ToTable(TableNames.Booking);

            modelBuilder.ApplyConfiguration(new RoomTypeConfiguration());

            modelBuilder.Seed();
        }
    }
}
