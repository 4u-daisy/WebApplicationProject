using Microsoft.AspNetCore.Mvc;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Page()
        {
            return View();
        }
    }
}
