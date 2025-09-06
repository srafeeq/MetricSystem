using System.ComponentModel.DataAnnotations;

namespace MetricSystem.Models
{
    public class MetricModel
    {
        [Required(ErrorMessage = "Please enter Fahrenheit value.")]
        public decimal? Fahrenheit { get; set; }

        public decimal? Celsius => Fahrenheit.HasValue
            ? (Fahrenheit.Value - 32) * 5 / 9
            : null;
    }
}