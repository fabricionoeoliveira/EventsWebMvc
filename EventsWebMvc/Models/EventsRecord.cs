using EventsWebMvc.Models.Enums;
using System;

namespace EventsWebMvc.Models
{
    public class EventsRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public EventStatus Status { get; set; }
        public User User { get; set; }

        public EventsRecord()
        {

        }
        public EventsRecord(int id, DateTime date, int amount, EventStatus status, User user)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            User = user;
        }
    }
}
