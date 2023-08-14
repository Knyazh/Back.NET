namespace Back.NET.Database.Models;

public class SliderBanner
{
    private static int _idCounter = 1;

    public SliderBanner(string title, string desciption,string redirectionUrl, int order) 
      : this(null, title, desciption,redirectionUrl,order) { }

    public SliderBanner( string offer, string title, string desciption, string redirectionUrl, int order)
    {
        Id = _idCounter++;
        Offer = offer;
        Title = title;
        Desciption = desciption;
        RedirectionUrl = redirectionUrl;
        Order = order;
    }

    public int Id { get; set; }
    public string Offer { get; set; }
    public string Title { get; set; }
    public string Desciption { get; set; }
    public string RedirectionUrl { get; set; }
    public int Order { get; set; }
}
