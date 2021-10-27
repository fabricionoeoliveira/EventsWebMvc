using EventsWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsWebMvc.Services
{
    public class UserService
    {
        private readonly EventsWebMvcContext _context;

        public UserService(EventsWebMvcContext context)
        {
            _context = context;
        }

        public List<User> FindAll()
        {
            return _context.User.ToList();
        }

        public void Insert(User obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
