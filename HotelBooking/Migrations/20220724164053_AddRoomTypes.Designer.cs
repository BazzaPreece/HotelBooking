﻿// <auto-generated />
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
    [Migration("20220724164053_AddRoomTypes")]
    partial class AddRoomTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
#pragma warning restore 612, 618
        }
    }
}
