using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Business.Concrete;
using GumuscayTurizm.Data;
using GumuscayTurizm.Data.Abstract;
using GumuscayTurizm.Data.Concrete;
using GumuscayTurizm.WebUI.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<IdentityContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

builder.Services.AddIdentity<MyUser, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;

    options.Lockout.MaxFailedAccessAttempts = 5;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    options.Lockout.AllowedForNewUsers = true;

    options.User.RequireUniqueEmail = true;

    options.SignIn.RequireConfirmedEmail = false;
});







builder.Services.AddDbContext<GTContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
builder.Services.AddScoped<ICityRepository, EfCoreCityRepository>();
builder.Services.AddScoped<ITicketRepository, EfCoreTicketRepository>();
builder.Services.AddScoped<ITripRepository, EfCoreTripRepository>();
builder.Services.AddScoped<IBusRepository, EfCoreBusRepository>();
builder.Services.AddScoped<IPassengerRepository, EfCorePassengerRepository>();
builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<ITicketService, TicketManager>();
builder.Services.AddScoped<IBusService, BusManager>();
builder.Services.AddScoped<ITripService, TripManager>();
builder.Services.AddScoped<IPassengerService, PassengerManager>();

builder.Services.AddControllersWithViews();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
   
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
