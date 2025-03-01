using Eshop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureAppConfiguration(config =>
{
    var environmentName = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");

    var currentDir = new DirectoryInfo(AppContext.BaseDirectory);
    while (currentDir != null && currentDir.GetFiles("*.sln").Length == 0)
        currentDir = currentDir.Parent;

    var basePath = currentDir != null
        ? Path.Combine(currentDir.FullName, "Eshop.Api")
        : throw new DirectoryNotFoundException("Could not locate Eshop.Api folder");
    
    config.SetBasePath(basePath)
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true);
});
builder.ConfigureServices((hostBuilder, services) =>
{
    services.AddDbContext<EshopDbContext>(options =>
        options.UseSqlServer(hostBuilder.Configuration.GetConnectionString("Database")));
});

var host = builder.Build();

using (var scope = host.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<EshopDbContext>();
    dbContext.Database.Migrate();
}

Console.WriteLine("Migrations applied successfully.");
