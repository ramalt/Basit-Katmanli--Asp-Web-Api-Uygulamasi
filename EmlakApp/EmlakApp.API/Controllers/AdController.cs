using System.Collections.Generic;
using EmlakApp.Business.Abstract;
using EmlakApp.Business.Concrete;
using EmlakApp.Entities;
using Microsoft.AspNetCore.Mvc;


namespace EmlakApp.API.Controllers
{
    [Route("API/[Controller]")]
    [ApiController]
    public class AdController : ControllerBase
    {
        private readonly IAdService _adService;

        public AdController()
        {
            _adService = new AdManager();
        }
        [HttpGet]
        public List<Ev> Get()
        {
            return _adService.GetAds();
        }
        [HttpGet("{id}")]
        public Ev Get(int id)
        {
            return _adService.GetAdById(id);
        }
        [HttpPost]
        public Ev Post(Ev ev)
        {
            return _adService.CreateAd(ev);
        }
        [HttpPut]
        public Ev Put(Ev ev)
        {
            return _adService.UpdateAd(ev);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _adService.DeleteAd(id);
        }
    }
}