﻿// <auto-generated />
using System;
using HotelBooking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelBooking.Migrations
{
    [DbContext(typeof(HotelBookingContext))]
    [Migration("20220726172956_EnsureBookingReferenceIsUnique")]
    partial class EnsureBookingReferenceIsUnique
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelBooking.Models.Booking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelRoomID")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<string>("Reference")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("Reference")
                        .IsUnique();

                    b.ToTable("Booking", (string)null);
                });

            modelBuilder.Entity("HotelBooking.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hotel", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "The Grand"
                        },
                        new
                        {
                            ID = 2,
                            Name = "The Grand Hotel"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Belton Woods"
                        },
                        new
                        {
                            ID = 4,
                            Name = "The Dorchester"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Fawlty Towers"
                        });
                });

            modelBuilder.Entity("HotelBooking.Models.HotelRoom", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HotelID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("HotelRoom", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            HotelID = 1,
                            RoomTypeID = 1
                        },
                        new
                        {
                            ID = 2,
                            HotelID = 1,
                            RoomTypeID = 1
                        },
                        new
                        {
                            ID = 3,
                            HotelID = 1,
                            RoomTypeID = 2
                        },
                        new
                        {
                            ID = 4,
                            HotelID = 1,
                            RoomTypeID = 2
                        },
                        new
                        {
                            ID = 5,
                            HotelID = 1,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 6,
                            HotelID = 1,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 7,
                            HotelID = 2,
                            RoomTypeID = 1
                        },
                        new
                        {
                            ID = 8,
                            HotelID = 2,
                            RoomTypeID = 2
                        },
                        new
                        {
                            ID = 9,
                            HotelID = 2,
                            RoomTypeID = 2
                        },
                        new
                        {
                            ID = 10,
                            HotelID = 2,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 11,
                            HotelID = 2,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 12,
                            HotelID = 2,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 13,
                            HotelID = 3,
                            RoomTypeID = 1
                        },
                        new
                        {
                            ID = 14,
                            HotelID = 3,
                            RoomTypeID = 1
                        },
                        new
                        {
                            ID = 15,
                            HotelID = 3,
                            RoomTypeID = 2
                        },
                        new
                        {
                            ID = 16,
                            HotelID = 3,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 17,
                            HotelID = 3,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 18,
                            HotelID = 3,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 19,
                            HotelID = 4,
                            RoomTypeID = 2
                        },
                        new
                        {
                            ID = 20,
                            HotelID = 4,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 21,
                            HotelID = 4,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 22,
                            HotelID = 4,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 23,
                            HotelID = 4,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 24,
                            HotelID = 4,
                            RoomTypeID = 3
                        },
                        new
                        {
                            ID = 25,
                            HotelID = 5,
                            RoomTypeID = 1
                        },
                        new
                        {
                            ID = 26,
                            HotelID = 5,
                            RoomTypeID = 1
                        },
                        new
                        {
                            ID = 27,
                            HotelID = 5,
                            RoomTypeID = 1
                        },
                        new
                        {
                            ID = 28,
                            HotelID = 5,
                            RoomTypeID = 1
                        },
                        new
                        {
                            ID = 29,
                            HotelID = 5,
                            RoomTypeID = 2
                        },
                        new
                        {
                            ID = 30,
                            HotelID = 5,
                            RoomTypeID = 2
                        });
                });

            modelBuilder.Entity("HotelBooking.Models.RoomType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxNumberOfPeople")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("RoomType", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Single",
                            MaxNumberOfPeople = 1
                        },
                        new
                        {
                            ID = 2,
                            Description = "Double",
                            MaxNumberOfPeople = 2
                        },
                        new
                        {
                            ID = 3,
                            Description = "Deluxe",
                            MaxNumberOfPeople = 2
                        });
                });

            modelBuilder.Entity("HotelBooking.Models.HotelRoom", b =>
                {
                    b.HasOne("HotelBooking.Models.Hotel", null)
                        .WithMany("Rooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelBooking.Models.RoomType", null)
                        .WithMany("HotelRooms")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelBooking.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("HotelBooking.Models.RoomType", b =>
                {
                    b.Navigation("HotelRooms");
                });
#pragma warning restore 612, 618
        }
    }
}
