namespace modul14.Shared;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public string? Summary { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    /*
     {
            "date": "2023-10-03",
            "temperatureC": -15,
            "summary": "Warm",
            "temperatureF": 6
        }
     * */
}

