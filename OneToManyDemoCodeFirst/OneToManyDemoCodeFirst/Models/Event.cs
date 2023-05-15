using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace OneToManyDemoCodeFirst.Models
{
    [Table("Event")]
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Display(Name = "Event Name")]
        [Required(ErrorMessage = "Event name is required")]
        [StringLength(40, ErrorMessage = "Can not accept more then 40 aplhabets")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Event name should contain atlist 3 character")]
        public string EventName { get; set; }

        [Display(Name = "Event Price")]
        [Required(ErrorMessage = "Evet price is required")]
        public decimal EventPrice { get; set; }

        [Display(Name = "Event Date")]
        [Required(ErrorMessage = "Evet date is required")]
        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        //[Display(Name = "Event Address")]
        //public string EventAddress { get; set; }
        public virtual Student? Student { get; set; }
        public int StudentId { get; set; }
    }
}
