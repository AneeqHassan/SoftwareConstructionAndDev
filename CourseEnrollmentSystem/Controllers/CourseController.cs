using Microsoft.AspNetCore.Mvc;

namespace CourseEnrollmentSystem.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
