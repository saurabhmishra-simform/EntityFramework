using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManyToManyDemoCodeFirst.Models
{
    [Table("Teacher")]
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }

        [Display(Name = "Teacher Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, ErrorMessage = "Can not accept more then 40 aplhabets")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        [MinLength(3, ErrorMessage = "Name should contain atlist 3 character")]
        public string TeacherName { get; set; }

        [Display(Name = "Teacher Email")]
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@([a-zA-Z0-9]+\\.)+(edu|ac|com\\.([a-zA-Z]{2,3}))$", ErrorMessage = "Invalid email")]
        public string TeacherEmail { get; set; }

        [Display(Name = "JoiningDate")]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [Display(Name = "Salary")]
        [Required(ErrorMessage = "Salary is required")]
        public decimal Salary { get; set; }

        public IList<TeacherCourse>? TeacherCourses { get; set; }
    }
}
