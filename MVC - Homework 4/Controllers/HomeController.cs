using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Info = "Vietnam is a country in Southeast Asia, known for its beautiful landscapes, friendly people, and long coastline.";
            return View();
        }
    }
}
