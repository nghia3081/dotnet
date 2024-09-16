using Microsoft.EntityFrameworkCore;

namespace one.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }
        public SchoolContext(DbContextOptions<SchoolContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
    }
}
