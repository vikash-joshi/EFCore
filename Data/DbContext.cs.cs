using Microsoft.EntityFrameworkCore;

namespace main_ef_core
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        {
            
        }

    }
}