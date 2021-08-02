using GoWMS.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Controllers
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Scorching1", "Scorching2", "Scorching3", "Scorching4", "Scorching5", "Scorching6", "Scorching7", "Scorching8", "Scorching9", "Scorching10", "Scorching11", "Scorching12", "Scorching13", "Scorching14", "Scorching15", "Scorching16", "Scorching17", "Scorching18", "Scorching19", "Scorching20", "Scorching21", "Scorching22", "Scorching23", "Scorching24", "Scorching25"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 500).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}
