using System.Collections.Generic;
using EmlakApp.Entities;

namespace EmlakApp.Business.Abstract
{
    public interface IAdService
    {
        List<Ev> GetAds();
        Ev GetAdById(int evId);
        Ev CreateAd(Ev ev);
        Ev UpdateAd(Ev ev);
        void DeleteAd(int evId);
    }
}
