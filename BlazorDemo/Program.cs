using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorDemo;
using BlazorDemo.Service;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<GlobalStateDemo>();


//Hämtar info från konfigurationsfil, sen lägger till en instans av ApiService som tjänst
var weatherApiKey = builder.Configuration["WeatherApiKey"];
builder.Services.AddSingleton(new ApiService(weatherApiKey));



await builder.Build().RunAsync();
