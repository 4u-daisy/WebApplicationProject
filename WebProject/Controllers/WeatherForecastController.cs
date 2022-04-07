using Microsoft.AspNetCore.Mvc;

namespace WebProject.Controllers
{
    public class WeatherForecastController : Controller
    {
        public IActionResult Page()
        {
            return View();
        }
    }
}
