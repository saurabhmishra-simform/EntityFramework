using Microsoft.EntityFrameworkCore;

namespace OneToOneDemoCodeFirst.Models
{
    public class StudentEventContext : DbContext
    {
        public StudentEventContext(DbContextOptions<StudentEventContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get;set; }
        public DbSet<Event> Events { get;set; }
    }
}
