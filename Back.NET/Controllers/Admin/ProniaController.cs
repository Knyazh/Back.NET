using Microsoft.AspNetCore.Mvc;

namespace Back.NET.Controllers
{
    public class ProniaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
