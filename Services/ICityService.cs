using DemoProject.Models;

namespace DemoProject.Services
{
    public interface ICityService
    {
        City GetCityByCityName(string cityName);
    }

}
