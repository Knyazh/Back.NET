using Back.NET.Database;
using Back.NET.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Back.NET.Database.Models;
using System.CodeDom;
using System.Data.Entity;

namespace Back.NET.Controllers;
[Route("Admin/product")]
public class ProductController : Controller
{
    private readonly BackDbContext _backDbContext;
    public ProductController()
    {
        _backDbContext = new BackDbContext();
    }


    #region Index
    [HttpGet]
    public IActionResult Index()
    {
        var products = _backDbContext.Products.ToList();
        var productViewModels = products
        .Select(p => new ProductListItemViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Color = p.Color,
            Size = p.Size,
            Price = p.Price
        })
        .ToList();

        var result = View("~/Views/Admin/Product/Index.cshtml", productViewModels);
        _backDbContext.Dispose();
        return result;
    }
    #endregion

    #region Add

    [HttpGet("Add")]
    public IActionResult Add()
    {
        return View("~/Views/Admin/Product/Add.cshtml");
    }

    [HttpPost]
    public IActionResult Add(ProductAddViewModel model)
    {
        var product = new Product(
            model.Name,
            model.Description,
            model.Color,
            model.Size,
        model.Price);

        _backDbContext.Products.Add(product);
        _backDbContext.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    #endregion

    #region Update

    [HttpGet("{id}/Update")]
    public IActionResult Update(int id)
    {
        var product = _backDbContext.Products.FirstOrDefault(p => p.Id == id);
        if (product == null) ModelState.AddModelError(string.Empty, "Product not found");
        
        var model = new ProductUpdateViewModel
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Color = product.Color,
            Size = product.Size,
            Price = product.Price
        };



        return View("~/Views/Admin/Product/Update.cshtml");
    }

    [HttpPost("{id}/Update")]
    public IActionResult Update(ProductUpdateViewModel model)
    {
        var product = _backDbContext.Products.FirstOrDefault(p => p.Id == model.Id);
        if (product == null) return NotFound();

        product.Name = model.Name;
        product.Description = model.Description;
        product.Color = model.Color;
        product.Price = model.Price;

        _backDbContext.Products.Update(product);
        _backDbContext.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    #endregion

    #region Delete

    [HttpPost("Delete")]
    public IActionResult Delete(int id)
    {
        var product = _backDbContext.Products.FirstOrDefault(p => p.Id == id);
        if (product == null) return NotFound();


        _backDbContext.Products.Remove(product);
        _backDbContext.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    #endregion


    //Destructor or Finalizer
    ~ProductController()
    {
        _backDbContext.Dispose();
    }
}