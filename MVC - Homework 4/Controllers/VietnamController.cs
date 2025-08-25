using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class VietnamController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Info = "Vietnam is located in Southeast Asia. People are friendly, geography is diverse from mountains to sea.";
            return View();
        }

        public IActionResult ThanhPho()
        {
            var cities = new List<string>
            {
                "Ha Noi",
                "Ho Chi Minh",
                "Da Nang",
                "Hue"
            };
            return View(cities);
        }
    }
}
