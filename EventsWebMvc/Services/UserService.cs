using EventsWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventsWebMvc.Services.Exceptions;

namespace EventsWebMvc.Services
{
    public class UserService
    {
        private readonly EventsWebMvcContext _context;

        public UserService(EventsWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<User>> FindAllAsync()
        {
            return await _context.User.ToListAsync();
        }

        public async Task InsertAsync(User obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<User> FindByIdAsync(int id)
        {
            return await _context.User.Include(obj =>obj.Team).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.User.FindAsync(id);
            _context.User.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User obj)
        {
            bool hasAny = await _context.User.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
