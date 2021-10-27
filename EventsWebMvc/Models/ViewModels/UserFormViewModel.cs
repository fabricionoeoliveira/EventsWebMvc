using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsWebMvc.Models.ViewModels
{
    public class UserFormViewModel
    {
        public  User User { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
