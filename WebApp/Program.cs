using Domain.Models;
using Infrastructure.DataContext;
using Infrastructure.Interfaces;
using Infrastructure.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddScoped<ICar, CarService>();
builder.Services.AddScoped<ICarLocation, CarLocationsService >();
builder.Services.AddScoped<ICustomer, CustomerService > ();
builder.Services.AddScoped<ILocation, LocationService>();
builder.Services.AddScoped<IRental, RentalService>();
builder.Services.AddScoped<CarParkDbContext>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "WebApp v1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();