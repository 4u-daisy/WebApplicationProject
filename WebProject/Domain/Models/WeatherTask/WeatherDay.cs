using Newtonsoft.Json;
using System.Net;

namespace WebProject.Domain.Models.WeatherTask
{
    public class WeatherDay
    {
        public string? City { get; set; }
        public string? TemperatureScale { get; set; }

        readonly private string startString = "https://api.openweathermap.org/data/2.5/weather?q=";
        readonly private string key = "&units=imperial&appid=68c8fa9c9ab7cc268f898581bf912260";
        private string? url;

        public WeatherParse? WeatherDayParse { get; set; }
        
        private void Parsing()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            WeatherDayParse = JsonConvert.DeserializeObject<WeatherParse>(reader.ReadToEnd());

        }

        public WeatherDay()
        {
            TemperatureScale = "Celsius";
            url = startString + City + key;
            Parsing();
        }

        public WeatherDay(string city)
        {   // : base() ? 
            TemperatureScale = "Celsius";
            City = city;
            url = startString + City + key;
            Parsing();
        }

    }
}
