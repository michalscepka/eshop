using Eshop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

try
{
    Log.Logger = new LoggerConfiguration()
        .WriteTo.Console(theme: AnsiConsoleTheme.Code)
        .CreateLogger();

    Log.Information("Starting up");
    var builder = Host.CreateDefaultBuilder(args);

    builder.ConfigureAppConfiguration(config =>
    {
        var environmentName = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
    
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        config.AddJsonFile($"appsettings.{environmentName}.json", optional: true, reloadOnChange: true);
    });
    builder.ConfigureServices((hostBuilder, services) =>
    {
        services.AddDbContext<EshopDbContext>(options =>
            options.UseSqlServer(hostBuilder.Configuration.GetConnectionString("Database")));
    });

    var host = builder.Build();

    using (var scope = host.Services.CreateScope())
    {
        Log.Information("Applying database migrations");
        var dbContext = scope.ServiceProvider.GetRequiredService<EshopDbContext>();
        dbContext.Database.Migrate();
    }

    Log.Information("Migrations applied successfully");
}
catch (Exception ex)
{
    Log.Fatal(ex, "Terminated unexpectedly");
}
finally
{
    Log.Information("Shutting down application");
    await Log.CloseAndFlushAsync();
}
