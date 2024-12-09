using Microsoft.EntityFrameworkCore;

namespace ECommerce.WebApp.Models.Data;

public class ECommerceDbContext: DbContext
{
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
    }
}
