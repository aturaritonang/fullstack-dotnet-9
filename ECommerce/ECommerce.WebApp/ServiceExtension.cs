using ECommerce.WebApp.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECommerce.WebApp;

public static class ServiceExtension
{
    public static void AddDomainContext(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.AddDbContext<ECommerceDbContext>(options => {
            options.UseSqlServer(configuration.GetConnectionString("DatabaseConnection"));
        });
    }
}
