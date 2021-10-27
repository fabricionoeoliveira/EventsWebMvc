using EventsWebMvc.Models;
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
        public List<Team> FindAll()
        {
            return _context.Team.OrderBy(x => x.Name).ToList();
        }
    }
}
