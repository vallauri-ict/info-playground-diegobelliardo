using Microsoft.AspNetCore.Mvc;
using MyCourses.Models.Services.Application;
using MyCourses.Models.ViewModels;

namespace MyCourses.Mvc.Controllers
{
    public class CoursesController : Controller
    {
        private ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            List<CourseViewModel> model = courseService.GetCourses();
            ViewBag.Title = "Catalogo dei corsi";
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            CourseDetailViewModel model = courseService.GetCourse(id);
            ViewBag.Title = model.Title;
            return View(model);
        }
    }
}