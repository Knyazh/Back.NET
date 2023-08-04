using Microsoft.AspNetCore.Mvc;

namespace Back.NET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult SecondPage()
        {
            return View();
        }
    }
}