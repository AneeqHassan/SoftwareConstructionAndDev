using CourseEnrollmentSystem.Models;
using CourseEnrollmentSystem.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CourseEnrollmentSystem.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly DatabaseContext _context;
        public EnrollmentController(DatabaseContext context)
        {
            _context = context;
        }
        public IActionResult Enrolled(int studentId)
        {
            ViewBag.StudentId = studentId;
            ViewBag.Courses = _context.Courses.ToList();
            ViewData["Title"] = "Enroll Student";
            return View();
        }
        [HttpPost]
        public IActionResult Enrolled(int studentId, int courseId)
        {
            var enrollment = new Enrollment
            {
                StudentId = studentId,
                CourseId = courseId,
                EnrolledOn = DateTime.Now
            };
            _context.Enrollments.Add(enrollment);
            _context.SaveChanges();

            TempData["Message"] = "Enrollment Successfull!"; 
            return RedirectToAction("Details", "Student");

        }
    }
}
