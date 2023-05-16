using System.ComponentModel.DataAnnotations;

namespace laba_1.Models
{
    public class Calc
    {
        [Required(ErrorMessage = "Введите число")]
        public string? operand1 { get; set; }
        [Required(ErrorMessage = "Введите число")]
        [Range(-128, 127, ErrorMessage = "Второе число должно быть от -128 до 127.")]
        public string? operand2 { get; set; }
        public string result { get; set; }
        public string calulate { get; set; }
        public string exception { get; set; }
    }
}
