using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using dotnetblazorwasm;
using DataServices.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<GiphyServices, GiphyServices>();

await builder.Build().RunAsync();
