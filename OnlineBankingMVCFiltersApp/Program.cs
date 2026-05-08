using OnlineBankingMVCFiltersApp.Filters;
using OnlineBankingMVCFiltersApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<GlobalExceptionFilter>();
});

builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<LoggingService>();

builder.Services.AddScoped<AuthenticationFilter>();
builder.Services.AddScoped<AuthorizationFilter>();
builder.Services.AddScoped<LoggingFilter>();
builder.Services.AddScoped<GlobalExceptionFilter>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bank}/{action=Dashboard}/{id?}");

app.Run();