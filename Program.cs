using Microsoft.Extensions.DependencyInjection;
using Spice_Wise.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
    app.UseHsts();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
