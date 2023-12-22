using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspireTests.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        HttpResponseMessage response = new HttpClient().GetAsync("http://localhost:5096/WeatherForecast").Result;
        Forecasts = response?.Content?.ReadFromJsonAsync<List<WeatherForecast>>().Result ?? new();
    }

    internal List<WeatherForecast> Forecasts { get; set; } = new();
    internal class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
