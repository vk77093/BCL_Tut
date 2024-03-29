using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TestProject1.Data;
using TestProject1.Pages.AutoComplete.Repos;
using TestProject1.Pages.Toast.Service;
using TestProject1.Pages.VirualizeCompTest;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//AutoComplete
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddSingleton<HttpClient>();

//Toast Service
builder.Services.AddScoped<IToastService, ToastService>();


//virtual comp test
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
