﻿using System.ComponentModel.DataAnnotations;

namespace Back.NET.ViewModels.Admin.Product
{
    public abstract class BaseProductViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
    }
}
