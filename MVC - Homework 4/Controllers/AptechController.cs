using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MvcApp.Controllers
{
    public class AptechController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Address = "285 Doi Can, Ba Dinh, Ha Noi";
            return View();
        }

        public IActionResult StudentList()
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen Van A" },
                new Student { Id = 2, Name = "Tran Thi B" },
                new Student { Id = 3, Name = "Le Van C" }
            };
            return View(students);
        }

        public IActionResult StudentDetail(int? id)
        {
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyen Van A" },
                new Student { Id = 2, Name = "Tran Thi B" },
                new Student { Id = 3, Name = "Le Van C" }
            };
            var student = students.FirstOrDefault(s => s.Id == id);
            return View(student);
        }
    }
}