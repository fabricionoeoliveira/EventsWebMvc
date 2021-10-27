using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EventsWebMvc.Models
{
    public class EventsWebMvcContext : DbContext
    {
        public EventsWebMvcContext (DbContextOptions<EventsWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Team> Team { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<EventsRecord> EventsRecord { get; set; }
    }
}
