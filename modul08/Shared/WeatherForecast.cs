namespace modul08.Shared;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public string? Summary { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Location { get; set; } // Tilføjet denne linje for "Location"-attributten
}