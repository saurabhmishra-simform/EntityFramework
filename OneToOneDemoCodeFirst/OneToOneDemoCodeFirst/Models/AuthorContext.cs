using Microsoft.EntityFrameworkCore;

namespace OneToOneDemoCodeFirst.Models
{
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBio> AuthorBios { get; set; }
    }
}
