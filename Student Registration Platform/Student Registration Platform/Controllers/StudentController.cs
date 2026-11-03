using Microsoft.AspNetCore.Mvc;
using StudentRegistrationApp.Models;

namespace StudentRegistrationApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.Name) || student.Age < 18)
            {
                ViewBag.Error = student.Age < 18
                    ? $"Sorry {student.Name}, you are only {student.Age} years old. You must be at least 18 to register."
                    : "Name cannot be empty.";
                return View(student);
            }

            student.MatricNumber = MatricNumber.Generate();
            return View("Success", student);
        }
    }
}
