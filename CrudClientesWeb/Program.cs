using CrudClientesWeb;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var baseUrl = "https://localhost:7296";

builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri(baseUrl) 
});

await builder.Build().RunAsync();
