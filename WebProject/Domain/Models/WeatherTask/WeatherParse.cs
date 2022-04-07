namespace WebProject.Domain.Models.WeatherTask
{
    public class WeatherParse
    {
        public string Name { get; set; }
        public List<Dictionary<string, string>> Weather { get; set; }
        public MainInfo Main { get; set; }
    }

    public class MainInfo
    {
        public double Temp { get; set; }
        public double Feels_like { get; set; }
        public double TempCels { get { return Math.Round((Temp - 32) / 1.80, 2); } }
        public double Feels_likeCels { get { return Math.Round((Feels_like - 32) / 1.80, 2); } }
    }

}
