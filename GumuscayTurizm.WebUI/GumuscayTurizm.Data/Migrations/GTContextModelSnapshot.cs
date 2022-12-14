// <auto-generated />
using System;
using GumuscayTurizm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GumuscayTurizm.Data.Migrations
{
    [DbContext(typeof(GTContext))]
    partial class GTContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("GumuscayTurizm.Entity.Bus", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("SeatingCapacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("BusId");

                    b.ToTable("Busses");

                    b.HasData(
                        new
                        {
                            BusId = 1,
                            Name = "Mercedes",
                            SeatingCapacity = 30
                        },
                        new
                        {
                            BusId = 2,
                            Name = "Volvo",
                            SeatingCapacity = 30
                        });
                });

            modelBuilder.Entity("GumuscayTurizm.Entity.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Name = "İstanbul"
                        },
                        new
                        {
                            CityId = 2,
                            Name = "Bursa"
                        },
                        new
                        {
                            CityId = 3,
                            Name = "Bandırma"
                        },
                        new
                        {
                            CityId = 4,
                            Name = "Biga"
                        },
                        new
                        {
                            CityId = 5,
                            Name = "Çanakkale"
                        },
                        new
                        {
                            CityId = 6,
                            Name = "İzmir"
                        },
                        new
                        {
                            CityId = 7,
                            Name = "Kocaeli"
                        },
                        new
                        {
                            CityId = 8,
                            Name = "Sakarya"
                        });
                });

            modelBuilder.Entity("GumuscayTurizm.Entity.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("PassengerId");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            PassengerId = 1,
                            Email = "",
                            FirstName = "",
                            Gender = "E",
                            IdentificationNumber = "1",
                            LastName = ""
                        });
                });

            modelBuilder.Entity("GumuscayTurizm.Entity.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BusId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassengerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TripId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TicketId");

                    b.HasIndex("BusId");

                    b.HasIndex("PassengerId");

                    b.HasIndex("TripId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            BusId = 1,
                            PassengerId = 1,
                            SeatNumber = 1,
                            TripId = 1
                        });
                });

            modelBuilder.Entity("GumuscayTurizm.Entity.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BusId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("EstimatedTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("FromWhereId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.Property<int>("ToWhereId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TripId");

                    b.HasIndex("BusId");

                    b.HasIndex("FromWhereId");

                    b.HasIndex("ToWhereId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            BusId = 2,
                            Date = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EstimatedTime = "4sa45dk",
                            FromWhereId = 1,
                            Price = 150m,
                            Time = "15:00",
                            ToWhereId = 5
                        },
                        new
                        {
                            TripId = 3,
                            BusId = 2,
                            Date = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EstimatedTime = "4sa45dk",
                            FromWhereId = 1,
                            Price = 150m,
                            Time = "18:00",
                            ToWhereId = 5
                        },
                        new
                        {
                            TripId = 2,
                            BusId = 1,
                            Date = new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EstimatedTime = "1sa45dk",
                            FromWhereId = 1,
                            Price = 100m,
                            Time = "15:00",
                            ToWhereId = 2
                        });
                });

            modelBuilder.Entity("GumuscayTurizm.Entity.Ticket", b =>
                {
                    b.HasOne("GumuscayTurizm.Entity.Bus", "Bus")
                        .WithMany("Tickets")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GumuscayTurizm.Entity.Passenger", "Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GumuscayTurizm.Entity.Trip", "Trip")
                        .WithMany("Tickets")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("Passenger");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("GumuscayTurizm.Entity.Trip", b =>
                {
                    b.HasOne("GumuscayTurizm.Entity.Bus", "Bus")
                        .WithMany("Trips")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GumuscayTurizm.Entity.City", "FromWhere")
                        .WithMany()
                        .HasForeignKey("FromWhereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GumuscayTurizm.Entity.City", "ToWhere")
                        .WithMany()
                        .HasForeignKey("ToWhereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("FromWhere");

                    b.Navigation("ToWhere");
                });

            modelBuilder.Entity("GumuscayTurizm.Entity.Bus", b =>
                {
                    b.Navigation("Tickets");

                    b.Navigation("Trips");
                });

            modelBuilder.Entity("GumuscayTurizm.Entity.Passenger", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("GumuscayTurizm.Entity.Trip", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
