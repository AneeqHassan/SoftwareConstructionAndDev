using Microsoft.AspNetCore.Mvc;

namespace CourseEnrollmentSystem.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
