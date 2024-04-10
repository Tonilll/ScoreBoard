using Microsoft.EntityFrameworkCore;
using ScoreBoard.Models;
using ScoreBoard.ViewModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CatalogueJoueurDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:CatalogueJoueurDbContextConnection"]);
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "modifier",
    pattern: "{controller=Joueur}/{action=Modifier}/{id?}");

InitialiseurBD.Seed(app);

app.Run();
