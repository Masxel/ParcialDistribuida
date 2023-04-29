using AG_TicketPass.WEB;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSweetAlert2();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7138//") });

await builder.Build().RunAsync();
