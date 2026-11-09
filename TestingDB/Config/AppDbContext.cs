using Microsoft.EntityFrameworkCore;

namespace TestingDB.Config
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) 
        {
            
        }
    }
}
