using Microsoft.AspNetCore.Mvc;

namespace Back.NET.Controllers.Admin;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View("~/Views/Admin/Dashboard/Index.cshtml");
    }
}
