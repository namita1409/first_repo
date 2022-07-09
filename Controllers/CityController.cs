using DemoProject.Models;
using DemoProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoProject.Controllers
{
    [ApiController]
    [Route("api/v1/city")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;

        public CityController(ICityService cityService) {

            _cityService = cityService;
        }

        [HttpGet("{cityName}")]
        public ActionResult<City> GetCityByCityName(string cityName) {

            return _cityService.GetCityByCityName(cityName);
            
        }


        


    }
}
