using System.ComponentModel.DataAnnotations;

namespace Back.NET.ViewModels.Admin.Product
{
    public abstract class BaseProductViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
