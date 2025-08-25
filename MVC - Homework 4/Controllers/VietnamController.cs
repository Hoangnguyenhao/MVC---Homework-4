using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
    public class VietnamController : Controller
    {
        public ActionResult Cities()
        {
            var cities = new List<string> { "Hanoi", "Ho Chi Minh City", "Da Nang", "Hue" };
            return View(cities);
        }
    }
}
