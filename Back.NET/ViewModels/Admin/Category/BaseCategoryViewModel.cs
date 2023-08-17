using System.ComponentModel.DataAnnotations;

namespace Back.NET.ViewModels.Admin.Category;

public abstract class BaseCategoryViewModel
{
    [Required]
    [StringLength(200, MinimumLength = 3)]
    public string Name { get; set; }
}
