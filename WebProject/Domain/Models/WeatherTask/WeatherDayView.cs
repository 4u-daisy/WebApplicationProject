namespace WebProject.Domain.Models.WeatherTask
{
    public class WeatherDayView
    {
        //private WeatherDay? weatherDay;
        public int Id { get; set; }
        public string? City { get; private set; }
        public string? WeatherName { get; private set; }
        public string? WeatherShortDescription { get; private set; }
        public double? WeatherTemperature { get; private set; }
        public double? WeatherTemperatureFeelsLikeCels { get; private set; }

        public WeatherDayView()
        {
            WeatherDay weatherDay = new WeatherDay();
            City = weatherDay.City;
            WeatherName = weatherDay.WeatherDayParse.Weather[0]["main"];
            WeatherShortDescription = weatherDay.WeatherDayParse.Weather[0]["description"];
            WeatherTemperature = weatherDay.WeatherDayParse.Main.TempCels;
            WeatherTemperatureFeelsLikeCels = weatherDay.WeatherDayParse.Main.Feels_likeCels;
        }

    }
}
