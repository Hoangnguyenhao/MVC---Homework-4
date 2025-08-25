using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class AptechController : System.Web.Mvc.Controller
    {
        public System.Web.Mvc.ActionResult Index()
        {
            ViewBag.Address = "285 Doi Can, Ba Dinh, Hanoi";
            return View();
        }

        public ActionResult StudentList()
        {
            var students = new List<string> { "John Smith", "Anna Johnson", "David Lee" };
            return View(students);
        }

        public ActionResult StudentDetail(int id)
        {
            var student = $"Student {id}: Sample Name";
            return View((object)student);
        }
    }
}
