using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static HotelBooking.Constants;
using static HotelBooking.Enums;

namespace HotelBooking.Configuration
{
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.ToTable(TableNames.RoomType);                        
            builder.HasData
            (
                new RoomType
                {
                    ID = (int)RoomTypes.Single,
                    Description = RoomTypes.Single.ToString(),
                    MaxNumberOfPeople = 1
                },
                new RoomType
                {
                    ID = (int)RoomTypes.Double,
                    Description = RoomTypes.Double.ToString(),
                    MaxNumberOfPeople = 2
                },
                // ASSUMPTION: Number of people in a deluxe room is 2
                // ASSUMPTION: All hotels deluxe rooms hold the same number of people
                new RoomType
                {
                    ID = (int)RoomTypes.Deluxe,
                    Description = RoomTypes.Deluxe.ToString(),
                    MaxNumberOfPeople = 2
                }
            );
        }
    }
}
