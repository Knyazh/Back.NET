using Back.NET.Database.Models;

namespace Back.NET.ViewModels.Client
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public List<SlideBanner> SlideBanners { get; set; }
    }
}
