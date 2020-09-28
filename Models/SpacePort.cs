using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiBackend.Models
{
    public class SpacePort
    {
        public int SpacePortId { get; set; }
        public string Name { get; set; }
        public List<ParkingSpot> ParkingSpots { get; set; }
    }
}
