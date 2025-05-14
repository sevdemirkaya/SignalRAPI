using SignalR.BussinessLayer.Abstract;
using SignalR.BussinessLayer.Concrete;

using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.EntityFramework;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SignalRContext>();
builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutDal>();

builder.Services.AddScoped<IBookingService, BookingManager>();
builder.Services.AddScoped<IBookingDal, EfBookingDal>();
builder.Services.AddControllers();


// SWAGGER EKLENÝYOR
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "SignalRWebUI API",
        Version = "v1"
    });
});
// MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// DEVELOPMENT ortamýnda SWAGGER çalýþtýr
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "SignalRWebUI API V1");
    });
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

