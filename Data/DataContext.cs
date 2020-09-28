using Microsoft.EntityFrameworkCore;
using SwapiBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SwapiBackend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<SpacePort> SpacePorts { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<VisitorParking> VisitorParkings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VisitorParking>().HasKey(x => new { x.ParkingSpotId, x.VisitorId });

            modelBuilder.Entity<SpacePort>().ToTable("Parkinglot");
            modelBuilder.Entity<SpacePort>().HasKey(p => p.SpacePortId);
            modelBuilder.Entity<SpacePort>().HasData(new
            {
               SpacePortId = 1,
               Name = "Nojjan"
            });

            modelBuilder.Entity<ParkingSpot>().ToTable("Parkingspot");
            modelBuilder.Entity<ParkingSpot>().HasKey(p => p.ParkingSpotId);
            modelBuilder.Entity<ParkingSpot>().HasData(new
            {
                ParkingSpotId = 1,
                IsOccupied = false,
                SpacePortId = 1
            }, new
            {
                ParkingSpotId = 2,
                IsOccupied = false,
                SpacePortId = 1
            }, new
            {
                ParkingSpotId = 3,
                IsOccupied = false,
                SpacePortId = 1
            }, new
            {
                ParkingSpotId = 4,
                IsOccupied = false,
                SpacePortId = 1
            }, new
            {
                ParkingSpotId = 5,
                IsOccupied = false,
                SpacePortId = 1
            });
        }
    }
}
