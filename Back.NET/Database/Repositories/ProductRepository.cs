using Back.NET.Database;
using Pustok.Database.Models;

namespace Pustok.Database.Repositories;

public class ProductRepository
{
    private BackDbContext _dbContext;

    public ProductRepository()
    {
        _dbContext = new BackDbContext();
    }

  

    public List<Product> GetAll()
    {
        return _dbContext.Products.ToList();
    }

    public void Insert(Product slideBanner)
    {
        _dbContext.Products.Add(slideBanner);
        _dbContext.SaveChanges();
    }

    public Product GetById(int id)
    {
        return _dbContext.Products.FirstOrDefault(b => b.Id == id);
    }

    public void RemoveById(int id)
    {

        try
        {
            var product = GetById(id);

            _dbContext.Products.Remove(product);

            _dbContext.SaveChanges();
        }
        catch (NullReferenceException e )
        {

            throw new Exception(@" not found ", e);
            //rethrow an exception
        }
       
    }

    public void Update(Product product) 
    {
        _dbContext.Products.Update(product);
        _dbContext.SaveChanges();
    }
}
