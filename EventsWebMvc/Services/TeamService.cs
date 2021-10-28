using EventsWebMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsWebMvc.Services
{
    public class TeamService
    {
        private readonly EventsWebMvcContext _context;

        public TeamService(EventsWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Team>> FindAllAsync()
        {
            return await _context.Team.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
