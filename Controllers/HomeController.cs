using Microsoft.AspNetCore.Mvc;
using ResponsiveWebApp;
using ResponsiveWebApp.Models;

namespace ResponsiveWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateAge(User user)
        {
            if (ModelState.IsValid)
            {
                int age = user.AgeThisYear();
                ViewBag.Result = $"Hi, {user.Name}! You will be {age} years old on December 31st of this year.";

            }
            return View("Index");
        }

        public IActionResult ClearInputs()
        {
            ModelState.Clear();
            return View("Index");
        }
    }
}
