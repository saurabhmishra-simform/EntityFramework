using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FromExistingDBCOdeFirst
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=SchoolContext")
        {
        }

        public virtual DbSet<tblGender> tblGenders { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblGender>()
                .HasMany(e => e.tblStudents)
                .WithOptional(e => e.tblGender)
                .HasForeignKey(e => e.GenderId);
        }
    }
}
