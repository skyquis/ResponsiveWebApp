using Microsoft.AspNetCore.Mvc;
using ResponsiveWebApp.Models;

namespace ResponsiveWebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [Route("[area]/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[area]/About")]
        public IActionResult About()
        {
            return Content("Home controller for Admin, About action");
        }


        [HttpPost]
        public IActionResult CalculateAge(User user)
        {
            if (ModelState.IsValid)
            {
                int age = user.AgeThisYear();
                ViewBag.Result = $"Hi, Admin {user.Name}! You will be {age} years old on December 31st of this year.";

            }
            return View("Index");
        }

        public IActionResult ClearInputs()
        {
            ModelState.Clear();
            return View("Index");
        }

        public IActionResult CustomRoute()
        {
            return Content("Page using Custom Route");
        }
    }
}
