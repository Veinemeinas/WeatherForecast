namespace WeatherForecast.Models
{
    public class VisitedPlace
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Code { get; set; }
        public int VisitCounter { get; set; }
    }
}
