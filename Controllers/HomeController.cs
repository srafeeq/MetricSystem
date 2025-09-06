using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new MetricModel());  
        }

        [HttpPost]
        public IActionResult Index(MetricModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); 
            }

            return View(model); 
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}