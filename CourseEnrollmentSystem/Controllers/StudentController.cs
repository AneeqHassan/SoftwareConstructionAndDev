using CourseEnrollmentSystem.Models;
using CourseEnrollmentSystem.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace CourseEnrollmentSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly DatabaseContext context;
        public StudentController(DatabaseContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            ViewData["Title"] = "Student List";
            var students = context.Students.ToList();
            return View(students);
        }

        public IActionResult Create()
        {
            ViewBag.PageTitle = "Create Student";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName")] Student student)
        {
            if (ModelState.IsValid)
            {
                context.Add(student);
                await context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Student Created Successfully!";
                return RedirectToAction(nameof(Index));
            }
            TempData["error"] = "Error!";
            return View(student);
        }

        public IActionResult Details(int id)
        {
            var student = context.Students
                .Include(e => e.Enrollments)
                .ThenInclude(c => c.Course)
                .FirstOrDefault(s => s.Id == id);
            return View(student);
        }
    }
}
