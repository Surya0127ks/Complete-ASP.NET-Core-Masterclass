using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Models
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
