using Back.NET.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Database.Models;
using Pustok.ViewModels;
using System.Data.Entity;

namespace Pustok.Controllers;

public class ProductController : Controller
{

    public ProductController()
    {

    }

    [HttpGet]
    public IActionResult Index()
    {
        using var dbContext = new BackDbContext();

        var products = dbContext.Products.ToList();
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
        dbContext.Dispose();
        return result;




    }

    #region Add

    [HttpGet]
    public IActionResult Add()
    {
        return View("~/Views/Admin/Product/Add.cshtml");
    }

    [HttpPost]
    public IActionResult Add(ProductAddViewModel model)
    {
        var dbContext = new BackDbContext();
        var product = new Product(
            model.Name,
            model.Description,
            model.Color,
            model.Size,
        model.Price);

        dbContext.Products.Add(product);
        dbContext.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    #endregion

    #region Update

    [HttpGet]
    public IActionResult Update(int id)
    {
        var dbContext = new BackDbContext();
        var product = dbContext.Products.FirstOrDefault(p => p.Id == id);
        if (product == null) return NotFound();

        var model = new ProductUpdateViewModel
        {
            Id = product.Id,
            Name = product.Name,
            Description = product.Description,
            Color = product.Color,
            Size = product.Size,
            Price = product.Price
        };



        return View("~/Views/Admin/Product/Update.cshtml", model);
    }

    [HttpPost]
    public IActionResult Update(ProductUpdateViewModel model)
    {
        var dbContext = new BackDbContext();
        var product = dbContext.Products.FirstOrDefault(p => p.Id == model.Id);
        if (product == null) return NotFound();

        product.Name = model.Name;
        product.Description = model.Description;
        product.Color = model.Color;
        product.Price = model.Price;

        dbContext.Products.Update(product);
        dbContext.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    #endregion

    #region Delete

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var dbContext = new BackDbContext();
        var product = dbContext.Products.FirstOrDefault(p => p.Id == id);
        if (product == null) return NotFound();


        dbContext.Products.Remove(product);
        dbContext.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    #endregion
}