using System.Collections.Generic;
using EmlakApp.Entities;

namespace EmlakApp.DataAccess.Abstract
{
    public interface IRepository
    {
        List<Ev> GetAllAd();
        Ev GetAdById(int id);
        Ev CreateAd(Ev ev);
        Ev UpdateAd(Ev ev);
        void DeleteAd(int id);
    }
}