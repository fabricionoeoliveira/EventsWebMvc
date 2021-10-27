using EventsWebMvc.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsWebMvc.Controllers
{
    public class UsersController : Controller
    {

        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            var list = _userService.FindAll();
            return View(list);
        }
    }
}
