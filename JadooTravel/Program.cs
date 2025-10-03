using JadooTravel.Services.CategoryServices;
using JadooTravel.Services.DestinationServices;
using JadooTravel.Services.FeatureServices;
using JadooTravel.Services.PartnerServices;
using JadooTravel.Services.TestimonialServices;
using JadooTravel.Settings;
using Microsoft.Extensions.Options;
using OpenAI;
using OpenAI.Chat;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IDestinationService , DestinationService>();
builder.Services.AddScoped<ITestimonialService , TestimonialService>();
builder.Services.AddScoped<IPartnerService  , PartnerService>();
builder.Services.AddScoped<IFeatureService  , FeatureService>();

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettingsKey"));
builder.Services.AddScoped<IDatabaseSettings>(sp =>
{
    return sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;   
});


var apiKey = builder.Configuration["OpenAI:ApiKey"];
builder.Services.AddSingleton(sp => new OpenAIClient(apiKey));


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
