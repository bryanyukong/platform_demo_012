using Microsoft.EntityFrameworkCore;

namespace Platform.Shared
{
    public class PlatformContext : DbContext
    {
        public PlatformContext(DbContextOptions<PlatformContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(k => new { k.Id });
            modelBuilder.Entity<Order>().HasKey(k => new { k.Id });
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}