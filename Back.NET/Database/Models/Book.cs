namespace Back.NET.Database.Models;

public class Book
{
    private static int _idCounter = 1;

    public Book( string title, string description, string author, decimal price, DateTime publishDate)
    {
        Id = _idCounter++;
        Title = title;
        Description = description;
        Author = author;
        Price = price;
        PublishDate = publishDate;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public DateTime PublishDate { get; set; }
}

