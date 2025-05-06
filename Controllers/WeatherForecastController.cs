using Microsoft.AspNetCore.Mvc;
using TodoAPI.Services;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherIdService _service1;
        private readonly IWeatherIdService _service2;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherIdService service1, IWeatherIdService service2)
        {
            _logger = logger;
            _service1 = service1;
            _service2 = service2;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                First = _service1.GetOperationId(),
                Second = _service2.GetOperationId(),
                Message = "Transient"
            });
            /* private static readonly string[] Summaries = new[]
             {
                 "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
             };
             private readonly ILogger<WeatherForecastController> _logger;
             private readonly IWeatherIdService _weatherIdService;

             public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherIdService weatherIdService)
             {
                 _logger = logger;
                 _weatherIdService = weatherIdService;
             }

             [HttpGet(Name = "GetWeatherForecast")]
             public IEnumerable<object> Get()
             {
                 return Enumerable.Range(1, 5).Select(index => new
                 {
                     Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                     TemperatureC = Random.Shared.Next(-20, 55),
                     Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                     OperationId = _weatherIdService.GetOperationId()
                 })
                 .ToArray();
             }*/
        }
    }
}
