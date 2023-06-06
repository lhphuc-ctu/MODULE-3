using DI.Helper;
using DIController.Infrastructure;
using DIController.Interfaces;
using DIController.Models;
using DIController.Models.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//var sampleWebsetting = builder.Configuration.AddJsonFile("samplewebsettings.json", optional: false, reloadOnChange: true);
//builder.Services.Configure<SampleWebSettings>((IConfiguration)sampleWebsetting);
builder.Configuration.AddJsonFile("samplewebsettings.json", optional: false, reloadOnChange: true);
builder.Services.Configure<SampleWebSettings>(builder.Configuration);


//var sampleWebsetting = builder.Configuration.GetSection("SampleWebsetting").Get<SampleWebSettings>();
//builder.Services.AddSingleton(sampleWebsetting);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<ITodoItemRepository, TodoItemRepository>();
builder.Services.AddTransient<StatisticsService>();
builder.Services.AddTransient<ProfileOptionsService>();
builder.Services.AddTransient<MyHtmlHelper>();


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
