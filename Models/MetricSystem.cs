using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class FahrenheitModel
    {
        [Required(ErrorMessage = "Fahrenheit Value is required")]
        [Range(-100, 200, ErrorMessage = "Enter a value between -100 and 200 Fahrenheit")]
        [Display(Name = "Fahrenheit Value")]  
        public double Fahrenheit { get; set; }

        [Display(Name = "Celsius Value")]  
        public double? Celsius { get; set; } 
    }
}
