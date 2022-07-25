using HotelBooking.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {            
            // RISK: If this is triggered on live, the database will be populated with test data            
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { ID = 1, Name = "The Grand" },
                new Hotel { ID = 2, Name = "The Grand Hotel" },
                new Hotel { ID = 3, Name = "Belton Woods" },
                new Hotel { ID = 4, Name = "The Dorchester" },
                new Hotel { ID = 5, Name = "Fawlty Towers" }
            );

            modelBuilder.Entity<HotelRoom>().HasData(
                new HotelRoom { ID = 1, HotelID = 1, RoomTypeID = (int)Enums.RoomTypes.Single },
                new HotelRoom { ID = 2, HotelID = 1, RoomTypeID = (int)Enums.RoomTypes.Single },
                new HotelRoom { ID = 3, HotelID = 1, RoomTypeID = (int)Enums.RoomTypes.Double },
                new HotelRoom { ID = 4, HotelID = 1, RoomTypeID = (int)Enums.RoomTypes.Double },
                new HotelRoom { ID = 5, HotelID = 1, RoomTypeID = (int)Enums.RoomTypes.Deluxe },
                new HotelRoom { ID = 6, HotelID = 1, RoomTypeID = (int)Enums.RoomTypes.Deluxe },

                new HotelRoom { ID = 7, HotelID = 2, RoomTypeID = (int)Enums.RoomTypes.Single },
                new HotelRoom { ID = 8, HotelID = 2, RoomTypeID = (int)Enums.RoomTypes.Double },
                new HotelRoom { ID = 9, HotelID = 2, RoomTypeID = (int)Enums.RoomTypes.Double },
                new HotelRoom { ID = 10, HotelID = 2, RoomTypeID = (int)Enums.RoomTypes.Deluxe },
                new HotelRoom { ID = 11, HotelID = 2, RoomTypeID = (int)Enums.RoomTypes.Deluxe },
                new HotelRoom { ID = 12, HotelID = 2, RoomTypeID = (int)Enums.RoomTypes.Deluxe },

                new HotelRoom { ID = 13, HotelID = 3, RoomTypeID = (int)Enums.RoomTypes.Single },
                new HotelRoom { ID = 14, HotelID = 3, RoomTypeID = (int)Enums.RoomTypes.Single },
                new HotelRoom { ID = 15, HotelID = 3, RoomTypeID = (int)Enums.RoomTypes.Double },
                new HotelRoom { ID = 16, HotelID = 3, RoomTypeID = (int)Enums.RoomTypes.Deluxe },
                new HotelRoom { ID = 17, HotelID = 3, RoomTypeID = (int)Enums.RoomTypes.Deluxe },
                new HotelRoom { ID = 18, HotelID = 3, RoomTypeID = (int)Enums.RoomTypes.Deluxe },

                new HotelRoom { ID = 19, HotelID = 4, RoomTypeID = (int)Enums.RoomTypes.Double },
                new HotelRoom { ID = 20, HotelID = 4, RoomTypeID = (int)Enums.RoomTypes.Deluxe },
                new HotelRoom { ID = 21, HotelID = 4, RoomTypeID = (int)Enums.RoomTypes.Deluxe },
                new HotelRoom { ID = 22, HotelID = 4, RoomTypeID = (int)Enums.RoomTypes.Deluxe },
                new HotelRoom { ID = 23, HotelID = 4, RoomTypeID = (int)Enums.RoomTypes.Deluxe },
                new HotelRoom { ID = 24, HotelID = 4, RoomTypeID = (int)Enums.RoomTypes.Deluxe },

                new HotelRoom { ID = 25, HotelID = 5, RoomTypeID = (int)Enums.RoomTypes.Single },
                new HotelRoom { ID = 26, HotelID = 5, RoomTypeID = (int)Enums.RoomTypes.Single },
                new HotelRoom { ID = 27, HotelID = 5, RoomTypeID = (int)Enums.RoomTypes.Single },
                new HotelRoom { ID = 28, HotelID = 5, RoomTypeID = (int)Enums.RoomTypes.Single },
                new HotelRoom { ID = 29, HotelID = 5, RoomTypeID = (int)Enums.RoomTypes.Double },
                new HotelRoom { ID = 30, HotelID = 5, RoomTypeID = (int)Enums.RoomTypes.Double }
            );                            
        }
    }
}
