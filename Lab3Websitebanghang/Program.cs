using Microsoft.EntityFrameworkCore;
using Lab3Websitebanghang.Models;
using Lab3Websitebanghang.Repositories;

var builder = WebApplication.CreateBuilder(args);

//Cau hinh EF
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



// Add services to the container.
builder.Services.AddControllersWithViews();

//Dang ky
builder.Services.AddScoped<IProductRepo, EFProductRepository>();
builder.Services.AddScoped<ICategoryRepo, EFCategoryRepo>();

var app = builder.Build();

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
