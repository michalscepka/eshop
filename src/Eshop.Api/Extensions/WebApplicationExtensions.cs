namespace Eshop.Api.Extensions;

public static class WebApplicationExtensions
{
    public static void AddSwagger(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            var descriptions = app.DescribeApiVersions();
            foreach (var description in descriptions)
            {
                options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                    $"Eshop.Api {description.GroupName.ToUpperInvariant()}");
            }
        });
    }
}
