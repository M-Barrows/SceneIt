using Microsoft.EntityFrameworkCore;
using TVTracker.Models;

namespace TVTracker.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }
        public DbSet<TVTracker.Models.TVProgram> TVProgram { get; set; }
    }
}