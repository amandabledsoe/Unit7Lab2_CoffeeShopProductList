using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using U7L2.Models;

namespace U7L2.Controllers
{
    public class HomeController : Controller
    {
        CoffeeUser coffeeUser = new CoffeeUser();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CreateCoffeeUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCoffeeUser(CoffeeUser newCoffeeUser)
        {
            if (ModelState.IsValid)
            {
                coffeeUser = newCoffeeUser;
                return RedirectToAction("DisplayCoffeeUser", "Home", coffeeUser);
            }
            else
            {
                return View(newCoffeeUser);
            }
        }
        [HttpPost]
        public IActionResult DisplayCoffeeUser(string firstName, string lastName, string email, string password)
        {
            coffeeUser.FirstName = firstName;
            coffeeUser.LastName = lastName;
            coffeeUser.Email = email;
            coffeeUser.Password = password;
            return View(coffeeUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}