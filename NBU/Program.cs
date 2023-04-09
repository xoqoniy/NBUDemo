using Microsoft.EntityFrameworkCore;
using NBU.Data;
using NBU.Data.Configurations;
using NBU.Data.IRepositories;
using NBU.Data.Repositories;
using NBU.Models;
using NBU.Service.Interfaces;
using NBU.Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NBUContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("NBUDb") ?? throw new InvalidOperationException("NBUDb can't be found"), b => b.MigrationsAssembly("NBU")));
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
var app = builder.Build();
SeedInfo.Initialize(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
