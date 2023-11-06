using LibraryApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Uygulama ayarlarını al
var configuration = builder.Configuration;

// Servisleri tanımla
builder.Services.AddDbContext<LibraryAppDbContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("LibraryAppDbConnectionString")));


builder.Services.AddPersistanceLayer();

// Add services to the container.
builder.Services.AddControllersWithViews();



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