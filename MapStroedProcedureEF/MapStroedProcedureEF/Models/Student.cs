using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MapStroedProcedureEF.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Display(Name ="Student Name")]
        public string StudentName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }
    }
}
