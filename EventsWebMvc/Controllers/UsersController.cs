using EventsWebMvc.Models;
using EventsWebMvc.Models.ViewModels;
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
        private readonly TeamService _teamService;

        public UsersController(UserService userService, TeamService teamService)
        {
            _userService = userService;
            _teamService = teamService;
        }
        public IActionResult Index()
        {
            var list = _userService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var teams = _teamService.FindAll();
            var viewModel = new UserFormViewModel { Teams = teams };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            _userService.Insert(user);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _userService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _userService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
