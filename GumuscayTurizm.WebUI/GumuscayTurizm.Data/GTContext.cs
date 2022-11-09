using GumuscayTurizm.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data
{
    public class GTContext : DbContext
    {
        public GTContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Bus> Busses { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                  .Entity<City>()
                  .HasData(

                 new City() { CityId = 1, Name = "İstanbul" },
                 new City() { CityId = 2, Name = "Bursa" },
                 new City() { CityId = 3, Name = "Bandırma" },
                 new City() { CityId = 4, Name = "Biga" },
                 new City() { CityId = 5, Name = "Çanakkale" },
                 new City() { CityId = 6, Name = "İzmir" },
                 new City() { CityId = 7, Name = "Kocaeli" },
                 new City() { CityId = 8, Name = "Sakarya" }

                  );
            modelBuilder
                .Entity<Bus>()
                .HasData(
                new Bus() { BusId = 1, Name="Mercedes", SeatingCapacity = 30 },
                new Bus() { BusId = 2, Name="Volvo", SeatingCapacity = 30 }
                );
            modelBuilder
                .Entity<Trip>()
                .HasData(
                new Trip() { TripId = 1, Date = new DateTime(2022,12,25),FromWhereId=1,ToWhereId=5,Price=150,BusId=2},
                new Trip() { TripId = 2, Date = new DateTime(2022, 12, 25), FromWhereId = 1, ToWhereId = 2, Price=100, BusId=1}
                );
            
                
                

            modelBuilder
                .Entity<Passenger>()
                .HasData(
                new Passenger() { PassengerId = 1, FirstName = "", LastName = "", Email = "",Gender="E",IdentificationNumber="1" }
                );
            modelBuilder
                .Entity<Ticket>()
                .HasData(
                new Ticket() { TicketId = 1, PassengerId = 1, BusId = 1, TripId = 1, SeatNumber = 1 }
                );

        }
    }
    }

