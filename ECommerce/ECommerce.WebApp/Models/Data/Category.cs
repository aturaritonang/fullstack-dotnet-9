using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.WebApp.Models.Data;

public class Category: BaseSchema
{
    public int Id { get; set; }
    public string ShortName { get; set; }
    public string LongName { get; set; }
    public string Description { get; set; }
}

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ShortName).IsRequired().HasMaxLength(10);
        builder.Property(x => x.LongName).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Description).IsRequired(false).HasMaxLength(255);
        builder.Property(x => x.Active).HasDefaultValue(false);
    }
}
