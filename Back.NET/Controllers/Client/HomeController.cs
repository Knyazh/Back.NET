//using Microsoft.AspNetCore.Mvc;
//using Back.NET.Database.Models;
//using Back.NET.ViewModels;

//namespace Back.NET.Controllers.Client
//{
//    public class HomeController : Controller //controller
//    {
//        private readonly SlideBannerRepository _slideBannerRepository;
//        private readonly ProductRepository _productRepository;

//        public HomeController()
//        {
//            _slideBannerRepository = new SlideBannerRepository();
//            _productRepository = new ProductRepository();
//        }

//        public IActionResult Index()
//        {
//            var model = new HomeViewModel
//            {
//                SlideBanners = _slideBannerRepository
//                    .GetAll()
//                    .OrderBy(sb => sb.Order)
//                    .ToList(),

//                Products = _productRepository
//                    .GetAll()
//                    .OrderBy(p => p.Name)
//                    .ToList()
//            };

//            return View("~/Views/Client/Home/Index.cshtml", model);
//        }
//    }
//}