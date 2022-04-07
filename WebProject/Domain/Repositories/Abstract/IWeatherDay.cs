using WebProject.Domain.Models.WeatherTask;

namespace WebProject.Domain.Repositories.Abstract
{
    public interface IWeatherDay
    {
        IQueryable<WeatherDayView> GetWeatherDays();
        WeatherDayView GetTempByCityName(string city);
        void SaveWeatherDayView(WeatherDayView entity);
        void DeleteWeatherDayView(int id);
    }
}
