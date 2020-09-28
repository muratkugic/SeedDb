using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwapiBackend.Data;
using SwapiBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwapiBackend.Services
{
    public class SpacePortService : ISpacePortService
    {
        private readonly DataContext dataContext;

        public SpacePortService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<List<SpacePort>> GetAllSpacePorts()
        {
            return await dataContext.SpacePorts.ToListAsync();
        }

        public async Task<SpacePort> GetSpacePortById(int id)
        {
            return await dataContext.SpacePorts.Where(p => p.SpacePortId == id).FirstOrDefaultAsync();
        }
    }
}
