using Microsoft.EntityFrameworkCore;

namespace SeedDemo.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        EmployeeName = "Saurabh",
                        Salary = 56000,
                    },
                    new Employee
                    {
                        Id = 2,
                        EmployeeName = "Jimit",
                        Salary = 58000,
                    }
             );
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
