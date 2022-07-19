using Newtonsoft.Json;
using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public class PlacesService
    {
        public async Task<List<Place>?> GetPlaces()
        {
            using (HttpClient client = new HttpClient())
            {
                string jsonString = await client.GetStringAsync("https://api.meteo.lt/v1/places");
                return JsonConvert.DeserializeObject<List<Place>>(jsonString);
            }
        }

        public async Task<Forecast?> GetPlaceForecast(string placeCode)
        {
            using (HttpClient client = new HttpClient())
            {
                string jsonString = await client.GetStringAsync($"https://api.meteo.lt/v1/places/{placeCode}/forecasts/long-term");
                return JsonConvert.DeserializeObject<Forecast>(jsonString);
            }
        }
    }
}
