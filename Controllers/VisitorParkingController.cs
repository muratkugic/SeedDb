using Microsoft.AspNetCore.Mvc;
using SwapiBackend.Models;
using SwapiBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SwapiBackend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class VisitorParkingController : ControllerBase
    {
        private readonly IVisitorParkingService visitorParking;

        public VisitorParkingController(IVisitorParkingService visitorParking)
        {
            this.visitorParking = visitorParking;
        }

        [HttpPost]
        public async Task<IActionResult> AddVisitorParking()
        {
            return Ok(await visitorParking.AddVisitorParking());
        }
    }
}
