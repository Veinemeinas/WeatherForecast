using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WeatherForecast.Context;
using WeatherForecast.Repositories;
using WeatherForecast.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
var _config = builder.Configuration;
string connectionString = _config.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<WeatherForecastContext>(option => option.UseSqlServer(connectionString));
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<WeatherForecastContext>();
builder.Services.AddScoped<FavoritePlacesService>();
builder.Services.AddScoped<VisitedPlaceRepository>();
builder.Services.AddSingleton<PlacesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
