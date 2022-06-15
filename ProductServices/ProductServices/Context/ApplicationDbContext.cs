using Microsoft.EntityFrameworkCore;
using ProductServices.Models;

namespace ProductServices.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>()
                .HasKey(pd => pd.ProductId);
        }
    }
}
