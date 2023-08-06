namespace Back.NET.Database.Models;

public class Slider
{
    public Slider(string title, string desciption, string offer, int order)
    {
        Title = title;
        Desciption = desciption;
        Offer = offer;
        Order = order;
    }

    public string Title { get; set; }
    public string Desciption { get; set; }
    public string Offer { get; set; }
    public int Order { get; set; }
}
