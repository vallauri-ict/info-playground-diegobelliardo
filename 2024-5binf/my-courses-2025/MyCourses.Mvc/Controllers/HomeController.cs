using Microsoft.AspNetCore.Mvc;

namespace MyCourses.Mvc.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
