using Back.NET.Database.Models;

namespace Back.NET.Database.Repositories;

public class BookRepository
{
    private static readonly List<Book> _books = new List<Book>();

    static BookRepository()
    {
        _books.Add(new Book("Salam Knyaz", "Bu ne haqdadir", "Ilham", 200, DateTime.Now));
        _books.Add(new Book("Salam Ferid", "Bu ne haqdadir", "Selcuk", 150, DateTime.Now));
        _books.Add(new Book("Salam Azer", "Bu ne haqdadir", "Raul", 300, DateTime.Now));
    }

    public List<Book> GetAll()
    {
        return _books;
    }

    public void Insert(Book book)
    {
        _books.Add(book);
    }
}
