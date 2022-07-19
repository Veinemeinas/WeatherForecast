using Newtonsoft.Json;

public class Forecast
{
    [JsonProperty("place")]
    public PlaceInfo PlaceInfo { get; set; }

    [JsonProperty("forecastType")]
    public string ForecastType { get; set; }

    [JsonProperty("forecastCreationTimeUtc")]
    public string ForecastCreationTimeUtc { get; set; }

    [JsonProperty("forecastTimestamps")]
    public List<ForecastTimestamp> ForecastTimestamps { get; set; }
}

public class PlaceInfo
{
    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("administrativeDivision")]
    public string AdministrativeDivision { get; set; }

    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("countryCode")]
    public string CountryCode { get; set; }

    [JsonProperty("coordinates")]
    public Coordinates Coordinates { get; set; }
}

public class ForecastTimestamp
{
    [JsonProperty("forecastTimeUtc")]
    public string ForecastTimeUtc { get; set; }

    [JsonProperty("airTemperature")]
    public double AirTemperature { get; set; }

    [JsonProperty("windSpeed")]
    public int WindSpeed { get; set; }

    [JsonProperty("windGust")]
    public int WindGust { get; set; }

    [JsonProperty("windDirection")]
    public int WindDirection { get; set; }

    [JsonProperty("cloudCover")]
    public int CloudCover { get; set; }

    [JsonProperty("seaLevelPressure")]
    public int SeaLevelPressure { get; set; }

    [JsonProperty("relativeHumidity")]
    public int RelativeHumidity { get; set; }

    [JsonProperty("totalPrecipitation")]
    public double TotalPrecipitation { get; set; }

    [JsonProperty("conditionCode")]
    public string ConditionCode { get; set; }
}

public class Coordinates
{
    [JsonProperty("latitude")]
    public double Latitude { get; set; }

    [JsonProperty("longitude")]
    public double Longitude { get; set; }
}
