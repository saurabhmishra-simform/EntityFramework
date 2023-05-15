using Microsoft.EntityFrameworkCore;

namespace OneToManyDemoCodeFirst.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                   new Student
                   {
                       StudentId = 8,
                       StudentName = "Ramesh",
                       StudentAddress = "Anand",
                       Email = "ramesh@gmail.com",
                       Date = Convert.ToDateTime(new DateTime(12 / 05 / 1998)),
                       Password = "ramesh@123",
                       ConfirmPassword = "ramesh@123",
                       Age = 25,
                       Gender = Gender.male,
                   },
                   new Student
                   {
                       StudentId = 9,
                       StudentName = "Ram",
                       StudentAddress = "Lucknow",
                       Email = "ram@gmail.com",
                       Date = Convert.ToDateTime(new DateTime(08 / 02 / 1991)),
                       Password = "ram@123",
                       ConfirmPassword = "ram@123",
                       Age = 27,
                       Gender = Gender.male,
                   }
            );
        }
    }
}
