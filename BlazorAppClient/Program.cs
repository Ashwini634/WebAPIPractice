using BlazorAppClient;
using BlazorAppClient.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddSyncfusionBlazor();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzY4ODAwMEAzMjM4MmUzMDJlMzBmR0lqSE92RjJzOHp2VWx0ZnFUYSsrOEt2VURNRzZrQmg5WG5va09KNjBnPQ==");

await builder.Build().RunAsync();
