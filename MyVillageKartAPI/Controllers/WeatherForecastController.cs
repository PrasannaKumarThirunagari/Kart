using Microsoft.AspNetCore.Mvc;
//using MyVillageKartAPI.MyVillageKartDataAccess;

namespace MyVillageKartAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        //private readonly IUserDataAccess _userDataAccess;

        public WeatherForecastController()
        {
            //_userDataAccess = userDataAccess;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<string> Get()
        {
            return Summaries.ToList();
        }
    }
}