using Microsoft.AspNetCore.Mvc;

namespace controller_practise.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Just loads the Index.cshtml file directly
        }

        public IActionResult Name()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}