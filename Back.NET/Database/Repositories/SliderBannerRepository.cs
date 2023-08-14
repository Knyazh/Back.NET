using Back.NET.Database.Models;

namespace Back.NET.Database.Repositories;

public class SliderBannerRepository
    //persistance
{
    private static readonly List<SliderBanner> _slideBanners = new List<SliderBanner>();

    static SliderBannerRepository()
    {
        
        _slideBanners.Add(new SliderBanner("24% OFF For Today","New Plant", "Bu ne haqdadir", "Ilham", 1 ));
        _slideBanners.Add(new SliderBanner("50% OFF For weekly", "New Plant", "Bu ne haqdadir", "Selcuk", 2));
        _slideBanners.Add(new SliderBanner("NEW PALNT", "Bu ne haqdadir", "Raul", 3 ));
        _slideBanners.Add(new SliderBanner("NEW PALNT", "Bu ne haqdadir", "Serxan", 4 ));
    }

    public List<SliderBanner> GetAll()
    {
        return _slideBanners;
    }

    public void Insert(SliderBanner slideBanner)
    {
        _slideBanners.Add(slideBanner);
    }

    public SliderBanner GetById(int id)
    {
        return _slideBanners.FirstOrDefault(b => b.Id == id);
    }

    public void RemoveById(int id)
    {
        _slideBanners.RemoveAll(b => b.Id == id);
    }
}
