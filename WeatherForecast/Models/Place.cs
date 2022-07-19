using Newtonsoft.Json;

namespace WeatherForecast.Models
{
    public class Place
    {
        [JsonProperty("code")]
        public string Code { get; set; } = String.Empty;
        [JsonProperty("name")]
        public string Name { get; set; } = String.Empty;
        [JsonProperty("administrativeDivision")]
        public string AdministrativeDivision { get; set; } = String.Empty;
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; } = String.Empty;
    }
}
