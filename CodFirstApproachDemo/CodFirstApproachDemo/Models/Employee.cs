using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CodFirstApproachDemo.Models
{
    public class Employee
    {
        [Key] //primary key
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
    }
}
