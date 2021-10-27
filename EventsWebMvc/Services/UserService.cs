using EventsWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        public User FindById(int id)
        {
            return _context.User.Include(obj =>obj.Team).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.User.Find(id);
            _context.User.Remove(obj);
            _context.SaveChanges();
        }
    }
}
