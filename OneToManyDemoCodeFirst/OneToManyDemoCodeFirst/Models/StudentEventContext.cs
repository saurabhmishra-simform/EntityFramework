using Microsoft.EntityFrameworkCore;

namespace OneToManyDemoCodeFirst.Models
{
    public class StudentEventContext : DbContext
    {
        public StudentEventContext(DbContextOptions<StudentEventContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
