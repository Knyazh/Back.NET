using Back.NET.Database.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Back.NET.Controllers.Client
{
    public class HomeController : Controller
    {
        private readonly SliderBannerRepository _sliderBannerRepository;
        public HomeController()
        {
            _sliderBannerRepository = new SliderBannerRepository();
        }
        public IActionResult Index()
        {
            var slidebanner = _sliderBannerRepository.GetAll();
            return View("~/Views/Pronia/Index.cshtml", slidebanner);
        }
      
    }
}