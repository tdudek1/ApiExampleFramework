using ApiExampleFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiExampleFramework.Controllers
{
    public class WeatherForecastController : ApiController
    {
        private static readonly string[] Summaries = new[]
{
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    

        [HttpGet]
        public IEnumerable<WeatherForecast> Index()
        {
            var rand = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rand.Next(-20, 55),
                Summary = Summaries[rand.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
