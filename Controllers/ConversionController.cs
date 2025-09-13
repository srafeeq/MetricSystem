using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class ConversionController : Controller
    {
        [HttpGet]
        public IActionResult Fahrenheit()
        {
            return View(new FahrenheitModel());
        }

        [HttpPost]
        public IActionResult Fahrenheit(FahrenheitModel model)
        {
            if (ModelState.IsValid)
            {
                model.Celsius = (model.Fahrenheit - 32) * 5.0 / 9.0;
            }
            return View(model);
        }

        public IActionResult Inch()
        {
            return View();
        }

        public IActionResult Pint()
        {
            return View();
        }

        public IActionResult Yard()
        {
            return View();
        }
    }
}
