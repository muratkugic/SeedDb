using Microsoft.EntityFrameworkCore;
using SwapiBackend.Data;
using SwapiBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiBackend.Services
{
    public class ParkingSpotService : IParkingSpotService
    {
        private readonly DataContext dataContext;

        public ParkingSpotService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<List<ParkingSpot>> GetAllParkingSpots()
        {
            return await dataContext.ParkingSpots.ToListAsync();
        }

        public async Task<ParkingSpot> GetParkingSpotById(int id)
        {
            return await dataContext.ParkingSpots.Where(p => p.ParkingSpotId == id).FirstOrDefaultAsync();
        }
    }
}
