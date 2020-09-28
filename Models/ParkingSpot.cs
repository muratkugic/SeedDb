namespace SwapiBackend.Models
{
    public class ParkingSpot
    {
        public int ParkingSpotId { get; set; }
        public bool IsOccupied { get; set; }
        public SpacePort SpacePort { get; set; }
    }
}