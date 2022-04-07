using Microsoft.AspNetCore.Mvc;

namespace WebProject.Controllers
{
    public class RootController : Controller
    {
        public IActionResult Page()
        {
            return View();
        }
    }
}
