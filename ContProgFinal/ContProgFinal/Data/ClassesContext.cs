using ContProgFinal.Models;
using Microsoft.EntityFrameworkCore;

namespace ContProgFinal.Data
{
    public class ClassesContext: DbContext
    {
        public ClassesContext(DbContextOptions<ClassesContext> options): base(options)
        {

        }
        public DbSet<Classes> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classes>().ToTable("Class");
        }
    }
}
