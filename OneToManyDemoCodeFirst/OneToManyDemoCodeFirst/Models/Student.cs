using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneToManyDemoCodeFirst.Models
{
    public enum Gender
    {
        male, female
    }

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

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //[Display(Name = "Student Branch")]
        //public string StudentBranch { get; set; }

        [Display(Name = "Student Password")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password doesnot match")]
        public string ConfirmPassword { get; set; }

        [Range(18, 30, ErrorMessage = "Age should lie btw 18 to 30")]
        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        public Gender? Gender { get; set; }
    }
}
