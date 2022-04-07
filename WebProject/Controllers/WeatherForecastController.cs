using DBContexts.DBContexts;
using Microsoft.AspNetCore.Mvc;
using WebProject.Domain.Models.WeatherTask;

namespace WebProject.Controllers
{
    //[ApiController, Route(template: "/weatherforecast")]
    public class WeatherForecastController : Controller
    {
        //    public IWeatherDayView _weatherDayView;

        //    public WeatherForecastController(IWeatherDayView weatherDayView)
        //    {
        //        _weatherDayView = weatherDayView;
        //    }
        //    [HttpGet]
        //    public IEnumerable<WeatherDayView> GetALL()
        //    {
        //        return _weatherDayView.GetProperties();
        //    }
        //}

        //public class WeatherForecastNiceNameOkay : IWeatherDayView
        //{
        //    private readonly DataContext _context;

        //    public WeatherForecastNiceNameOkay(DataContext dataContext)
        //    {
        //        _context = dataContext;
        //    }

        //    public IEnumerable<WeatherDayView> GetProperties()
        //    {
        //        return _context.WeatherDayViews.ToList();
        //    }

        public IActionResult Page()
        {
            return View();
        }
    }
}

