using LearningProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
           var students= StudentRepo.GetAllStudents();
            return View(students);
        }

        public IActionResult Details(int id)
        {
            var std= StudentRepo.GetAllStudents().FirstOrDefault(d=>d.Id==id);
            return View(std);
        }
    }
}
