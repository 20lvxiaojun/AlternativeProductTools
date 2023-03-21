using AlternativeTool.Web.Client.Services;
using AlternativeTool.Web.Client.Services.Contacts;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeTool.Web.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = 
                new Uri("https://localhost:7001") });
            builder.Services.AddScoped<IProductService, ProductService>();
            await builder.Build().RunAsync();
        }
    }
}
