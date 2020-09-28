using Microsoft.AspNetCore.Mvc;
using SwapiBackend.Data;
using SwapiBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiBackend.Services
{
    public class VisitorParkingService : IVisitorParkingService
    {
        private readonly DataContext dataContext;

        public VisitorParkingService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<VisitorParking> AddVisitorParking()
        {
            var vis = new Visitor
            {
                VisitorId = 2,
                Name = "Darth Vader"
            };

            var park = new ParkingSpot
            {
                ParkingSpotId = 4,
                IsOccupied = true
            };

            var visitorParking = new VisitorParking
            {
                VisitorId = vis.VisitorId,
                ParkingSpotId = park.ParkingSpotId
            };

            dataContext.VisitorParkings.Add(visitorParking);
            await dataContext.SaveChangesAsync();

            return visitorParking;
        }
    }
}
