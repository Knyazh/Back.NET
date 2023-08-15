namespace Pustok.Database.Models;

public class Product
{
   

    public Product(string name, string decription, string color, string size, decimal price)
    {
        Name = name;
        Description = decription;
        Color = color;
        Size = size;
        Price = price;
    }
    public Product() {}


    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }

}
