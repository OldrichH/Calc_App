using Calculator_App.Data;
using System.ComponentModel.DataAnnotations;

namespace Calculator_App.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "First value is required")]
        public double ValueA { get; set; }
        [Required(ErrorMessage = "Second value is required")]
        public double ValueB { get; set; }
        [Required(ErrorMessage = "Operation is required")]
        public string Operation { get; set; }
        public bool ReturnInteger { get; set; }
    }
}
