using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using System.Xml.Linq;

namespace ManyToOneDemoCodeFirst.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, ErrorMessage = "Can not accept more then 40 aplhabets")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Name should contain atlist 3 character")]
        public string StudentName { get; set; }

        [Display(Name = "Student Address")]
        [Required(ErrorMessage = "Adress is required")]
        public string StudentAddress { get; set; }

        [Display(Name = "Student Email")]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@([a-zA-Z0-9]+\\.)+(edu|ac|com\\.([a-zA-Z]{2,3}))$", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        public int ProjectId { get; set; }
        public Project? Project { get; set; }
    }
}
