using Eshop.Infrastructure.Persistence.Repositories;
using Eshop.Infrastructure.Persistence.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eshop.Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<EshopDbContext>(opt =>
        {
            var connectionString = configuration.GetConnectionString("Database");
            opt.UseSqlServer(connectionString);
        });

        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
