using Microsoft.EntityFrameworkCore;

namespace ECommerce.WebApp.Models.Data;

public class ECommerceDbContext : DbContext
{
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
    }
}

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasData(
                new Category() { Id = 1, ShortName = "Food", LongName = "Food", Description = "Fresh food for you", Active = true },
                new Category() { Id = 2, ShortName = "Drink", LongName = "Drink", Description = "Best serve", Active = true },
                new Category() { Id = 3, ShortName = "Dessert", LongName = "Dessert", Description = "Dessert will make your day", Active = true });
    }
}
