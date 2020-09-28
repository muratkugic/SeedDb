using Microsoft.AspNetCore.Mvc;
using SwapiBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiBackend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ParkingSpotController : ControllerBase
    {
        private readonly IParkingSpotService parkingSpotService;

        public ParkingSpotController(IParkingSpotService parkingSpotService)
        {
            this.parkingSpotService = parkingSpotService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllSpots()
        {
            return Ok(await parkingSpotService.GetAllParkingSpots());
        }
    }
}
