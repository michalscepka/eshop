using Eshop.Api.Extensions;
using Eshop.Infrastructure.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddVersioning();

builder.Services.AddPersistence(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.AddSwagger();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
