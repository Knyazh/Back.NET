using Microsoft.AspNetCore.Mvc;

namespace Back.NET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult About()
        {
            return View("~Views/Index.cshtml");
        }
        public IActionResult SecondPage()
        {
            return View("~Views/SecondPage.cshtml");
        }
    }
}