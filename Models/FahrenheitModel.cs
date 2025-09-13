using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class FahrenheitModel
    {
        [Required(ErrorMessage = "Fahrenheit value is required")]
        [Range(-100, 200, ErrorMessage = "Enter a value between -100 and 200 Fahrenheit")]
        public double Fahrenheit { get; set; }

        public double? Celsius { get; set; }
    }
}
