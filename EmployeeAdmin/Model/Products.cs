using System.ComponentModel.DataAnnotations;

namespace EmployeeAdmin.Model
{
    public class Products
    {
        public required int Id { get; set; }
        [StringLength(50, MinimumLength = 2)]        
        public required string Name { get; set; }
        [Required]
        [Range(0.01, double.MaxValue,ErrorMessage ="price must be greater then 0")]
        public decimal Price { get; set; }        
        public string Category { get; set; }
    }
}
