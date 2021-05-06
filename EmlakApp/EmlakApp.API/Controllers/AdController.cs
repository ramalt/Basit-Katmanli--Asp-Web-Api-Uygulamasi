using System;
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
        
        public IActionResult Get()
        {
            var ads = _adService.GetAds();
            return Ok(ads);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var ad = _adService.GetAdById(id);
            if (ad!=null)
            {
                return Ok(ad);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult Post(Ev ev)
        {
            //null kontrolünü [apicontroller] attribute ü yapar. Eğer geçerli değilse ev nesnesindeki
            //[required] attribute ü sayesinde işlem gerçekleşmez.
            var postedAd = _adService.CreateAd(ev);
            return Ok(postedAd);

        }
        [HttpPut]
        public IActionResult Put(Ev ev)
        {
            var updatedAd = _adService.UpdateAd(ev);
            if (_adService.GetAdById(ev.Id)!=null)
            {
                return Ok(updatedAd);
            }
            else
            {
                return NotFound(updatedAd);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_adService.GetAdById(id)!=null)
            {
                _adService.DeleteAd(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}