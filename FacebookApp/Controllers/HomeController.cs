using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FacebookApp.Models;
using FacebookApp.Business.Contracts;
using FacebookApp.Business;
using System.Dynamic;
using FacebookApp.Data.Models;
using FacebookApp.Services.Contracts;

namespace FacebookApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            this._userService = userService;
        }

        public IActionResult Index()
        {
            //var users = _UoW.UserRepository.GetAll();
            //var usersVm = _mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(users);
            //var users = _userService.GetAllUsers();
            
            return View();
        }

        public IActionResult Profile()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
