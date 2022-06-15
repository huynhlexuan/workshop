using Microsoft.EntityFrameworkCore;
using CustomerServices.Models;

namespace CustomerServices.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Customer>()
                .HasKey(c => c.CustomerId);
        }
    }
}
