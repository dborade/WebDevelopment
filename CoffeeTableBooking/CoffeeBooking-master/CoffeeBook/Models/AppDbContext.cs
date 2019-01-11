using Microsoft.EntityFrameworkCore;
using CoffeeBooking.Models;

namespace CoffeeBooking.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }
        public DbSet<Restaurant> Restaurant { get; set; } 
        public DbSet<Table> Table { get; set; } 
        public DbSet<CoffeeBooking.Models.Customer> Customer { get; set; }
    }
}