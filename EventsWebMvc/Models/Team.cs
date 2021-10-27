using System;
using System.Collections.Generic;
using System.Linq;

namespace EventsWebMvc.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; } = new List<User>();

        public Team()
        {

        }

        public Team(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public int TotalEvents(DateTime initial, DateTime final)
        {
            return Users.Sum(user => user.TotalEvents(initial, final));
        }
    }
}
