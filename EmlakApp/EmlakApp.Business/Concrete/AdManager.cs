using System.Collections.Generic;
using EmlakApp.Business.Abstract;
using EmlakApp.DataAccess.Abstract;
using EmlakApp.DataAccess.Concrete;
using EmlakApp.Entities;

namespace EmlakApp.Business.Concrete
{
    public class AdManager : IAdService
    {
        private  IRepository _repository;

        public AdManager()
        {
            _repository = new Repository();
        }
        public List<Ev> GetAds()
        {
            return _repository.GetAllAd();
        }

        public Ev GetAdById(int evId)
        {
            return _repository.GetAdById(evId);
        }

        public Ev CreateAd(Ev ev)
        {
            return _repository.CreateAd(ev);
        }

        public Ev UpdateAd(Ev ev)
        {
            return _repository.UpdateAd(ev);
        }

        public void DeleteAd(int evId)
        {
            _repository.DeleteAd(evId);
        }
    }
}
