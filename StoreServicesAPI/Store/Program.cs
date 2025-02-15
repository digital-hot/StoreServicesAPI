using Microsoft.EntityFrameworkCore;
using StoreServicesAPI.Store.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.AddDbContext<StoreData>(options =>
    options.UseSqlite("Data Source=store.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}



app.MapGet("/weatherforecast", () =>
{
    return Results.Ok(DateTime.Now);
})
.WithName("GetWeatherForecast");

app.MapControllers();

app.UseHttpsRedirection();

app.Run();
