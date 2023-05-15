using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyDemo.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "Customer Name")]
        [Required(ErrorMessage = "Customer name is required")]
        [StringLength(70, ErrorMessage = "Can not accept more then 40 aplhabets")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Customer name should contain atlist 3 character")]
        public string CustomerName { get; set; }
    }
}
