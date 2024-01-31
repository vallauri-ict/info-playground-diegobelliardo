using Microsoft.AspNetCore.Mvc;

namespace MyCourses.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "MyCourses - Homepage";
            return View();
        }
    }
}