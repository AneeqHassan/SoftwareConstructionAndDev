using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using CourseEnrollmentSystem.Models;

namespace CourseEnrollmentSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly DatabaseContext _context;
        public StudentController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Student List";
            var students = _context.Students.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            ViewBag.PageTitle = "Create Student";
            return View();
        }
    }
}
