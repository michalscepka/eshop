using Asp.Versioning;
using Microsoft.OpenApi.Models;

namespace Eshop.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;
            })
            .AddApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });
        
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Eshop.Api",
                Version = "v1"
            });
            options.SwaggerDoc("v2", new OpenApiInfo
            {
                Title = "Eshop.Api",
                Version = "v2"
            });
        });
        
        return services;
    }
}
