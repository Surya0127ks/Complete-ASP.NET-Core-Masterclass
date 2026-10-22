using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //passing data from controller to view
            ViewBag.Title = "Index Page"; 
            
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Title = "About page";
            return View();
        }
    }
}
