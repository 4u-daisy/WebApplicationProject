using DBContexts.DBContexts;
using Microsoft.EntityFrameworkCore;
using WebProject.Domain.Models.WeatherTask;
using WebProject.Domain.Repositories.Abstract;

namespace WebProject.Domain.Repositories.EF
{
    public class EFWeatherDay : IWeatherDay
    {
        private readonly DataContext _context;

        public EFWeatherDay(DataContext context)
        {
            _context = context;
        }

        public IQueryable<WeatherDayView> GetWeatherDays()
        {
            return _context.WeatherDayViews;
        }
        
        public WeatherDayView GetTempByCityName(string city)
        {
            return _context.WeatherDayViews.FirstOrDefault(x=>x.City == city);
        }

        public void SaveWeatherDayView(WeatherDayView entity)
        {
            if(entity.Id == default)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            _context.SaveChanges();
                    }

        public void DeleteWeatherDayView(int id)
        {
            _context.WeatherDayViews.Remove( new WeatherDayView() { Id = id });
            _context.SaveChanges();
        }
    }
}
