using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsWebMvc.Models;
using EventsWebMvc.Models.Enums;

namespace EventsWebMvc.Data
{
    public class SeedingService
    {
        private readonly EventsWebMvcContext _context;

        public SeedingService(EventsWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Team.Any() ||
                _context.User.Any() ||
                _context.EventsRecord.Any())
            {
                return; // DB has been seeded
            }

            Team t1 = new Team(1, "Administration");
            Team t2 = new Team(2, "Human Resources");
            Team t3 = new Team(3, "Design");
            Team t4 = new Team(4, "Development");

            User u1 = new User(1, "José Primeiro", "Jose1", "Dev", "16", "123456", t1);
            User u2 = new User(2, "José Segundo", "Jose2", "Adm", "16", "123456", t2);
            User u3 = new User(3, "José Terceiro", "Jose3", "Design", "16", "123456", t3);
            User u4 = new User(4, "José Quarto", "Jose4", "Dev", "16", "123456", t4);

            EventsRecord e1 = new EventsRecord(1, "Party 1", new DateTime(2021, 11, 01), 1, EventStatus.Inscription , u1);
            EventsRecord e2 = new EventsRecord(2, "Party 2", new DateTime(2021, 12, 01), 1, EventStatus.Inscription , u2);
            EventsRecord e3 = new EventsRecord(3, "Party 3", new DateTime(2022, 01, 01), 1, EventStatus.Inscription , u3);
            EventsRecord e4 = new EventsRecord(4, "Party 4", new DateTime(2022, 02, 01), 1, EventStatus.Inscription , u4);
 
            _context.Team.AddRange(t1, t2, t3, t4);

            _context.User.AddRange(u1, u2, u3, u4);

            _context.EventsRecord.AddRange(e1, e2, e3, e4);

            _context.SaveChanges();
        }
    }
}