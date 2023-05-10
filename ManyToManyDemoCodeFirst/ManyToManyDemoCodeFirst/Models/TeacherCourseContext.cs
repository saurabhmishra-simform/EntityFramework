using Microsoft.EntityFrameworkCore;

namespace ManyToManyDemoCodeFirst.Models
{
    public class TeacherCourseContext : DbContext
    {
        public TeacherCourseContext(DbContextOptions<TeacherCourseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeacherCourse>().HasKey(tc => new { tc.TeacherId, tc.CourseId });
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }
    }
}
