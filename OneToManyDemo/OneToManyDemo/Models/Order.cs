using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyDemo.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Display(Name = "Item Name")]
        [Required(ErrorMessage = "Item name is required")]
        [StringLength(70, ErrorMessage = "Can not accept more then 40 aplhabets")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Item name should contain atlist 3 character")]
        public string ItemName { get; set; }
        [Display(Name = "Item Price")]
        public decimal ItemPrice { get; set; }
        [Display(Name ="Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public DateTime OrderUpdateDate { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        
        public virtual Customer? Customer { get; set; }
    }
}
