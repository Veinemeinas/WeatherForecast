using Microsoft.EntityFrameworkCore;
using WeatherForecast.Context;
using WeatherForecast.Models;

namespace WeatherForecast.Repositories
{
    public class VisitedPlaceRepository
    {
        private readonly WeatherForecastContext _context;
        public VisitedPlaceRepository(WeatherForecastContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VisitedPlace>> GetVisitedPlacesAsync()
        {
            var places = await _context.VisitedPlaces.ToListAsync();
            return places.OrderByDescending(vp => vp.VisitCounter).ToList();
        }

        public async Task<VisitedPlace> GetVisitedPlaceAsync(string code)
        {
            return await _context.VisitedPlaces.FirstOrDefaultAsync(p => p.Code == code);
        }

        public async Task AddVisitedPlace(string code)
        {
            var place = await GetVisitedPlaceAsync(code);
            if (place == null)
            {
                VisitedPlace visitedPlace = new VisitedPlace() { Code = code, VisitCounter = 1 };
                await _context.VisitedPlaces.AddAsync(visitedPlace);
            }
            else
            {
                place.VisitCounter++;
            }

            await _context.SaveChangesAsync();
        }
    }
}
