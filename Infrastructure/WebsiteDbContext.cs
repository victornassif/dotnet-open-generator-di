using Microsoft.EntityFrameworkCore;

namespace Open_Generics_Dependency_Injection.Infrastructure
{
    public class WebsiteDbContext(DbContextOptions<WebsiteDbContext> options): DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
