using Back.NET.Database.Models;

namespace Back.NET.Database.Repositories;

public class BookRepository
{
    private static readonly List<Product> _books = new List<Product>();

    static BookRepository()
    {
        //_books.Add(new Product("Salam Knyaz", "Bu ne haqdadir", "Ilham", 200, DateTime.Now));
        //_books.Add(new Product("Salam Ferid", "Bu ne haqdadir", "Selcuk", 150, DateTime.Now));
        //_books.Add(new Product("Salam Azer", "Bu ne haqdadir", "Raul", 300, DateTime.Now));
    }

    public List<Product> GetAll()
    {
        return _books;
    }

    public void Insert(Product book)
    {
        _books.Add(book);
    }

    public Product GetById(int id)
    {
        return _books.FirstOrDefault(b => b.Id == id);
    }

    public void RemoveById(int id)
    {
        _books.RemoveAll(b => b.Id == id);
    }
}
