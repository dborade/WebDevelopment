using Microsoft.EntityFrameworkCore;
using ClassSchedule.Models;

namespace ClassSchedule.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }
        public DbSet<ClassScheduler> ClassScheduler { get; set; }
    }
}