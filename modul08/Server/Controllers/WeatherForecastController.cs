using Microsoft.AspNetCore.Mvc;
using modul08.Shared;

namespace modul08.Server.Controllers;

[ApiController]
[Route("api/vejr")]
public class WeatherForecastController : ControllerBase
{

    private static readonly string[] Locations = new[]
    {
    "København", "Aarhus", "Odense", "Aalborg", "Esbjerg", "Randers", "Kolding", "Horsens", "Vejle", "Roskilde"
    };

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    // Tilføjet for, at den ikke bare giver knaste random summary ting
    private string GetSummary(int temperatureC)
    {
        if (temperatureC <= -10) return "Freezing";
        if (temperatureC <= 0) return "Bracing";
        if (temperatureC <= 10) return "Chilly";
        if (temperatureC <= 15) return "Cool";
        if (temperatureC <= 20) return "Mild";
        if (temperatureC <= 25) return "Warm";
        if (temperatureC <= 30) return "Balmy";
        if (temperatureC <= 35) return "Hot";
        if (temperatureC <= 40) return "Sweltering";
        return "Scorching";
    }

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get(int count = 10, int minTemp = -20, int maxTemp = 55)
    {
        var forecasts = new List<WeatherForecast>();
        while (forecasts.Count < count)
        {
            var temp = Random.Shared.Next(-20, 55);
            if (temp >= minTemp && temp <= maxTemp)
            {
                forecasts.Add(new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(forecasts.Count + 1)),
                    TemperatureC = temp,
                    Location = Locations[Random.Shared.Next(Locations.Length)],
                    Summary = GetSummary(temp)
                });
            }
        }
        return forecasts.ToArray();
    }
}
