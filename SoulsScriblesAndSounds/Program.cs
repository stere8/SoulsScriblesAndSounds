using System.Configuration;
using Microsoft.EntityFrameworkCore;
using SoulsScribblesAndSounds.Models;
using AspNet.Security.OAuth.Spotify;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration configuration = builder.Configuration;

builder.Services.AddRazorPages();

builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DbConnection")));
//builder.Services.AddAuthentication()
//    .AddSpotify(options => 
//    {
//        options.ClientId = configuration.GetConnectionString("SpotifyClientID");
//        options.ClientSecret = configuration.GetConnectionString("SpotifyClientSecret");
//        options.SaveTokens = true; // Important for refreshing tokens later
//    });

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();