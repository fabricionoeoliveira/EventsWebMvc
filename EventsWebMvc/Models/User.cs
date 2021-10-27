using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsWebMvc.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Sector { get; set; }
        public string RegionCode { get; set; }
        public string Phone { get; set; }
        public Team Team { get; set; }
        public ICollection<EventsRecord> Events { get; set; } = new List<EventsRecord>();

        public User()
        {

        }

        public User(int id, string name, string nickName, string sector, string regionCode, string phone, Team team)
        {
            Id = id;
            Name = name;
            NickName = nickName;
            Sector = sector;
            RegionCode = regionCode;
            Phone = phone;
            Team = team;
        }

        public void AddEvents(EventsRecord er)
        {
            Events.Add(er);
        }

        public void RemoveEvents(EventsRecord er)
        {
            Events.Remove(er);
        }

        public int TotalEvents(DateTime initial, DateTime final)
        {
            return Events.Where(er => er.Date >= initial && er.Date <= final).Sum(er => er.Amount);
        }



    }
}
