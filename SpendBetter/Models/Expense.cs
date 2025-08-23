using System.ComponentModel.DataAnnotations;

namespace SpendBetter.Models
{
    public class Expense
    {
        public int id {  get; set; }
        public int Value { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
