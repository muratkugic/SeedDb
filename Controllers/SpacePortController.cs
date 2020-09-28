using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using SwapiBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiBackend.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SpacePortController : ControllerBase
    {
        private readonly ISpacePortService spacePortService;

        public SpacePortController(ISpacePortService spacePortService)
        {
            this.spacePortService = spacePortService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetSpacePorts()
        {
            return Ok(await spacePortService.GetAllSpacePorts());
        }
    }
}
