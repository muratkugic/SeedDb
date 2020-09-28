using SwapiBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiBackend.Services
{
    public interface IParkingSpotService
    {
        Task<List<ParkingSpot>> GetAllParkingSpots();
        Task<ParkingSpot> GetParkingSpotById(int id);
    }
}
