using Microsoft.EntityFrameworkCore;
using WeatherForecast.Models;

namespace WeatherForecast.Context
{
    public class WeatherForecastContext : DbContext
    {
        public WeatherForecastContext(DbContextOptions<WeatherForecastContext> options) : base(options)
        {

        }

        public DbSet<VisitedPlace> VisitedPlaces { get; set; }
    }
}
